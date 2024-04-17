using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoSortering
{
    public class Dims:IComparable<Dims> // interface til default sortering
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Dims(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Dims():this(-1,"",0)
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Price)}={Price.ToString()}}}";
        }


        /*
        * Default sorttering
        */
        public int CompareTo(Dims? other)
        {
            return Id - other.Id;
        }
    }
}
