using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using DevExpress.Xpf.Editors.Settings;

namespace WpfApplication5
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        BindingList<ContactItem> coll;
        public Window1()
        {
            InitializeComponent();
            coll = new BindingList<ContactItem>();
            ContactItem f1 = new ContactItem();
            f1.Name = OneTwo.One;
            f1.Salary = 13;
            f1.SalaryLimitation = 30;
            f1.IsFired = false;
            coll.Add(f1);
            f1 = new ContactItem();
            //f1.Name = OneTwo.One;
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);
            f1 = new ContactItem();
            f1.Name = OneTwo.One;
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);
            f1 = new ContactItem();
            f1.Name = OneTwo.Two;
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);
            f1 = new ContactItem();
            f1.Name = OneTwo.Two;
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);
            f1 = new ContactItem();
            f1.Name = OneTwo.Two;
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);

            f1 = new ContactItem();
            f1.Name = OneTwo.One;
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);
            f1 = new ContactItem();
            f1.Name = OneTwo.Two;
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);
            f1 = new ContactItem();
            f1.Name = OneTwo.One;
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);

            f1 = new ContactItem();
            f1.Name = OneTwo.One;
            f1.Salary = 23;
            f1.SalaryLimitation = 50;

            coll.Add(f1);


            grid.ItemsSource = coll;

        }
    }

    public class ContactItem
    {
        public OneTwo Name { get; set; }
        public int Salary { get; set; }
        public int SalaryLimitation { get; set; }
        public DateTime Date { get; set; }
        public bool IsFired { get; set; }
    }

    public enum OneTwo
    {
       One, Two
    }
}
