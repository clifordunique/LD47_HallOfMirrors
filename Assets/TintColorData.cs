﻿using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;

[MaterialProperty("_TintColor", MaterialPropertyFormat.Float4),GenerateAuthoringComponent]
public struct TintColorData : IComponentData
{
    public float4 Value;
}