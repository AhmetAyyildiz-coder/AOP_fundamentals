using System.Reflection;
using Castle.DynamicProxy;
using Core.Interceptors;

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
//public class MyInterceptorAspect : IInterceptor
//{
//    // invocation.Method ile method adini alabiliyoruz. Dynamic şekilde. Mükemmel :)
//    public void Intercept(IInvocation invocation)
//    {
//        Console.WriteLine($"Before method {invocation.Method}");
//        // araya girdiğimiz metodu devam ettirmek istediğimiz için bu şekilde devam ederç
//        invocation.Proceed();
//        Console.WriteLine($"After method {invocation.Method}");

//    }
//}


// V2 olarak guncellersek 
public class MyInterceptorAspect : MethodInterception
{
    // burada   invocation.Proceed(); kullanmaya gerek kalmadı. Çünkü MethodInterception zaten default olarak yapıyor bu işlemi.

    public override void OnBefore(IInvocation invocation)
    {
        Console.WriteLine($"Before method {invocation.Method}");
    }

    public override void OnAfter(IInvocation invocation)
    {
        Console.WriteLine($"After method {invocation.Method}");
    }
}