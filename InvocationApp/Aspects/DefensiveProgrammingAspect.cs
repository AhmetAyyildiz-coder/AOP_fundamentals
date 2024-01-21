using Castle.DynamicProxy;

namespace InvocationApp.Aspects;

// PROXY'ye vermek üzere yazılmış olan aspect 
public class DefensiveProgrammingAspect :IInterceptor
{
    public void Intercept(IInvocation invocation)
    {
        // metot içerisindeki argümanları almak için
        var parameters = invocation.Arguments;

        // amacımız gelen parametrelerin hiçbirinin null olmadığı bir senaryo
        foreach (var p in parameters)
        {
            if (p is null)
            {
                throw new ArgumentNullException();
            }

            Console.WriteLine($"Null check has been completed for {invocation.Method}");
        }
    }
}