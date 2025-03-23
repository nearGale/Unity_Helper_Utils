# Unity_Helper_Utils
## Unity的工具库

| 功能名称     | 相关类              | 用法                           |
| ------------ | ------------------- | ------------------------------ |
|  | FindObjectReference | （右键资源：FindAllReference） |
|    字符串工具 |  CommonHelper(StringHelper)   |  1. 字符串Unicode转GBK    |
|              |                     |                                |

### 开发了一些工具：

#### 1、引用查找工具  
相关类：FindObjectReference  
用法：右键资源，FindAllReference，会在Console中打印出它在哪些资源中有引用  
![image](https://github.com/user-attachments/assets/b8193f38-436c-4a25-9578-3b83974119d7)  
![image](https://github.com/user-attachments/assets/eebf0b09-e296-4652-b1d3-c66d7ecbdc78)

#### 2、CommonHelper 工具
Json工具：  
Json读取：CommonHelper.ReadJson(string name)  

字符串工具：  
UniCode转GBK：CommonHelper.ConvertUnicodeToGBK(string str)  

Transform 工具：  
将Transform子节点全部移动到另一个节点下：CommonHelper.MoveAllChildren(Transform oldParent, Transform newParent)  

#### 3、类型功能扩展
Object池化：
RecycleToPool(this object obj)
ConcurrentRecycleToPool(this object obj)
RecycleListToPool<T>(this List<T> list)

字典：  
对于Item为List的字典，创建或添加元素到List中：CreateOrAddToList<T1, T2>(this Dictionary<T1, List<T2>> dic, T1 key, T2 data)
对于Item为List的字典，直接取到不为空的Item：GetNotNullList<T1, T2>(this Dictionary<T1, List<T2>> dic, T1 key)
把字典的 KvPair 转成 List：GetPairList<T1, T2>(this Dictionary<T1, T2> dic)
字典取值，带默认值：Get<TKey, TValue>(this Dictionary<TKey, TValue> dic, TKey key, TValue defaultValue)

Float：
设定特别小的数作为判 0 阈值：FLOAT_ZERO_THRESHOLD = 1e-6f;
判断特别小的 float 是否为 0：IsZero(this float number)

字符串：
判空：IsNullOrEmpty(this string value)  
首字母小写：FirstLower(this string value)  
首字母大写：FirstUpper(this string value)  
IP字符串转换：ToIPEndPoint(this string ipAddr)  
迭代器转字符串：GetString<T>(this IEnumerable<T> list, string separator = null)  
类型转换：  
ConvertToSByte(this string value, sbyte defaultValue = default)  
ConvertToShort(this string value, short defaultValue = default)  
ConvertToInt(this string value, int defaultValue = default)  
ConvertToLong(this string value, long defaultValue = default)  
ConvertToByte(this string value, byte defaultValue = default)  
ConvertToUShort(this string value, ushort defaultValue = default)  
ConvertToUInt(this string value, uint defaultValue = default)  
ConvertToULong(this string value, ulong defaultValue = default)  
ConvertToFloat(this string value, float defaultValue = default)  
ConvertToDouble(this string value, double defaultValue = default)  
ConvertToBool(this string value, bool defaultValue = default)  
ConvertToString(this string value, bool defaultValue = default)  
ConvertToSByteAry(this string value, char separator = default)  
ConvertToSByteAryAry(this string value, char arySeparator, char separator = default)  
ConvertToShortAry(this string value, char separator = default)  
ConvertToShortAryAry(this string value, char arySeparator, char separator = default)  
ConvertToIntAry(this string value, char separator = default)  
ConvertToIntAryAry(this string value, char arySeparator, char separator = default)  
ConvertToEnum<T>(this string value) where T : Enum  
ConvertToEnumAry<T>(this string value, char separator = default) where T : Enum  
ConvertToEnumAryAry<T>(this string value, char arySeparator, char separator = default)  
ConvertToLongAry(this string value, char separator = default)  
ConvertToLongAryAry(this string value, char arySeparator, char separator = default)  
ConvertToByteAry(this string value, char separator = default)  
ConvertToByteAryAry(this string value, char arySeparator, char separator = default)  
ConvertToUShortAry(this string value, char separator = default)  
ushort[][] ConvertToUShortAryAry(this string value, char arySeparator, char separator = default)  
uint[] ConvertToUIntAry(this string value, char separator = default)  
uint[][] ConvertToUIntAryAry(this string value, char arySeparator, char separator = default)  
ulong[] ConvertToULongAry(this string value, char separator = default)  
ulong[][] ConvertToULongAryAry(this string value, char arySeparator, char separator = default)  
float[] ConvertToFloatAry(this string value, char separator = default)  
float[][] ConvertToFloatAryAry(this string value, char arySeparator, char separator = default)  


Vector：
Normalized(this Vector2 value)
Normalized(this Vector3 value)
默认forward：Vector3.UnitZ;

### 集成了一些通用工具：  
![image](https://github.com/user-attachments/assets/d35d4c6d-854c-425f-95c6-bfc18c7b63e6)

#### 1、Excel 配置读取工具![077C794F](https://github.com/user-attachments/assets/4325a005-bf27-47ab-af33-ae0355251f8a)
  
https://github.com/nearGale/Unity_Helper_ExcelReader

#### 2、LitJson  
https://litjson.net/  

#### 3、Unity-Logs-Viewer
https://github.com/aliessmael/Unity-Logs-Viewer
![image](https://github.com/user-attachments/assets/c355a6d0-ffc1-4553-b74e-9a487f0ff9ed)

