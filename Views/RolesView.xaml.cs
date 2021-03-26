using System.Windows;
using Practica6.ModelView;

namespace Practica6.Views
{
    public partial class RolesView: Window
    {
        public RolesView()
        {
            InitializeComponent();
            RolesViewModel ModeloDatos = new RolesViewModel();
            this.DataContext = ModeloDatos;
        }
    }
}