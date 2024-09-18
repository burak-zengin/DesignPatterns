﻿using DesignPatterns.Behavioral.Visitor.Visitors;

namespace DesignPatterns.Behavioral.Visitor.Components;

public class LabelComponent : IComponent
{
    public LabelComponent()
    {
        Components = [];
    }

    public List<IComponent> Components { get; set; }

    public void Execute(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}