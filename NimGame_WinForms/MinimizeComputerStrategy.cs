using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimGame_WinForms
{
    static class MinimizeComputerStrategy
    {
        static public (int stack, int numberElements) Strategy(List<Stack> stacks)
        {
            int howManyNotEmpty = 0;
            
            (int, int) answer=(0,0);
            

            foreach (var st in stacks)
            {
                if (!st.checkIfEmpty())
                {
                    howManyNotEmpty++;
                    answer = (st.number, st.numberOfElements);
                }
                
                
            }
            if(howManyNotEmpty>4)
            {
                bool unicat = true;
                for (int i = 0; i < stacks.Count; i++)
                {
                    unicat = true;
                    if (!stacks[i].checkIfEmpty())
                    {
                        for (int j = 0; j < stacks.Count; j++)
                        {
                            if (i!=j && stacks[i].numberOfElements == stacks[j].numberOfElements)
                            {
                                unicat = false;
                                break;
                            }
                        }
                        if (unicat)
                        {
                            answer = (stacks[i].number, stacks[i].numberOfElements);
                            break;
                        }
                    }
                }
                return answer;
            }
             
            return ComputerStrategy.nimMove(stacks);
        }
    }
}
