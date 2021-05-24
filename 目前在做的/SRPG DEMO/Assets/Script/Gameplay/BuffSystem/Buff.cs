﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum BuffDurationType
{
    always,
    limit
}
public class Buff
{
    public int id;
    public BuffDurationType durationType;
    public int maxDurationTimes;
    public int curDurationTimes;
    public short maxOverlayTimes;
    public int curOverlayTimes;
    public List<string> tags;
    protected List<BuffEffect> m_buffEffects; 

    public List<BuffEffect> buffEffects
    {
        get { return m_buffEffects; }
    }
    
    
    public virtual void OnBuffAdd(SrpgClassUnit unit)
    {
        //BUFF可能在添加的时候会改变一些表现，比如护盾，狂暴。
    }

    public virtual void OnBuffRemove(SrpgClassUnit unit)
    {
        //BUFF可能在移除的时候会改变一些表现
    }
}
