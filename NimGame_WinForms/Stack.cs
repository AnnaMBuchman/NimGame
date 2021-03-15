using System;
using System.Collections.Generic;
using System.Text;

namespace NimGame_WinForms
{
    public class Stack
    {
        private int number { get; }
        private int numberOfElements { get; set; }
        public Stack(int number, int numberOfElements)
        {
            this.number=number;
            this.numberOfElements = numberOfElements;
        }

        public void takeNumberOfElements(int takenElements)
        {
            if (numberOfElements >= takenElements)
                numberOfElements -= takenElements;
            else
                throw new ArgumentException("to large number of takenElements");
        }
        public bool checkIfEmpty()
        {
            if (numberOfElements == 0)
                return true;
            return false;
        }
        public bool canBeTaken(int elementsToTake)
        {
            if (numberOfElements >= elementsToTake&&elementsToTake>0)
                return true;
            return false;
        }
    }
}
