using WiredBrainCoffee.DataProcessor.Model;

namespace WiredBrainCoffee.DataProcessor.Data
{
    public class ConsoleCoffeeCountStore : ICoffeeCountStore
    {
        private TextWriter _textWriter;

        // This default constructor passes Console.Out as the TextWriter
        public ConsoleCoffeeCountStore() : this(Console.Out)
        {
            
        }

        // This allows a different TextWriter to be injected (for example, for testing purposes)
        public ConsoleCoffeeCountStore(TextWriter textWriter)
        {
            _textWriter = textWriter;
        }

        public void Save(CoffeeCountItem item)
        {
            var line = $"{item.CoffeeType}:{item.Count}";
            _textWriter.WriteLine(line);
        }
    }
}
