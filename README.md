# Unity_Helper_UtilsLibrary
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
字典：  
对于Item为List的字典，创建或添加元素到List中：Dictionary.CreateOrAddToList<T1, T2>(this Dictionary<T1, List<T2>> dic, T1 key, T2 data)
对于Item为List的字典，直接取到不为空的Item：Dictionary.GetNotNullList<T1, T2>(this Dictionary<T1, List<T2>> dic, T1 key)
把字典的 KvPair 转成 List：Dictionary.GetPairList<T1, T2>(this Dictionary<T1, T2> dic)
字典取值，带默认值：Get<TKey, TValue>(this Dictionary<TKey, TValue> dic, TKey key, TValue defaultValue)


### 集成了一些通用工具：  
![image](https://github.com/user-attachments/assets/d35d4c6d-854c-425f-95c6-bfc18c7b63e6)

#### 1、Excel 配置读取工具![077C794F](https://github.com/user-attachments/assets/4325a005-bf27-47ab-af33-ae0355251f8a)
  
https://github.com/nearGale/Unity_Helper_ExcelReader

#### 2、LitJson  
https://litjson.net/  

#### 3、Unity-Logs-Viewer
https://github.com/aliessmael/Unity-Logs-Viewer
![image](https://github.com/user-attachments/assets/c355a6d0-ffc1-4553-b74e-9a487f0ff9ed)

