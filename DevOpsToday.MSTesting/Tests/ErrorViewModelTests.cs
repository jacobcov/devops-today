using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using DevOpsToday.Models;

namespace DevOpsToday.MSTesting.Tests
{
  [TestClass]
  public class ErrorViewModelTests
  {
    [TestMethod]
    public void Test_ShowRequestIdMethod()
    {
      var sut = new ErrorViewModel(){RequestId="yes"};

      Assert.IsTrue(sut.ShowRequestId);
      Assert.IsTrue(sut.RequestId=="yes");
    } 
  }
}