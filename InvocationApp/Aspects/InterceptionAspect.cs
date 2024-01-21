using Castle.DynamicProxy;

namespace InvocationApp.Aspects;

public class InterceptionAspect : IInterceptor
{
    public void Intercept(IInvocation invocation)
    {
        Console.WriteLine("Before invocation");
        invocation.Proceed();
        Console.WriteLine("After invocation");
    }
}