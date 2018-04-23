using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace WpfApplication5 {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
    }
    public class ViewModel {
        public ObservableCollection<Item> Items { get; set; }
        public ViewModel() {
            Items = new ObservableCollection<Item>();
            for (int i = 0; i < 100; i++)
                Items.Add(new Item { ValueType = i % 3 == 0 ? ValueType.Decimal : ValueType.Number, Value = i });
        }
    }
    public class Item : INotifyPropertyChanged {
        ValueType _valueType;
        public ValueType ValueType {
            get {
                return _valueType;
            }
            set {
                _valueType = value;
                RaisePropertyChanged("ValueType");
            }
        }
        double _value;
        public double Value {
            get {
                return _value;
            }
            set {
                _value = value;
                RaisePropertyChanged("Value");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
    public enum ValueType { Decimal, Number }
}