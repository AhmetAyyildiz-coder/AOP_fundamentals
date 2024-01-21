using Autofac;
using Entities;
using InvocationApp;

// autofac ioc container register 
var builder = new ContainerBuilder();
builder.RegisterModule(new BaseModule());



// autofac ioc build
var container = builder.Build();


// autofac solve 
// IEmploye ifadesini çöz. İçerisinde aspect varsa kullan diyoruz aslında. 
/*
 * [DefensiveProgrammingAspect]
   [InterceptionAspect]  
bu 2 aspect de kullanılacak bu durumda.
 */
var willBeIntercepted = container.Resolve<IEmployee>();



var Emp1 = new Employee();
Emp1.Id = 1;
Emp1.FirstName = "ahmet";
Emp1.LastName = "ayyildiz";


Emp1.Update(Emp1.Id,Emp1.FirstName,Emp1.LastName);
willBeIntercepted.Add(Emp1.Id, Emp1.FirstName, Emp1.LastName);