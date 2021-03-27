using System.Windows;
using Practica6.ModelView;
using MahApps.Metro.Controls;

namespace Practica6.Views
{
    public partial class RolesView: MetroWindow
    {
        public RolesView()
        {
            InitializeComponent();
            RolesViewModel ModeloDatos = new RolesViewModel();
            this.DataContext = ModeloDatos;
        }
    }
}