using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro.Models
{
    public class Libros
    {
        private ObservableCollection<Libro> data;

        public ObservableCollection<Libro> Data {
            get {
                if (data == null) {
                    data = new ObservableCollection<Libro>();
                    Libro libro1 = new Libro()
                    {
                        Nombre = "Padre Rico Padre Pobre",
                        Autor = "Robert",
                        Codigo = "a101",
                        Genero = "Economia",
                        Paginas = 300
                    };

                    Libro libro2 = new Libro()
                    {
                        Nombre = "Orgullo y prejuicio",
                        Autor = "Jane",
                        Codigo = "a102",
                        Genero = "Romance",
                        Paginas = 300
                    };

                    Libro libro3 = new Libro()
                    {
                        Nombre = "Caperucita Roja",
                        Autor = "Grimm",
                        Codigo = "a103",
                        Genero = "Terror",
                        Paginas = 500
                    };

                    data.Add(libro1);
                    data.Add(libro2);
                    data.Add(libro3);


                }
                return data;
            }

            set {
                data = value;
            }
        
        }

    }
}
