using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using Practica6.Models;
using Practica6.Views;

namespace Practica6.ModelView
{
    public class RolesViewModel : INotifyPropertyChanged, ICommand
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;

        public ObservableCollection<Roles> roles{get;set;}

        public RolesViewModel Instancia{get;set;}

        public Roles Seleccionado{get;set;}

        public RolesViewModel()
        {
            this.Instancia = this;

            roles = new ObservableCollection<Roles>();

            roles.Add(new Roles(1, "ROLE_ADMIN"));
            roles.Add(new Roles(2, "ROLE_USER"));
            roles.Add(new Roles(3, "ROLE_SUPERV")); 
        }
    
        //MATODO PARA NOTIFICAR CAMBIOS
        public void NotificarCambio(string propiedad){
            if(PropertyChanged != null){
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        //METODO PARA AGREGAR UN ELEMENTO DE LA COLECCION
        public void agregarElemento(Roles nuevo){
            this.roles.Add(nuevo);
        }

        public bool CanExecute(object parametro)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            //CARGAMOS EL NUEVO ELEMENTO A LA COLECCION
            if(parametro.Equals("Nuevo")){
                NRolesView nuevoRol = new NRolesView(Instancia);
                nuevoRol.Show();
            }
            //CONDICION PARA ELIMINAR UN ELEMENTO DE LA COLECCION
            else if(parametro.Equals("Eliminar")){
                if(this.Seleccionado == null){
                    MessageBox.Show("Debe seleccionar un elemento");
                }
                this.roles.Remove(Seleccionado);
            }
        }
    }
}