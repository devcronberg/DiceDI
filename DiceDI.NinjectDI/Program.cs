using Ninject;
using DiceDI.Types;

Console.WriteLine("---- Ninject ----");

var kernel = new StandardKernel();
kernel.Bind<Dice>().ToSelf().InSingletonScope();
kernel.Bind<IRandomNumberGenerator>().To<RandomNumberGeneratorFramework>().InSingletonScope();
//kernel.Bind<IRandomNumberGenerator>().To<RandomNumberGeneratorMock>().InSingletonScope();
//kernel.Bind<IRandomNumberGenerator>().To<RandomNumberGeneratorRandomOrg>().InSingletonScope();

var dice = kernel.Get<Dice>();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(dice.Print());
    dice.Roll();
}