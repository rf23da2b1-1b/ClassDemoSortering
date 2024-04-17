using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoSortering
{
    // Definere Enum
    public enum IsTyper { RegnbueIs=1, VanillieÍs, ChokoladeIs, KaffeIs}


    public class MinEnum
    {

        private IsTyper _isType;

        public IsTyper IsType
        {
            get { return _isType; }
            set { _isType = value; }
        }

        public MinEnum()
        {
            _isType = IsTyper.KaffeIs;
        }

        public override string ToString()
        {
            return $"{{IsType = {_isType}}}";
        }
    }
}
