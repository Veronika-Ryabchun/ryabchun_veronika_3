using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_13._2
{
    class Malenkiy : Avtobus
    {
        private int sidyachee;
        public Malenkiy(int sidyachee, string nomer, int spojivannya) : base(nomer, spojivannya)
        {
            this.sidyachee = sidyachee;
        }
        public override int miscya
        {
            get
            {
                return sidyachee;
            }
        }
    }
    class Seredniy : Avtobus
    {
        private int sidyachee;
        private int stoyachee;
        public Seredniy(int sidyachee, int stoyachee, string nomer, int spojivannya) : base(nomer, spojivannya)
        {
            this.sidyachee = sidyachee;
            this.stoyachee = stoyachee;
        }
        public override int miscya
        {
            get
            {
                return sidyachee + stoyachee;
            }
        }
    }
    class Velykiy : Avtobus
    {
        private int sidyachee;
        private int stoyachee;
        private int invalidnoe;
        public Velykiy(int sidyachee, int stoyachee, int invalidnoe, string nomer, int spojivannya) : base(nomer, spojivannya)
        {
            this.sidyachee = sidyachee;
            this.stoyachee = stoyachee;
            this.invalidnoe = invalidnoe;
        }
        public override int miscya
        {
            get
            {
                return sidyachee + stoyachee + invalidnoe;
            }
        }
    }
}
