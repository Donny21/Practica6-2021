using System.Windows;
using Practica6.ModelView;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace Practica6.Views
{
    public partial class UsuariosView: MetroWindow
    {
        public UsuariosView()
        {
            InitializeComponent();
            UsuariosViewModel ModeloDatos = new UsuariosViewModel(DialogCoordinator.Instance);
            this.DataContext = ModeloDatos;
        }
    }
}