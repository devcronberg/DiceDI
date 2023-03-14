namespace DiceDI.Types
{
    public class RandomNumberGeneratorRandomOrg : IRandomNumberGenerator
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<int> FindNumberForDiceAsync()
        {
            string url = "https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();
            return int.Parse(result.Trim());
        }

        public int FindNumberForDice()
        {
            // Might be a bad idea (possible deadlocks)
            // Maybe create a async method in the interface for the next version
            // Could use the sync WebClient instead (but thats obsolete) or
            // change the whole app to an async version
            return FindNumberForDiceAsync().GetAwaiter().GetResult();
        }
    }
}