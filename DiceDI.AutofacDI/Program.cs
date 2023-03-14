using Autofac;
using DiceDI.Types;

Console.WriteLine("---- Autofac ----");

var builder = new ContainerBuilder();
builder.RegisterType<RandomNumberGeneratorFramework>().As<IRandomNumberGenerator>().SingleInstance();
//builder.RegisterType<RandomNumberGeneratorMock>().As<IRandomNumberGenerator>().SingleInstance();
//builder.RegisterType<RandomNumberGeneratorRandomOrg>().As<IRandomNumberGenerator>().SingleInstance();

builder.RegisterType<Dice>().SingleInstance();
var container = builder.Build();

var dice = container.Resolve<Dice>();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(dice.Print());
    dice.Roll();
}

//Console.ReadLine();