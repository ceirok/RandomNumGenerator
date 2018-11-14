using System;
using System.Collections.Generic;

namespace RandomNumberLibrary
{
    public class NumberGenerator
    {
        private List<int> numberList { get; set; }

        public NumberGenerator()
        {
            this.numberList = new List<int>();
        }

        public List<int> GenerateListItems(int num)
        {
            Random rnd = new Random();
            List<int> generatedList = new List<int>();
            for(int i = 0; i < num; i++)
            {
                int randNum = rnd.Next(1, 100000);
                if(checkIfInArray(randNum))
                {
                    generatedList.Add(randNum);
                }
            }
            return generatedList;
        }

        public bool checkIfInArray(int num)
        {
            bool isInArray = true;
            for (int i = 0; i < numberList.Count; i++)
            {
                if (num != numberList[i])
                {
                    isInArray = false;
                }                
            }
            return isInArray;
        }
    }
}
