# Unity-Logs-Viewer

下载链接：

GitHub：https://github.com/aliessmael/Unity-Logs-Viewer/tree/master

LogViewer使用说明：[[游戏开发\][Untiy]跨平台可视化Log系统_unity log viewer-CSDN博客](https://blog.csdn.net/liuyongjie1992/article/details/134422268)

把包直接丢到工程里


点击工具栏Tools->LogViewer->CreateReporter，会创建一个GameObject

Num Of Circle To Show参数是滑动几圈开启这个Log，一般设置成3，

例如下图中滑动屏幕转圈。

关闭UI就是右上角的X按钮

注意事项
项目上线时隐藏掉这个物体GameObject功能就关闭了

可以做一个上线工具，如果是Debug版本启动时打开，非Debug版本则关闭

因为适配原因右上角的关闭按钮有可能显示不到，顶部的菜单栏可以滑动，往左滑可以看到
