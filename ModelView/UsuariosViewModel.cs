using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using Practica6.Models;
using Practica6.Views;

namespace Practica6.ModelView
{
    public class UsuariosViewModel : INotifyPropertyChanged, ICommand
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;
        public ObservableCollection<Usuarios> usuarios { get; set; }
        //CREAMOS NUESTRA COLECCION O LISTA DE ELEMENTOS

        public UsuariosViewModel Instancia { get; set; }

        public Usuarios Seleccionado { get; set; }

        public UsuariosViewModel()
        {
            this.Instancia = this;

            this.usuarios = new ObservableCollection<Usuarios>();

            this.usuarios.Add(new Usuarios(1, "Donny", true, "Adonias", "Tobar", "dony21.587@gmail.com", "1234"));
            this.usuarios.Add(new Usuarios(2, "DNY", true, "Esdras", "Jimenez", "esdrasjimenezaft@gmail.com", "1234"));
            this.usuarios.Add(new Usuarios(3, "Glad", true, "Gladys", "Rosales", "siomalararosales@hotmail.es", "1234"));
            this.usuarios.Add(new Usuarios(4, "Chucky", true, "Deivy", "Gurrion", "deivygurrion@gmail.com", "1234"));
        }
        //MATODO PARA NOTIFICAR CAMBIOS
        public void NotificarCambio(string propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }
        //METODO PARA AGREGAR UN ELEMENTO DE LA COLECCION
        public void agregarElemento(Usuarios nuevo)
        {
            this.usuarios.Add(nuevo);
        }

        public bool CanExecute(object parametro)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            //CARGAMOS EL NUEVO ELEMENTO A LA COLECCION
            if (parametro.Equals("Nuevo"))
            {
                this.Seleccionado = null;
                NUsuariosView nuevoUsuario = new NUsuariosView(Instancia);
                nuevoUsuario.Show();
            }
            //CONDICION PARA ELIMINAR UN ELEMENTO DE LA COLECCION
            else if (parametro.Equals("Eliminar"))
            {
                if (this.Seleccionado == null)
                {
                    MessageBox.Show("Debe seleccionar un elemento");
                }
                this.usuarios.Remove(Seleccionado);
            }
            //CONDICION PARA MODIFICAR UN ELEMENTO DE LA COLECCION
            else if (parametro.Equals("Modificar"))
            {
                if (this.Seleccionado == null)
                {
                    MessageBox.Show("Debe seleccionar un elemento");
                }
                else
                {
                    NUsuariosView modificarUsuario = new NUsuariosView(Instancia);
                    modificarUsuario.ShowDialog();
                }
            }
        }
    }
}