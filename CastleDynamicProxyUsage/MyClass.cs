using System.Reflection;
using Castle.DynamicProxy;

namespace CastleDynamicProxyUsage;


public class MyClass
{
    // Böyle tanım olursa interception - dynamic proxy kullanarak araya giremez. 
    //public void MyMethod()
    //{

    //}


    // araya girme - aspect - için mutlaka virtual olmalıdır. 

    public virtual void MyMethod()
    {
        Console.WriteLine("My method body");
    }
}



// eğer bu sınıfın bir interceptor olmasını istiyorsak mutlaka bu interface'den kalıtım alınmalı
public class MyInterceptorAspect : IInterceptor
{
    // invocation.Method ile method adini alabiliyoruz. Dynamic şekilde. Mükemmel :)
    public void Intercept(IInvocation invocation)
    {
        Console.WriteLine($"Before method {invocation.Method}");
        // araya girdiğimiz metodu devam ettirmek istediğimiz için bu şekilde devam ederç
        invocation.Proceed();
        Console.WriteLine($"After method {invocation.Method}");

    }
}