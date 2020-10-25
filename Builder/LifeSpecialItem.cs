namespace Builder
{
    internal class LifeSpecialItem
    {
        public LifeSpecialItem(string itemName)
        {
            ItemName = itemName;
        }

        public override string ToString()
        {
            return ItemName;
        }

        public string ItemName { get; }
    }
}