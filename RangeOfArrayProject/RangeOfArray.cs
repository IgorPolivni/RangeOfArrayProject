using System;
using System.Collections.Generic;
using System.Text;

namespace RangeOfArrayProject
{
    class RangeOfArray
    {
        public int Superscript { get; set; } = 0; //верхний индекс
        public int Subscript { get; set; } = 0;   //нижний индекс

        private int[] array = new int[200];
        public int this[int index]
        {
            get
            {
                if (index >= Subscript && index <= Superscript)
                {
                    return array[index - Subscript];
                }
                return int.MaxValue;
            }
            set
            {
                if (index >= Subscript && index <= Superscript)
                    array[index - Subscript] = value;
            }
        }

    }
}
