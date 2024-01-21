

using Castle.DynamicProxy;
using Entities;
using InvocationApp.Aspects;

var proxy = new ProxyGenerator();

// bu şekilde birden fazla aspect ekleyebiliriz. 
var aspect = proxy.CreateClassProxy<Employee>(new InterceptionAspect(),new DefensiveProgrammingAspect());

aspect.Add(1,"ahmet","ayyildiz");


var Emp1 = new Employee();
Emp1.Id = 1;
Emp1.FirstName = "ahmet";

aspect.Update(1,"",null);