using Castle.DynamicProxy;
using Core.Interceptors;

namespace Core.Aspect;

// PROXY'ye vermek üzere yazılmış olan aspect 
public class DefensiveProgrammingAspect :MethodInterception
{
    //public void Intercept(IInvocation invocation)
    //{
    //    // metot içerisindeki argümanları almak için
    //    var parameters = invocation.Arguments;

    //    // amacımız gelen parametrelerin hiçbirinin null olmadığı bir senaryo
    //    foreach (var p in parameters)
    //    {
    //        if (p is null)
    //        {
    //            throw new ArgumentNullException();
    //        }

    //        Console.WriteLine($"Null check has been completed for {invocation.Method}");
    //    }
    //}
    public override void OnBefore(IInvocation invocation)
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