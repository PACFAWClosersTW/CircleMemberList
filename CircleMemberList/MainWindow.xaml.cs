using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;


namespace CircleMemberList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<ListFormat> MemberList = new List<ListFormat>();
        private int member_no_;
        private string member_name_;
        private string member_hierarchy_;
        private string member_date_;

        public MainWindow()
        {
            InitializeComponent();
            CircleMemberList.ItemsSource = MemberList;
            HierarchyComboBox.Items.Add("團長");
            HierarchyComboBox.Items.Add("副團長");
            HierarchyComboBox.Items.Add("管理");
            HierarchyComboBox.Items.Add("普通");
            HierarchyComboBox.Items.Add("新人");
            HierarchyComboBox.Items.Add("------");
        }

        private void Add_btn(object sender, RoutedEventArgs e)
        {
            if (NameText.Text == "" | (string)HierarchyComboBox.SelectedItem == "" | DateText.Text == "")
            {
                MessageBox.Show("Please Input Member Info.");
            }
            else
            {
                member_name_ = NameText.Text;
                member_hierarchy_ = (string)HierarchyComboBox.SelectedItem;
                member_date_ = DateText.Text;
                if (CircleMemberList.SelectedItems.Count == 1)
                {
                    ListFormat MemberInsert = (ListFormat)CircleMemberList.SelectedItem;
                    MemberList.Insert(MemberInsert.Number, new ListFormat(MemberInsert.Number + 1, member_name_, member_hierarchy_, member_date_));
                    MemberListNumber_Update();
                }
                else
                {
                    member_no_ = MemberList.Count + 1;
                    MemberList.Add(new ListFormat(member_no_, member_name_, member_hierarchy_, member_date_));
                }
                MemberList_Update();
                NameText.Text = null;
                DateText.Text = null;
            }
        }

        private void Remove_btn(object sender, RoutedEventArgs e)
        {
            if (CircleMemberList.SelectedItems.Count == 1)
            {
                ListFormat MemberRemove = (ListFormat)CircleMemberList.SelectedItem;
                MemberList.Remove(MemberRemove);
            }
            else if (CircleMemberList.SelectedItems.Count > 1)
            {
                for (int i = 0; i < CircleMemberList.SelectedItems.Count; i++)
                {
                    ListFormat MemberRemove = (ListFormat)CircleMemberList.SelectedItems[i];
                    MemberList.Remove(MemberRemove);
                }
            }
            MemberListNumber_Update();
            MemberList_Update();
        }

        private void MoveUp_btn(object sender, RoutedEventArgs e)
        {
            if (CircleMemberList.SelectedItems.Count == 1)
            {
                try
                {
                    ListFormat MemberInfoUp = (ListFormat)CircleMemberList.SelectedItem;
                    MemberList[MemberInfoUp.Number - 1] = MemberList[MemberInfoUp.Number - 2];
                    MemberList[MemberInfoUp.Number - 2] = MemberInfoUp;
                    MemberListNumber_Update();
                    MemberList_Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't able move up because SelectedItem position is 1.");
                }
            }
        }

        private void MoveDown_btn(object sender, RoutedEventArgs e)
        {
            if (CircleMemberList.SelectedItems.Count == 1)
            {
                ListFormat MemberInfoDown = (ListFormat)CircleMemberList.SelectedItem;
                MemberList[MemberInfoDown.Number - 1] = MemberList[MemberInfoDown.Number];
                MemberList[MemberInfoDown.Number] = MemberInfoDown;
                MemberListNumber_Update();
                MemberList_Update();
            }
        }

        private void ReadTxt_btn(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ReadTxtFile = new OpenFileDialog();
            ReadTxtFile.Title = "Select a file to open";
            ReadTxtFile.RestoreDirectory = true;
            ReadTxtFile.DefaultExt = "txt";
            ReadTxtFile.CheckPathExists = true;
            ReadTxtFile.CheckFileExists = true;
            ReadTxtFile.Filter = "Member List Info|*.txt";
            ReadTxtFile.Multiselect = false;
            if (ReadTxtFile.ShowDialog() == true)
            {
                MemberList.Clear();
                string[] file_text = File.ReadAllLines(ReadTxtFile.FileName.ToString());
                string[] data_col = null;
                foreach (string text_line in file_text)
                {
                    data_col = text_line.Split(',');
                    MemberList.Add(new ListFormat(Convert.ToInt32(data_col[0]), data_col[1], data_col[2], data_col[3]));
                }
                MemberListNumber_Update();
                MemberList_Update();
            }
        }

        private void OutputTxt_btn(object sender, RoutedEventArgs e)
        {
            SaveFileDialog SaveMemberList = new SaveFileDialog();
            SaveMemberList.Filter = "Text files(*.txt)|*.txt";
            if (SaveMemberList.ShowDialog() == true)
            {
                TextWriter sw = new StreamWriter(SaveMemberList.FileName.ToString());

                for (int i = 0; i < MemberList.Count; i++)
                {
                    sw.Write(MemberList[i].Number.ToString() + "," + MemberList[i].Name + "," + MemberList[i].Hierarchy + "," + MemberList[i].Date);
                    sw.WriteLine("");
                }
                sw.Close();
            }
        }

        void MemberListNumber_Update()
        {
            for (int i = 0; i < MemberList.Count; i++)
            {
                if (MemberList[i].Number != i + 1)
                {
                    MemberList[i].Number = i + 1;
                }
            }
        }

        void MemberList_Update()
        {
            CircleMemberList.ItemsSource = null;
            CircleMemberList.ItemsSource = MemberList;
        }

        private void CircleMemberList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
