using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Practica6.Models;

namespace Practica6.ModelView
{
    public class NUsuariosViewModel : INotifyPropertyChanged, ICommand
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;
        public NUsuariosViewModel Instancia { get; set; }
        public UsuariosViewModel UsuariosViewModel { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string HeightLblPassword { get; set; } = "Auto";
        public string HeightTxtPassword { get; set; } = "Auto";
        public Usuarios Usuario{get;set;}

        public NUsuariosViewModel(UsuariosViewModel UsuariosViewModel)
        {
            this.Instancia = this;
            this.UsuariosViewModel = UsuariosViewModel;

            //MODIFICANDO ELEMENTO
            if (this.UsuariosViewModel.Seleccionado != null)
            {
                this.Usuario = new Usuarios();
                this.Usuario.Id = this.UsuariosViewModel.Seleccionado.Id;
                this.Usuario.Enabled = this.UsuariosViewModel.Seleccionado.Enabled;
                this.Usuario.Password = this.UsuariosViewModel.Seleccionado.Password;

                this.Apellidos = this.UsuariosViewModel.Seleccionado.Apellidos;
                this.Nombres = this.UsuariosViewModel.Seleccionado.Nombres;
                this.Email = this.UsuariosViewModel.Seleccionado.Email;
                this.Username = this.UsuariosViewModel.Seleccionado.Username;
                this.HeightLblPassword = "0";
                this.HeightTxtPassword = "0";
            }
        }

        public bool CanExecute(object parametro)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            if (parametro is Window)
            {
                if (this.UsuariosViewModel.Seleccionado == null)
                {
                    Usuarios nuevo = new Usuarios(5, Username, true, Nombres, Apellidos, Email);
                    nuevo.Password = ((PasswordBox)((Window)parametro).FindName("TxtPassword")).Password;
                    this.UsuariosViewModel.agregarElemento(nuevo);
                }
                else
                {
                    Usuario.Apellidos = this.Apellidos;
                    Usuario.Nombres = this.Nombres;
                    Usuario.Email = this.Email;
                    Usuario.Username = this.Username;

                    int posicion = this.UsuariosViewModel.usuarios.IndexOf(this.UsuariosViewModel.Seleccionado);
                    this.UsuariosViewModel.usuarios.RemoveAt(posicion);
                    this.UsuariosViewModel.usuarios.Insert(posicion, Usuario);
                }
                ((Window)parametro).Close();
            }
        }
    }
}