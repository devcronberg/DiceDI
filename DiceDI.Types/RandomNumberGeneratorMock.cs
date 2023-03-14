namespace DiceDI.Types
{
    public class RandomNumberGeneratorMock : IRandomNumberGenerator
    {
        private readonly int value;

        public int FindNumberForDice()
        {
            return value;
        }

        public RandomNumberGeneratorMock(int value = 6)
        {
            this.value = value;
        }
    }
}