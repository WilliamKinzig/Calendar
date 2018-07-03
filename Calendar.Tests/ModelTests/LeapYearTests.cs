//imports the MSTest framework for us to use
using Microsoft.VisualStudio.TestTools.UnitTesting;

//imports the Calendar namespace from the Calendar project for use in our tests
using Calendar;

namespace Calendar.Tests
{

  [TestClass] //This tells MSTest that the following class contains tests to be run
  public class LeapYearTest
  {
    //This tells the compiler that the following code block is an individual
    //test that should be run by MSTest
    [TestMethod]

    //This is the test.
    //naming convention is basically
    //MethodToBeTested_BehaviorToBeTested_ExpectedResultOfTest
    public void IsLeapYear_NumberDivisibleByFour_True()
    {
      // eventually your testing code will go here
    }
  }
}
