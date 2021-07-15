using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Cell
    {
        public string Name;
        public string Color ;
        public bool queen=false;
        public int x;
        public int y;
        public bool IsGoldWay=false;
        public bool IsDoubleWay_b1h7 = false;
        public bool IsDoubleWay_a2g8 = false;
        public bool IsTripleWay_f1h3 = false;
        public bool IsTripleWay_a6c8 = false;
        public bool IsTripleWay_f1a6 = false;
        public bool IsTripleWay_h3c8 = false;
        public bool IsUltraWay_d1h5 = false;
        public bool IsUltraWay_a4e8 = false;
        public bool IsUltraWay_d1a4 = false;
        public bool IsUltraWay_h5e8 = false;
        public bool mustEat = false;


    }
}
