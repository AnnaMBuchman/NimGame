using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimGame_WinForms
{
    static class RandomComputerStrategy
    {
        static public (int stack, int numberElements) Strategy(List<Stack> stacks)
        {
            if (!ComputerStrategy.nearEnd(stacks))
            {
                int nimS = ComputerStrategy.nimSum(stacks);
                if (nimS == 0)
                {
                    int howManyNotEmpty = 0;
                    int s = 0;
                    int numberOfElements = 0;
                    int[] ifEmpty = new int[stacks.Count];
                    int i = 0;
                    foreach (var st in stacks)
                    {
                        if (!st.checkIfEmpty())
                        {
                            howManyNotEmpty++;
                            ifEmpty[i] = 1;
                        }
                        else ifEmpty[i] = 0;
                        i++;
                    }
                    Random r = new Random();
                    int rn = r.Next(howManyNotEmpty) + 1;
                    for (i = 0; i < stacks.Count; i++)
                    {
                        if (!stacks[i].checkIfEmpty())
                            rn--;
                        if (rn == 0)
                        {
                            s = i;
                            break;
                        }

                    }
                    numberOfElements = r.Next(stacks[s].numberOfElements) + 1;
                    return (s, numberOfElements);
                }
            }
            return ComputerStrategy.nearEndStrategy(stacks);
        }
    }
}
