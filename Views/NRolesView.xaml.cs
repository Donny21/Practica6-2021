using System.Windows;
using Practica6.ModelView;
using MahApps.Metro.Controls;

namespace Practica6.Views
{
    public partial class NRolesView: MetroWindow
    {
        public NRolesView(RolesViewModel NRolesView)
        {
            InitializeComponent();
            NRolesViewModel Modelo = new NRolesViewModel(NRolesView);
            this.DataContext = Modelo;
        }
    }
}