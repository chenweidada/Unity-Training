# Unity-Training
这里放一些学习Unity期间做的小demo

//2020年11月7日
放上一个宝可梦的小demo
教程来源：https://www.youtube.com/channel/UCswdeChigkx5uN1PwgfTqzQ

//2020年12月17日
放上一个模仿CSOL的昼夜求生2模式的射击游戏DEMO（还没有做完）
以为太大传不了Github了，贴个网盘地址
百度网盘地址：链接：https://pan.baidu.com/s/17LWXYIDQTV7Ed75WPK2H-g 提取码：k7s6 

//2021年5/10日
放上一个模仿暗黑地牢制作的Demo，还有一个战棋游戏的Demo

模仿暗黑地牢Demo做了一半，面试的时候被指出没有什么技术力，就先放着不管了。

战棋游戏的Demo正在做战斗系统。
目前规划的模块
地图 —— 半完成；
战斗状态 —— 用状态设计模式做了一套循环，目前是可以玩家选择角色→选择移动位置→选择行动→如果是攻击的话选择攻击的目标，待机的话就结束→所有玩家的单位移动过后进入AI回合→AI回合结束后再次进入玩家回合；
单位 —— 差不多完成；
AI —— 刚写完步兵的一个AI状态，准备等战斗完善一点后再添加多几个状态和多几个种类的角色；
寻路 —— 用A*算法实现了一个寻路系统。//更新：看知乎大佬的解法，添加了带传送门的A*寻路，并且AI也会在寻路过程中考虑传送门
战斗 —— 正在完善，现在只做了个最简单的攻击；
装备 —— 做了个雏形；
