namespace ProxyApp;

public interface IBuisnessModude
{
    void Method();

}


public class BuisnessModule : IBuisnessModude
{
    public void Method()
    {
        Console.WriteLine("Method 1");
    }
}


// bu proxy sınıfı aslında metot çağırımında araya girmek gibi düşünülebilir.
// en temel düzeyde kullanımı bu şekildedir. Şuan metot içerisindeki değişmelerden proxy etkilenmez.
// ama metodu çağırmak için de direkt buisnessmodule sınıfı değil de proxy sınıfı kullanılacak program cs tarafındas
public class BuisnessModuleProxy : IBuisnessModude
{
    private BuisnessModule module = new();
    public void Method()
    {
        Console.WriteLine("Fonksiyon çağırıldı");
        module.Method();
        Console.WriteLine("Fonksiyon bitti");
    }
}