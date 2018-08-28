using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        //public Position Postions { get; set; }

        public virtual void Draw()
        {

        }
    }
}
