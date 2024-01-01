using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPro_HW.HW3
{
    public interface ISort
    {
        void SortAsc();

        void SortDesc();

        void SortByParam(bool isAsc);
    }
}