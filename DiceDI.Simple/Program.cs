using DiceDI.Types;

Console.WriteLine("---- Homemade ----");

IRandomNumberGenerator rndGenerator = new RandomNumberGeneratorFramework();
//IRandomNumberGenerator rndGenerator = new RandomNumberGeneratorMock();
//IRandomNumberGenerator rndGenerator = new RandomNumberGeneratorRandomOrg();

Dice dice = new(rndGenerator);
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(dice.Print());
    dice.Roll();
}

