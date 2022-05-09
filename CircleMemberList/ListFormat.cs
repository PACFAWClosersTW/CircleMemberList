using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel; //INotifyPropertyChanged

namespace CircleMemberList
{
    class ListFormat : INotifyPropertyChanged //通知接口
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int Number_;
        private string Name_;
        private string Hierarchy_;
        private string Date_;

        public int Number
        {
            get { return Number_; }
            set
            {
                Number_ = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Number"));
            }
        }

        public string Name
        {
            get { return Name_; }
            set
            {
                Name_ = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public string Hierarchy
        {
            get { return Hierarchy_; }
            set
            {
                Hierarchy_ = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hierarchy"));
            }
        }

        public string Date
        {
            get { return Date_; }
            set
            {
                Date_ = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Date"));
            }
        }

        public ListFormat(int Number, string Name, string Hierarchy, string Date)
        {
            Number_ = Number;
            Name_ = Name;
            Hierarchy_ = Hierarchy;
            Date_ = Date;
        }
    }
}
