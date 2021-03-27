using System.Windows;
using Practica6.ModelView;

namespace Practica6.Views
{
    public partial class NUsuariosView: Window
    {
        public NUsuariosView(UsuariosViewModel NUsuariosViewModel)
        {
            InitializeComponent();
            NUsuariosViewModel Modelo = new NUsuariosViewModel(NUsuariosViewModel);
            this.DataContext = Modelo;
        }
    }
}