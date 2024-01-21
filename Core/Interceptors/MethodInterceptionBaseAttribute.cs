using Castle.DynamicProxy;

namespace Core.Interceptors;


/*
 * Bundan sonra bir aspect yazmak istediğimde bir base olarak bu sınıfı kullanabiliriz.
 */


[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Assembly)]
public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
{
    // interceptor özelliğinin çalışabilmesi için mutlaka virtual özelliği verilmeli !!!


    /// <summary>
    /// Çalışma önceliği ,
    ///  Eğer birden fazla attribute tanımlanırsa öncelik vermek için. 
    /// </summary>
    public int Priority { get; set; }

    public virtual void Intercept(IInvocation invocation)
    {
    }
}