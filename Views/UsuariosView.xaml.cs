using System.Windows;
using Practica6.ModelView;

namespace Practica6.Views
{
    public partial class UsuariosView: Window
    {
        public UsuariosView()
        {
            InitializeComponent();
            UsuariosViewModel ModeloDatos = new UsuariosViewModel();
            this.DataContext = ModeloDatos;
        }
    }
}