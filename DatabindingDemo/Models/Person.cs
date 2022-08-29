using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingDemo.Models
{
     public class Person : INotifyPropertyChanged
     {
          public string Name { get; set; }
          public string Phone { get; set; }
          public string Address { get; set; }

          public event PropertyChangedEventHandler PropertyChanged;

          protected void OnPropertyChanged([CallerMemberName] string propName = null)
          {
               PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(propName));
          }
     }
}
