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

2021/5/22  
重构了部分逻辑，优化了AI(把判断最近玩家角色的逻辑从直接判断曼哈顿距离改成Dijsktra搜索最近的角色，效果会好一些，不过效率慢了点)。  
想了想还是不能够太依赖库，把原本用C#自带的SortedSet包装的优先队列学习着用堆实现了一下，插入复杂度上差不了多少，就是堆查找的时候是O(N)复杂度，比用红黑树实现的SortedSet来着慢了一点。    
2021/5/23  
写了一套BUFF系统，把BUFF效果触发分成5个方法，在对应的地方调用来改变角色数值，攻击伤害，行动回合的变化等。  
2021/5/24  
重构了关卡信息，加入了播放自定义剧情的功能，还有根据回合数触发关卡自定义事件。  
发现了个BUG,角色触发完可互动物体，如果玩家撤回操作，可互动物体不会还原，比如开完宝箱再撤回移动，宝箱还是处在被开了的状态，并且道具也在角色包里。  
然后用命令模式重构了角色触发道具的逻辑，支持了撤销移动会还原可互动物品。  
给角色加了个小血条。  