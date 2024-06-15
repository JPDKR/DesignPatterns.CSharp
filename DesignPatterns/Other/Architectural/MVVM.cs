using System.ComponentModel;

namespace DesignPatterns.CSharp.Other.Architectural.MVVM
{
    // Este patrón se utiliza principalmente en aplicaciones WPF, separando la UI (View) de la lógica de negocio (ViewModel).

    // Model
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }

    // ViewModel
    public class ProductViewModel : INotifyPropertyChanged
    {
        private Product _product;

        public ProductViewModel(Product product) => _product = product;

        public string Name
        {
            get { return _product.Name; }
            set
            {
                if (_product.Name != value)
                {
                    _product.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public decimal Price
        {
            get { return _product.Price; }
            set
            {
                if (_product.Price != value)
                {
                    _product.Price = value;
                    OnPropertyChanged(nameof(Price));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    // View (XAML example, usually in a WPF application)
    // <Window x:Class="MVVMExample.MainWindow" ... >
    // <Grid>
    //     <TextBox Text="{Binding Name, UpdateSourceTrigger=PropertyChanged}" />
    //     <TextBox Text="{Binding Price, UpdateSourceTrigger=PropertyChanged}" />
    // </Grid>
    // </Window>

}
