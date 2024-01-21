

using Castle.DynamicProxy;
using Entities;
using InvocationApp.Aspects;

var proxy = new ProxyGenerator();
var aspect = proxy.CreateClassProxy<Employee>(new InterceptionAspect());

aspect.Add(1,"ahmet","ayyildiz");