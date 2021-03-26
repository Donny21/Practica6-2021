using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Practica6.Models;

namespace Practica6.ModelView
{
    public class UsuariosViewModel : INotifyPropertyChanged, ICommand
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;
        public ObservableCollection<Usuarios> usuarios{get;set;}
        //CREAMOS NUESTRA COLECCION O LISTA DE ELEMENTOS

        public UsuariosViewModel()
        {
            this.usuarios = new ObservableCollection<Usuarios>();

            this.usuarios.Add(new Usuarios(1, "Donny", true, "Adonias", "Tobar", "dony21.587@gmail.com", "1234"));
            this.usuarios.Add(new Usuarios(1, "DNY", true, "Esdras", "Jimenez", "esdrasjimenezaft@gmail.com", "1234"));
            this.usuarios.Add(new Usuarios(2, "Glad", true, "Gladys", "Rosales", "siomalararosales@hotmail.es", "1234"));
            this.usuarios.Add(new Usuarios(3, "Chucky", true, "Deivy", "Gurrion", "deivygurrion@gmail.com", "1234"));
        }
        public void NotificarCambio(string propiedad){
            if(PropertyChanged != null){
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }
        public bool CanExecute(object parametro)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            
        }
    }
}