namespace Aoc2021Net
{
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class GridSymbolAttribute : Attribute
    {
        public GridSymbolAttribute(char symbol) => Symbol = symbol;

        public char Symbol { get; }
    }
}
