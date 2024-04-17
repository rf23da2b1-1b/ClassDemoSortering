using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoSortering
{
    public class DimseRepository
    {
        private List<Dims> _dimser;

        public DimseRepository()
        {

            _dimser = new List<Dims>();
            _dimser.Add(new Dims(2, "leverpostej", 16));
            _dimser.Add(new Dims(4, "pølse", 19));
            _dimser.Add(new Dims(12, "laks", 36));
            _dimser.Add(new Dims(5, "frikadelle", 21));
            _dimser.Add(new Dims(6, "ost", 15));
            _dimser.Add(new Dims(1, "brie", 29));
        }


        public List<Dims> SomDenEr()
        {
            return new List<Dims>(_dimser);
        }

        public List<Dims> SortDefault()
        {
            _dimser.Sort(); // benytter default altså IComparable
            return new List<Dims>(_dimser);
        }

        public List<Dims> SortComparer()
        {
            _dimser.Sort(new SortByName()); // benytter ekstern sortering
            return new List<Dims>(_dimser);
        }

        public List<Dims> SortLinq()
        { 
            return _dimser.OrderByDescending(d => d.Price).ToList();
        }

    }

    public class SortByName : IComparer<Dims>
    {
        public int Compare(Dims? x, Dims? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
