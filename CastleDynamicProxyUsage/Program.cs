/*
 *En temel düzeyde Castle dynamic proxy tanımı
 *
 * Runtime'da proxy tanımlaya yarayan bir teknolojidir.
 * Hafif proxy'ler oluşturmaya yarar. Nesnenin kodunu değiştirmeden üyelerine erişmemizi ve kontrolleri yapabilmemizi sağlar.
 * Bu sayede aop'yi kullanabilmemizi sağlar.
 *
 * Intercaptions'lar virtual'ların içerisine girebilir sadece.
 * Bu konu önemli. VİRTUAL mutlaka kullanılmalı.
 *
 * Bu projede en yalın hali ile bir aspect yapacağız.
 *
 *
 * Runtime'da bir proxy oluşturmak ? 
 */

using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using CastleDynamicProxyUsage;
using Core.Interceptors;


// söz konusu sınıf için bir araya girici - aspect - sınıfı eklemiş oluyoruz. En temel anlamda.
//var proxy = new ProxyGenerator();
//var aspect = proxy.CreateClassProxy<MyClass>(new MyInterceptorAspect());
//aspect.MyMethod();




// IOC container register 
// aslında somut bir sınıfı soyut sınıf ile işaretleyip proxy çalışmasını soyut sınıfta yapabilme yeteneği kazandırmak amaç
var builder = new ContainerBuilder();
builder.RegisterType<MyClass>().As<IMyClass>()
    .EnableInterfaceInterceptors(new ProxyGenerationOptions()
    {
        Selector = new AspectInterceptorSelector()
    })
    .InstancePerDependency() ; // her bağımlığa karşılık bir örnek


var container =builder.Build();

// EnableInterfaceInterceptors için Autofac.Extras.DynamicProxy kütüphanesini kullanmalıyız. 

/*
 * Bu method çözülmenin dinamik hale gelmesine yarayacaktır. 
 */

var willBeIntercepted = container.Resolve<IMyClass>();
// bu şekilde kullanarak somut sınıfdan bağımsız soyut sınıf kullanarak bu metot üzerine yazılmış aspect varsa bunlara ulaşabiliriz.
willBeIntercepted.MyMethod();