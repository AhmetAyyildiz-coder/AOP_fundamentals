using Castle.DynamicProxy;

namespace Core.Interceptors;

/// <summary>
/// kendi custom method interception'umuz. Artık bir method'un tetiklenmesindeki lifetime'ı boyunca yönetimini sağlayabiliriz.
/// </summary>
public class MethodInterception : MethodInterceptionBaseAttribute
{
    
    public override void Intercept(IInvocation invocation)
    {
        bool succesFlag = true;
        OnBefore(invocation);

        try
        {
            invocation.Proceed();
        }
        catch (Exception e)
        {
            succesFlag = false;
            OnException(invocation, e);
            throw;
        }
        finally
        {
            if (succesFlag)
            {
                OnSuccess(invocation);
            }
        }
        OnAfter(invocation);
        base.Intercept(invocation);
    }

    public virtual void OnBefore(IInvocation invocation) { }

    public virtual void OnAfter(IInvocation invocation) { }
    public virtual void OnException(IInvocation invocation,Exception e) { }

    public virtual void OnSuccess(IInvocation invocation) { }


}