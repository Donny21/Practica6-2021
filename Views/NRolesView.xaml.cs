using System.Windows;
using Practica6.ModelView;

namespace Practica6.Views
{
    public partial class NRolesView: Window
    {
        public NRolesView(RolesViewModel NRolesView)
        {
            InitializeComponent();
            NRolesViewModel Modelo = new NRolesViewModel(NRolesView);
            this.DataContext = Modelo;
        }
    }
}