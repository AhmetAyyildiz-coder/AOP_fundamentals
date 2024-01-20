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

using Castle.DynamicProxy;
using CastleDynamicProxyUsage;


// söz konusu sınıf için bir araya girici - aspect - sınıfı eklemiş oluyoruz. En temel anlamda.
var proxy = new ProxyGenerator();
var aspect = proxy.CreateClassProxy<MyClass>(new MyInterceptorAspect());

aspect.MyMethod();