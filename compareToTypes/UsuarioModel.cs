using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compareToTypes
{
    internal class UsuarioModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double height { get; set; }

        public UsuarioModel(int id, string name, int age, double height)
        {
            Id = id;
            Name = name;
            Age = age;
            this.height = height;
        }
    }
}
