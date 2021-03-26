using System.Collections.ObjectModel;
using System.ComponentModel;
using Practica6.Models;

namespace Practica6.ModelView
{
    public class RolesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Roles> roles{get;set;}

        public RolesViewModel()
        {
            roles = new ObservableCollection<Roles>();

            roles.Add(new Roles(1, "ROLE_ADMIN"));
            roles.Add(new Roles(2, "ROLE_USER"));
            roles.Add(new Roles(3, "ROLE_SUPERV")); 
        }

        public void NotificarCambio(string propiedad){
            if(PropertyChanged != null){
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }
    }
}