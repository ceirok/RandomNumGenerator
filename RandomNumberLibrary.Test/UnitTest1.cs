using System;
using System.Collections.Generic;
using Xunit;
using RandomNumberLibrary;

namespace RandomNumberLibrary.Test
{
    public class NumberGenerator
    {
        [Fact]
        public void Should_BeAbleToGenerateNumbers()
        {
            var numberGenerator = new RandomNumberLibrary.NumberGenerator();
            List<int> result = numberGenerator.GenerateListItems(10);

            Assert.Equal(10, result.Count);
        }

        [Fact]
        public void Should_BeAbleToAssertTrue_WhenAllListItemsUnique()
        {
            var numberGenerator = new RandomNumberLibrary.NumberGenerator();
            List<int> numberList = numberGenerator.GenerateListItems(10);
            bool result = false;
            for(int i = 0; i < numberList.Count; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(numberList[i] == numberList[j])
                    {
                        break;
                    } else
                    {
                        result = true;
                    }
                }
            }
            Assert.Equal(true, result);
        }
    }
}
