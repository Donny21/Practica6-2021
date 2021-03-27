using System;
using System.ComponentModel;
using System.Windows.Input;
using Practica6.Models;

namespace Practica6.ModelView
{
    public class NRolesViewModel : INotifyPropertyChanged, ICommand
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;
        public NRolesViewModel Instancia{get;set;}
        public RolesViewModel RolesViewModel{get;set;}

        public string NombreRol{get;set;}

        public NRolesViewModel(RolesViewModel RolesViewModel)
        {
            this.Instancia = this;
            this.RolesViewModel = RolesViewModel;
        }
        public bool CanExecute(object parametro)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            if(parametro.Equals("Guardar")){
                Roles nuevo = new Roles(4, NombreRol);
                this.RolesViewModel.agregarElemento(nuevo);
            }
        }
    }
}