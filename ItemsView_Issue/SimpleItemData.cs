
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

        internal string ItemNameAndNumber { get { return itemname + itemnumber.ToString(); } }
    }
}
