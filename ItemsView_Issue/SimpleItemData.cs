
namespace ItemsView_Issue
{
    internal class SimpleItemData
    {
        private readonly string itemname;
        private readonly long itemnumber;

        internal SimpleItemData(string name, long number)
        {
            itemname = name;
            itemnumber = number;
        }

        private SimpleItemData()
        {
        }

        internal string ItemNameAndNumner { get { return itemname + itemnumber.ToString(); } }
        internal string ItemName { get { return itemname + itemnumber.ToString(); } }
        internal string ItemNumber { get { return itemnumber.ToString(); } }
    }
}
