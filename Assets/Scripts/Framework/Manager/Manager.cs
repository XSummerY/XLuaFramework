﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private static ResourceManager _resource;
    public static ResourceManager Resource
    {
        get
        {
            return _resource;
        }
    }

    private static LuaManager _lua;
    public static LuaManager Lua
    {
        get
        {
            return _lua;
        }
    }

    private void Awake()
    {
        _resource = gameObject.AddComponent<ResourceManager>();
        _lua = gameObject.AddComponent<LuaManager>(); 
    }
}
