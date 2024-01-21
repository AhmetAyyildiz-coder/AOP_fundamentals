using Castle.DynamicProxy;

namespace InvocationApp.Aspects;

public class DefensiveProgrammingAspect :IInterceptor
{
    public void Intercept(IInvocation invocation)
    {
        // metot içerisindeki argümanları almak için
        var parameters = invocation.Arguments;
    }
}