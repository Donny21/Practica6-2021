using System.Windows;
using Practica6.ModelView;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace Practica6.Views
{
    public partial class NUsuariosView: MetroWindow
    {
        public NUsuariosView(UsuariosViewModel NUsuariosViewModel)
        {
            InitializeComponent();
            NUsuariosViewModel Modelo = new NUsuariosViewModel(NUsuariosViewModel, DialogCoordinator.Instance);
            this.DataContext = Modelo;
        }
    }
}