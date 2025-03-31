# Unity_Helper_Utils
# Unity的工具库  

## 开发的一些工具：  

### 1、引用查找工具  
相关类：**FindObjectReference**  
用法：右键资源，FindAllReference，会在Console中打印出它在哪些资源中有引用  
![image](https://github.com/user-attachments/assets/b8193f38-436c-4a25-9578-3b83974119d7)  
![image](https://github.com/user-attachments/assets/eebf0b09-e296-4652-b1d3-c66d7ecbdc78)  

### 2、对象池  
相关类：**ObjectPool**、**PoolObjectExtension**  
接口：  
ObjectPool.Instance.InitCapacity<T>(int count)  
ObjectPool.Instance.Get<T>()  
ObjectPool.Instance.ConcurrentGet<T>()  
ObjectPool.Instance.Dispose()  
RecycleToPool(this object obj)  
ConcurrentRecycleToPool(this object obj)  
RecycleListToPool<T>(this List<T> list)  
![image](https://github.com/user-attachments/assets/eacb8522-f513-4b7f-90ea-c1318fd485f3)  

### 3、单例模式  
相关类：**Singleton**、**MonoSingleton**  

### 4、自定义 Logger  
相关类：**Logger**  
设定 LogLevel 及 LogColor  
![image](https://github.com/user-attachments/assets/8091f451-c7e7-44c2-9f35-b090a1bd8c3d)  
![image](https://github.com/user-attachments/assets/85166952-4344-4695-be62-93d812bee7fa)  
接口：  
Logger.ColorInfo(string color, string content, string info)  
Logger.Log(string format, params object[] param)  
Logger.LogWarning(string format, params object[] param)  
Logger.LogError(string format, params object[] param)  
Logger.LogAssertion(string format, params object[] param)  
Logger.LogException(Exception exception)  


### 5、CommonHelper 工具类  
![image](https://github.com/user-attachments/assets/d01630eb-6fad-491e-ba35-fd35d2f1a759)  

Json工具：  
Json读取：CommonHelper.ReadJson(string name)  

字符串工具：  
UniCode转GBK：CommonHelper.ConvertUnicodeToGBK(string str)  

Transform 工具：  
将Transform子节点全部移动到另一个节点下：CommonHelper.MoveAllChildren(Transform oldParent, Transform newParent)  

### 6、类型功能扩展  
#### Object池化：  
RecycleToPool(this object obj)  
ConcurrentRecycleToPool(this object obj)  
RecycleListToPool<T>(this List<T> list)  

#### 字典：  
对于Item为List的字典，创建或添加元素到List中：CreateOrAddToList<T1, T2>(this Dictionary<T1, List<T2>> dic, T1 key, T2 data)  
对于Item为List的字典，直接取到不为空的Item：GetNotNullList<T1, T2>(this Dictionary<T1, List<T2>> dic, T1 key)  
把字典的 KvPair 转成 List：GetPairList<T1, T2>(this Dictionary<T1, T2> dic)  
字典取值，带默认值：Get<TKey, TValue>(this Dictionary<TKey, TValue> dic, TKey key, TValue defaultValue)  

#### Float：  
设定特别小的数作为判 0 阈值：FLOAT_ZERO_THRESHOLD = 1e-6f;  
判断特别小的 float 是否为 0：IsZero(this float number)  

#### 字符串：  
判空：IsNullOrEmpty(this string value)  
首字母小写：FirstLower(this string value)  
首字母大写：FirstUpper(this string value)  
IP字符串转换：ToIPEndPoint(this string ipAddr)  
迭代器转字符串：GetString<T>(this IEnumerable<T> list, string separator = null)  
##### 类型转换：  
和 byte、short、int、long、uint、ulong、float、double、bool、enum 及其数组、二维数组之间的转换  
如：  
float ConvertToFloat(this string value, float defaultValue = default)  
float[] ConvertToFloatAry(this string value, char separator = default)  
float[][] ConvertToFloatAryAry(this string value, char arySeparator, char separator = default)  
string ConvertToCSVGrid(this float value)  
string ConvertToCSVGrid(this float[] value, char separator = default)  
string ConvertToCSVGrid(this float[][] value, char arysSeparator, char separator = default)    


#### Vector：  
Normalized(this Vector2 value)  
Normalized(this Vector3 value)  
默认forward：Vector3.UnitZ  

## 集成的一些通用工具：  
![image](https://github.com/user-attachments/assets/d35d4c6d-854c-425f-95c6-bfc18c7b63e6)  

### 1、Excel 配置读取工具![077C794F](https://github.com/user-attachments/assets/4325a005-bf27-47ab-af33-ae0355251f8a)  
https://github.com/nearGale/Unity_Helper_ExcelReader  
![image](https://github.com/user-attachments/assets/b126c288-047a-42d6-a1f0-e761b5f1b34c)  


### 2、UGUI 组件自动生成代码工具![077C794F](https://github.com/user-attachments/assets/4325a005-bf27-47ab-af33-ae0355251f8a)  
https://github.com/nearGale/Unity_Helper_UGUICodeGenerator  
版本：v1.250331  
![image](https://github.com/user-attachments/assets/ac832111-feb5-450d-a7d9-7d4c7d1e9550)  


### 3、LitJson  
https://litjson.net/  
![image](https://github.com/user-attachments/assets/d27972f8-57f5-4a1e-a806-cd997df885c3)  


### 4、Unity-Logs-Viewer  
https://github.com/aliessmael/Unity-Logs-Viewer  
![image](https://github.com/user-attachments/assets/c355a6d0-ffc1-4553-b74e-9a487f0ff9ed)  
![image](https://github.com/user-attachments/assets/0fe0d5f9-e497-434a-8faf-34a0276a6e7f)  


### 5、Hot Reload  
![image](https://github.com/user-attachments/assets/0dd43784-efeb-480e-ac51-96705e9f4612)  

### 6、颜色代码存档  
![image](https://github.com/user-attachments/assets/e8cfa9d8-4d72-47dd-9a3d-b0e918cc50b1)  
![image](https://github.com/user-attachments/assets/07925d5f-ddf0-4219-a553-b05371b07fb7)  



