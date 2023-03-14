namespace DiceDI.Types
{
    public class RandomNumberGeneratorRandomOrg : IRandomNumberGenerator
    {
        private static readonly HttpClient client = new();

        public int FindNumberForDice()
        {
            // Hmmm - bad idea to use HttpClient in a sync application!
            string url = "https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new";
            HttpResponseMessage response = client.GetAsync(url).ConfigureAwait(false).GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();
            string result = response.Content.ReadAsStringAsync().ConfigureAwait(false).GetAwaiter().GetResult();
            return int.Parse(result.Trim());
        }
    }
}