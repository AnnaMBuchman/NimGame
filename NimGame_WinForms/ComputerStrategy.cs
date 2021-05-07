using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimGame_WinForms
{
    static class ComputerStrategy
    {
        static public int nimSum(List<Stack> stacks)
        {
            int nimsum = 0;
            foreach(var s in stacks)
            {
                nimsum = nimsum ^ s.numberOfElements;
            }
            return nimsum;
        }
        static public bool nearEnd(List<Stack> stacks)
        {
            int numerstacks = 0;
            foreach(var s in stacks)
            {
                if (s.numberOfElements > 1) numerstacks++;
                if (numerstacks > 1) return false;
            }

            return true;
        }
        static public (int stack, int numberElements) nearEndStrategy(List<Stack> stacks)
        {
            int max = 0;
            int maxiter = 0;
            int count = 0;
            foreach (var s in stacks)
            {
                if (s.numberOfElements > 0)
                {
                    count++;
                    if (max < s.numberOfElements)
                    {
                        max = s.numberOfElements;
                        maxiter = s.number;
                    }
                }

            }
            if (count % 2 == 1)
            {
                if (max > 1)
                {

                    return (maxiter, max - 1);
                }
                else
                {
                    return (maxiter, 1);
                }
            }           

            return (maxiter, max);            
        }
        static public (int stack, int numberElements) nimMove(List<Stack> stacks)
        {
            if(!nearEnd(stacks))
            {
                int nimS = nimSum(stacks);
                if(nimS!=0)
                {
                    foreach(var s in stacks)
                    {
                        int numberE=s.numberOfElements;
                        int targetSize = nimS ^ numberE;
                        int toRemove = 0;
                        if (targetSize < numberE)
                        {
                            toRemove = numberE - targetSize;
                            return (s.number, toRemove);
                        }
                    }
                }
                else
                {
                    int h=0;
                    int numerS = 0;
                    foreach(var s in stacks)
                    {
                        if(h<s.numberOfElements)
                        {
                            numerS = s.number;
                            h = s.numberOfElements;
                            
                        }    
                    }
                    return (numerS, 1);

                }

            }
            else
            {
                return nearEndStrategy(stacks);
            }
            return (0, 0);
        }

    }
}
