using System.Net;

namespace DiceDI.Types
{
    public class Dice
    {
        private readonly IRandomNumberGenerator generator;
        public int Value { get; set; }

        public Dice(IRandomNumberGenerator rnd)
        {
            generator = rnd;
            Roll();
        }

        public void Roll()
        {
            this.Value = generator.FindNumberForDice();
        }

        public string Print()
        {
            return $"[ {this.Value} ]";
        }
    }
}