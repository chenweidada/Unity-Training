﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ScenarioErro
{
    NullObject,
}

public enum ScenarioCommandType
{
    startCommand,textCommand,ifgotoCommand,gotoCommand,optionCommand,flagCommand,endCommand
}

public class ScenarioCommand
{
    public ScenarioCommandType type;
    public string[] parameter;
    public virtual void Run()
    {

    }
}

public class TextCommand : ScenarioCommand
{
    public TextCommand(string[] parameter)
    {
        type = ScenarioCommandType.textCommand;
        this.parameter = parameter;
        //text的parameter中，索引为0的是显示文本的Position，1为显示文本的名字，往后就是不同的语句
    }

    public override void Run()
    {
        //TO DO:播放文本
        Debug.Log("Show Text");
    }
}

public class IfGotoCommand : ScenarioCommand
{
    public IfGotoCommand(string[] parameter)
    {
        type = ScenarioCommandType.ifgotoCommand;
        this.parameter = parameter;
        //IfGoto的parameter中，索引为0的是条件,一般为一个变量，储存在了剧本导演类的堆栈里，1为去往位置的变量，也储存在剧本导演的堆栈里
    }

    public override void Run()
    {
        Debug.Log("IF true goto");
    }
}

public class GotoCommand : ScenarioCommand
{
    public GotoCommand(string[] parameter)
    {
        type = ScenarioCommandType.gotoCommand;
        this.parameter = parameter;
        //goto的parameter中，索引为0的是去往位置的变量，储存在剧本导演的堆栈里
    }

    public override void Run()
    {
        base.Run();
    }
}

public class FlagCommand : ScenarioCommand
{
    public FlagCommand(string[] parameter)
    {
        type = ScenarioCommandType.flagCommand;
        this.parameter = parameter;
        //flag的parameter中，索引为0的是锁需要储存在剧本导演的堆栈里的变量的名字，1是位置
    }

    public override void Run()
    {
        GameDirecter.instance.ScenarioHeap.Add(parameter[0], int.Parse(parameter[1]));
    }
}

public class OptionCommand : ScenarioCommand
{
    public OptionCommand(string[] parameter)
    {
        type = ScenarioCommandType.optionCommand;
        this.parameter = parameter;
        //option的parameter中，索引为偶数为选项变量，奇数为选项的Text
    }

    public override void Run()
    {
        for(int i = 0; i < parameter.Length; i++)
        {
            /*奇数的变量将加到堆栈中，偶数的Text将添加到UIManager的对话栏，
             * 创建一个新选项并且显示Text文字，并且也绑定上变量，
             * 在点击的时候改变变量的数值，留作后面ifgoto判断*/
        }
    }

}

public class StartCommand : ScenarioCommand
{
    public StartCommand(string[] parameter)
    {
        type = ScenarioCommandType.startCommand;
        this.parameter = parameter;
        //start的parameter中，索引从0开始是Start所在的指令位置
    }

    public override void Run()
    {
        base.Run();
    }
}

public class EndCommand : ScenarioCommand
{
    public EndCommand(string[] parameter)
    {
        type = ScenarioCommandType.endCommand;
        this.parameter = parameter;
        //end的parameter中，索引从0开始是End所在的指令位置
    }

    public override void Run()
    {
        
    }
}