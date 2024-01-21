using System.Reflection;
using Castle.DynamicProxy;

namespace Core.Interceptors;

public class AspectInterceptorSelector
:IInterceptorSelector{
    public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
    {
        // temel amaç class'ların attribute'larını oluşturmak olacaktır.
        var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>(true)
            .ToList();

        var methodAttributes = type.GetMethod(method.Name)?
            .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);


        if (methodAttributes != null)
        {
            classAttributes.AddRange(methodAttributes);
        }

        List<MethodInterceptionBaseAttribute> list = [];
        foreach (var attribute in classAttributes.OrderBy(x => x.Priority)) list.Add(attribute);
        return list
            .ToArray();
    }
}