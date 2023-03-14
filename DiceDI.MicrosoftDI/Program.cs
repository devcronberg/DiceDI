using DiceDI.Types;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("---- Microsoft ----");

var services = new ServiceCollection();
services.AddSingleton<Dice>();
services.AddSingleton<IRandomNumberGenerator, RandomNumberGeneratorFramework>();
//services.AddSingleton<IRandomNumberGenerator, RandomNumberGeneratorMock>();
//services.AddSingleton<IRandomNumberGenerator, RandomNumberGeneratorRandomOrg>();

var serviceProvider = services.BuildServiceProvider();

Dice? dice = serviceProvider.GetService<Dice>();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(dice?.Print());
    dice?.Roll();
}