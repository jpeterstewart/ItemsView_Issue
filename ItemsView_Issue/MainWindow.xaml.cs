using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ItemsView_Issue
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        enum ListSelector { Left, Right }
        internal static ObservableCollection<SimpleItemData> LeftList = [];
        internal static ObservableCollection<SimpleItemData> RightList = [];

        public MainWindow()
        {
            this.InitializeComponent();
            LeftSide.ItemsSource = LeftList;
            RightSide.ItemsSource = RightList;
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs _)
        {
            if (sender is MenuFlyoutItem m)
            {
                switch (m.Name)
                {
                    case "CloseApp":
                        this.Close();
                        break;
                }
            }
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs _)
        {
            if (sender is Button b2)
            {
                switch (b2.Name)
                {
                    case "Exit":
                        this.Close();
                        break;
                    case "Increment1_100":
                        AddToList(ListSelector.Left);
                        break;
                    case "Increment1_1000":
                        AddToList(ListSelector.Left, 1000);
                        break;
                    case "Increment1_10000":
                        AddToList(ListSelector.Left, 10000);
                        break;
                    case "Increment1_100000":
                        AddToList(ListSelector.Left, 100000);
                        break;
                    case "Increment2_100":
                        AddToList(ListSelector.Right);
                        break;
                    case "Increment2_1000":
                        AddToList(ListSelector.Right, 1000);
                        break;
                    case "Increment2_10000":
                        AddToList(ListSelector.Right, 10000);
                        break;
                    case "Increment2_100000":
                        AddToList(ListSelector.Right, 100000);
                        break;
                }
            }
        }

        private void AddToList(ListSelector selectedList, int size = 100)
        {

            if (selectedList == ListSelector.Left)
            {
                AddItems(ref LeftList, size);
                LeftBar.Text = string.Format("IntemsView ({0} items)", LeftList.Count);
            }
            else // if (whichList == ListSelector.Right)
            {
                AddItems(ref RightList, size);
                RightBar.Text = string.Format("ListView ({0} items)", RightList.Count);
            }
        }

        private static void AddItems(ref ObservableCollection<SimpleItemData> theList, int newItems)
        {
            int count = theList.Count;
            for (int i = 1; i <= newItems; i++)
            {
                SimpleItemData item = new SimpleItemData(string.Format("This is item number{0} ", StringFill('_', 100)), count + i);
                theList.Add(item);
            }
        }

        private static string StringFill(char c, int len)
        {
            return new string(c, len);
        }
    }
}
