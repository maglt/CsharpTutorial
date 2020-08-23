using System;

namespace ClassLibrary1
{
    public class Boy
    {
        public int Id { get; set; }

        public Boy(int Id)
        {
            this.Id = Id;
        }

        public int AddNumbers(int A, int B)
        {
            return A + B;
        }
    }


}
