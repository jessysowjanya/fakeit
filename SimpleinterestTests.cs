using FakeItEasy;
using System;
using Xunit;
using XUnitTestProject1.classes;

namespace XUnitTestProject1
{
    public class SimpleinterestTests
    {
        [Fact]
        public void Calculate_SimpleIntrest_and_Fake_ImathsInterFace_Expected_Result_Equal()
        {
            var Imaths = A.Fake<IMaths>();
            Simpleinterest simpleinterest = new Simpleinterest(Imaths);
            int principle =10000;
            int rate =5;
            int time =2;
            var result= simpleinterest.CalulateSimpleinterest(principle,rate,time);
            Assert.Equal(1000,result);
        }

        [Fact]
        public void Calculate_SimpleIntrest_and_Fake_ImathsInterFace__Expected_Result_NotEqual()
        {
            var Imaths = A.Fake<IMaths>();
            //IMaths t = new IMaths();
            Simpleinterest simpleinterest = new Simpleinterest(Imaths);
            int principle = 10000;
            int rate = 5;
            int time = 2;
            var result = simpleinterest.CalulateSimpleinterest(principle, rate, time);
            Assert.NotEqual(100, result);
        }
    }
}
