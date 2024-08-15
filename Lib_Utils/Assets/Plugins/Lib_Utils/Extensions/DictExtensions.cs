using System.Collections.Generic;
using System.Linq;

namespace Utils.Extensions
{
    public static class DictExtension
    {
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

        public static List<T2> GetNotNullList<T1, T2>(this Dictionary<T1, List<T2>> dic, T1 key)
        {
            if (!dic.ContainsKey(key))
            {
                dic.Add(key, new List<T2>());
            }

            return dic[key];
        }

        public static List<(T1, T2)> GetPairList<T1, T2>(this Dictionary<T1, T2> dic)
        {
            return dic.Select(pair => (pair.Key, pair.Value)).ToList();
        }

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