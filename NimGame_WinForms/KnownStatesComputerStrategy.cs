using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimGame_WinForms
{
    static class KnownStatesComputerStrategy
    {
        
        static public (int stack, int numberElements) Strategy(List<Stack> stacks,Dictionary<int,int> minValue, Dictionary<int,int> maxValue)
        {
            if (!ComputerStrategy.nearEnd(stacks))
            {
                int nimS = ComputerStrategy.nimSum(stacks);
                if (nimS == 0)
                {
                    int howManyNotEmpty = 0;

                    (int, int) answer = (0, 0);
                    

                    foreach (var st in stacks)
                    {
                        if (!st.checkIfEmpty())
                        {
                            howManyNotEmpty++;
                            answer = (st.number, st.numberOfElements);
                            
                        }


                    }
                    if (howManyNotEmpty > 4)
                    {
                        bool unicat = true;
                        for (int i = 0; i < stacks.Count; i++)
                        {
                            unicat = true;
                            if (!stacks[i].checkIfEmpty())
                            {
                                for (int j = 0; j < stacks.Count; j++)
                                {
                                    if (i != j && stacks[i].numberOfElements == stacks[j].numberOfElements)
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
                    if(howManyNotEmpty == 4 )
                    {
                        int minimalHeight = 1000;
                        int minimalStack = 1000;
                        int numberOfOne = 0;
                        foreach (var st in stacks)
                        {   if(st.numberOfElements==1)
                            {
                                numberOfOne++;
                            }
                            else if (!st.checkIfEmpty() && minimalHeight > st.numberOfElements)
                            {
                                minimalHeight = st.numberOfElements;
                                minimalStack = st.number;
                            }
                        }
                        if(numberOfOne==2)
                        {
                            return (minimalStack, 1);
                        }
                        else
                        {
                            return (minimalStack, minimalHeight - 1);
                        }
                    }
                    if(howManyNotEmpty == 3)
                    {
                        int minimalHeight = 1000;
                        int minimalStack = 1000;
                        int secondHeight = 1000;
                        int secondStack = 1000;

                        List<Stack> tmp =stacks.OrderBy(a => a.numberOfElements).ToList();

                        minimalHeight = tmp[0].numberOfElements;
                        minimalStack = tmp[0].number;
                        secondHeight = tmp[1].numberOfElements;
                        secondStack = tmp[1].number;
                        if(minimalHeight > 5)
                        {
                            return (minimalStack, minimalHeight - 5);
                        }
                        else if(secondHeight < minValue[minimalHeight])
                        {
                            return (minimalStack, 1);
                        }
                        else if(secondHeight> maxValue[minimalHeight])
                        {
                            return (secondStack, secondHeight - maxValue[minimalHeight]);
                        }
                    }
                }
            }
            return ComputerStrategy.nearEndStrategy(stacks);
        }
    }
}
