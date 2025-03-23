using System.Collections.Generic;
using System.Linq;

namespace Utils.Extensions
{
    public static class DictExtension
    {
        /// <summary>
        /// 对于Item为List的字典，创建或添加元素到List中
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="dic"></param>
        /// <param name="key"></param>
        /// <param name="data"></param>
        public static void CreateOrAddToList<T1, T2>(this Dictionary<T1, List<T2>> dic, T1 key, T2 data)
        {
            if (dic.ContainsKey(key))
            {
                dic[key].Add(data);
            }
            else
            {
                dic.Add(key, new List<T2> { data });
            }
        }

        /// <summary>
        /// 对于Item为List的字典，直接取到不为空的Item
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="dic"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static List<T2> GetNotNullList<T1, T2>(this Dictionary<T1, List<T2>> dic, T1 key)
        {
            if (!dic.ContainsKey(key))
            {
                dic.Add(key, new List<T2>());
            }

            return dic[key];
        }

        /// <summary>
        /// 把字典的 KvPair 转成 List
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="dic"></param>
        /// <returns></returns>
        public static List<(T1, T2)> GetPairList<T1, T2>(this Dictionary<T1, T2> dic)
        {
            return dic.Select(pair => (pair.Key, pair.Value)).ToList();
        }

        /// <summary>
        /// 字典取值，带默认值
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dic"></param>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static TValue Get<TKey, TValue>(this Dictionary<TKey, TValue> dic, TKey key, TValue defaultValue)
        {
            if (dic.TryGetValue(key, out var value))
            {
                return value;
            }

            value = defaultValue;
            return value;
        }
    }
}