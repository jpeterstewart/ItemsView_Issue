using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;

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
                    case "Populate1_100":
                        PopulateList(ListSelector.Left);
                        break;
                    case "Populate1_1000":
                        PopulateList(ListSelector.Left, 1000);
                        break;
                    case "Populate1_10000":
                        PopulateList(ListSelector.Left, 10000);
                        break;
                    case "Populate1_100000":
                        PopulateList(ListSelector.Left, 100000);
                        break;
                    case "Populate2_100":
                        PopulateList(ListSelector.Right);
                        break;
                    case "Populate2_1000":
                        PopulateList(ListSelector.Right, 1000);
                        break;
                    case "Populate2_10000":
                        PopulateList(ListSelector.Right, 10000);
                        break;
                    case "Populate2_100000":
                        PopulateList(ListSelector.Right, 100000);
                        break;
                }
            }
        }

        private static void PopulateList(ListSelector selectedList, int size = 100)
        {

            if (selectedList == ListSelector.Left)
            {
                LeftList.Clear();
                FillList(ref LeftList, size);
            }
            else // if (whichList == ListSelector.Right)
            {
                RightList.Clear();
                FillList(ref RightList, size);
            }
        }

        private static void FillList(ref ObservableCollection<SimpleItemData> theList, int listSize)
        {
            for (int i = 1; i <= listSize; i++)
            {
                SimpleItemData item = new SimpleItemData("This is item number...................................................", i);
                theList.Add(item);
            }
        }

        // TODO: add +1000 function


    }
}
