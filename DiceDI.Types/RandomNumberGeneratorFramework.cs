namespace DiceDI.Types
{
    public class RandomNumberGeneratorFramework : IRandomNumberGenerator
    {
        private static System.Random rnd = new System.Random();

        public int FindNumberForDice()
        {
            return rnd.Next(1, 7);
        }
    }
}