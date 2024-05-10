using System;

namespace AOT.Fake
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class MonoPInvokeCallbackAttribute : Attribute
    {
        public MonoPInvokeCallbackAttribute(Type type)
        {
        }
    }
}
