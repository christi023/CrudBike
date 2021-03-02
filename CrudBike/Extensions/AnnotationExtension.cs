using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CrudBike.Extensions
{     
        public class YearRangeTillDateAttribute : RangeAttribute
        {
            public YearRangeTillDateAttribute(int StartYear) : base(StartYear, DateTime.Today.Year)
            {

            }
        }
    }
