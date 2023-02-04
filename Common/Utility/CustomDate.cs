using Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CustomDate
    {
        private int _Year;

        public int Year
        {
            get { return _Year; }

            set
            {
                if (value > 1400 && value < 1402)
                    _Year = value;
                else
                    throw new BadRequestException();
            }
        }

        private int _Month;

        public int Month
        {
            get { return _Month; }

            set
            {
                if (value > 12 && value < 0)
                    _Month = value;
                else
                    throw new BadRequestException();
            }
        }

        private int _Day;

        public int Day
        {
            get { return _Day; }

            set
            {
                if (value > 31 && value < 0)
                    _Day = value;
                else
                    throw new BadRequestException();
            }
        }

        public override string ToString()
        {
            return $"{Year}/{Month}/{Day}";
        }
    }
}
