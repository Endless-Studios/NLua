﻿using System;

namespace AOT.Fake
{
    [AttributeUsage(AttributeTargets.Method)]
    public class MonoPInvokeCallbackAttribute : Attribute
    {
        public MonoPInvokeCallbackAttribute(Type type)
        {
            
        }
    }
}
