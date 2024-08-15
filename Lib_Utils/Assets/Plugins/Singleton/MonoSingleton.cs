using UnityEngine;

namespace Engine
{
    /// <summary>
    /// Mono 的单例化，继承实现后挂载到 GameObject 上
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    {
        public GameObject InstanceGameObject => Instance.gameObject;
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<T>();
                    if (_instance == null)
                    {
                        _instance = new GameObject(typeof(T).ToString(), typeof(T)).GetComponent<T>();
                    }
                }

                return _instance;
            }
        }

        protected virtual void Awake()
        {
            _instance = this as T;
        }

        protected virtual void OnDestroy()
        {
            _instance = null;
        }
    }
}