﻿using Castle.DynamicProxy;
using System;
using System.Linq;
using System.Reflection;

namespace Core.Utilities.Interceptors
{
    public abstract partial class MethodInterception
    {
        public class AspectInterceptorSelector : IInterceptorSelector
        {
            public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
            {
                var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                    (true).ToList();
                var methodAttributes = type.GetMethod(method.Name)
                    .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
                classAttributes.AddRange(methodAttributes);

                //herhangibi metod, fonksyon loglandı mı diye düşüdürmeden loglama işini halleder. -altyapısı eksik
                //classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger)));

                return classAttributes.OrderBy(x => x.Priority).ToArray();
            }
        }
    } 
}
