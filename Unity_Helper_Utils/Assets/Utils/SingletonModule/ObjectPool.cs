using System.Collections.Concurrent;
using System.Collections.Generic;
using System;

/// <summary>
/// 对象池
/// TODO：
///     1 接入模块统一管理
/// </summary>
public class ObjectPool : Singleton<ObjectPool>
{
    private const int POOL_ITEM_COUNT_MAX = 1000;
    private readonly Dictionary<Type, Queue<object>> _pool = new();
    private readonly ConcurrentDictionary<Type, ConcurrentQueue<object>> _cPool = new();

    public override void Dispose()
    {
        _pool.Clear();
    }

    public T Get<T>() where T : new()
    {
        if (!_pool.TryGetValue(typeof(T), out var queue))
        {
            return Activator.CreateInstance<T>();
        }

        return queue.Count == 0 ? Activator.CreateInstance<T>() : (T)queue.Dequeue();
    }

    public object Get(Type type)
    {
        if (!_pool.TryGetValue(type, out var queue))
        {
            return Activator.CreateInstance(type);
        }

        return queue.Count == 0 ? Activator.CreateInstance(type) : queue.Dequeue();
    }

    public void Recycle(ref object obj)
    {
        var type = obj.GetType();
        if (!_pool.TryGetValue(type, out var queue))
        {
            queue = new Queue<object>();
            _pool.Add(type, queue);
        }

        if (queue.Count > POOL_ITEM_COUNT_MAX)
        {
            obj = null;
            return;
        }

        queue.Enqueue(obj);
        obj = null;
    }

    public void InitCapacity<T>(int count)
    {
        var type = typeof(T);
        if (!_pool.TryGetValue(typeof(T), out var queue))
        {
            queue = new Queue<object>();
            _pool.Add(type, queue);
        }

        var initCount = Math.Min(count, POOL_ITEM_COUNT_MAX);

        if (queue.Count >= initCount)
        {
            return;
        }

        for (var i = 0; i < initCount - queue.Count; i++)
        {
            queue.Enqueue(Activator.CreateInstance<T>());
        }
    }

    public T ConcurrentGet<T>() where T : new()
    {
        var queue = _cPool.GetOrAdd(typeof(T), new ConcurrentQueue<object>());
        if (queue.TryDequeue(out var obj))
        {
            return (T)obj;
        }

        return Activator.CreateInstance<T>();
    }

    public void ConcurrentRecycle(ref object obj)
    {
        var type = obj.GetType();
        var queue = _cPool.GetOrAdd(type, new ConcurrentQueue<object>());
        queue.Enqueue(obj);
        obj = null;
    }

}