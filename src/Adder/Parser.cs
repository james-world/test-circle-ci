namespace Adder
{
    public class Parser
    {
        public (int, int) Parse(string[] input) => (int.Parse(input[0]), int.Parse(input[1]));
    }
}