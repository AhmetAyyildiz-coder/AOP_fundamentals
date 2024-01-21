using Castle.DynamicProxy;
using Core.Interceptors;

namespace Core.Aspect;

public class InterceptionAspect : MethodInterception
{
    public override void OnBefore(IInvocation invocation)
    {
        Console.WriteLine("Before invocation");
        //invocation.Proceed();
        //
    }

    public override void OnAfter(IInvocation invocation)
    {
        Console.WriteLine("After invocation");
    }
}