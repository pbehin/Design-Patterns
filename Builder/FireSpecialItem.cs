namespace Builder
{
    public class FireSpecialItem
    {
        public FireSpecialItem(string itemName)
        {
            ItemName = itemName;
        }

        public override string ToString()
        {
            return ItemName;
        }

        private string ItemName { get; }
    }
}