
namespace Esuriru.Items
{
    /// <summary>
    /// Instanced class that attaches a count onto an ItemBase
    /// </summary>
    public class ItemInstance
    {
        /// <summary>
        /// ItemInstance constructor 
        /// </summary>
        /// <param name="item">Item</param>
        /// <param name="count">Amount</param>
        public ItemInstance(ItemBase item, int count)
        {
            Item = item;
            Count = count;
        }

        public ItemBase Item { get; private set; }
        public int Count { get; private set; }
    } 
}
