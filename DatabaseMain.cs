using System;

namespace ��������_������
{
    partial class DatabaseMain
    {
    }

    partial class Groups
    {
        public override string ToString()
        {
            return this.Name;
        }   
    }

    partial class Teachers
    {
        public override string ToString()
        {
            return this.Fio;
        }
    }

    partial class Children
    {
        public override string ToString()
        {
            return this.FioChildren;
        }
    }

    partial class Schedule
    {

        public string formatdata
        {
            get
            {
                return String.Format($"����: {ClassDateTime.ToLongDateString()} �����:{ClassDateTime.ToShortTimeString()} ");
            }
            private set { }
        }
    }
}