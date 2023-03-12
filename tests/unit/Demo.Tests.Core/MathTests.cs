namespace Demo.Tests.Core
{
  using Demo.Core;
  using Microsoft.VisualStudio.TestTools.UnitTesting;

  /// <summary>
  /// Summary description for Math
  /// </summary>
  [TestClass]
  public class MathTests
  {

    /// <summary>
    /// should create an instance of Module.
    /// </summary>
    [TestMethod]
    public void createInstance()
    {

      // parameters
      var expected = typeof(Math);

      // operation
      var result = new Math();

      // result
      var actual = result;

      // condination
      Assert.IsInstanceOfType(actual, expected);
    }

    /// <summary>
    /// must be able to add two numbers.
    /// </summary>
    [TestMethod]
    public void addTwoNumbers()
    {
      // Instance
      var instance = new Math();

      // parameters
      var expected = 3;

      // operation
      var result = instance.Addition(1, 2);

      // result
      var actual = result;

      // condination
      Assert.AreEqual(actual, expected);
    }

    /// <summary>
    /// should know how to multiply two numbers.
    /// </summary>
    [TestMethod]
    public void multiplyTwoNumbers()
    {
      // Instance
      var instance = new Math();

      // parameters
      var expected = 2;

      // operation
      var result = instance.Multiplication(1, 2);

      // result
      var actual = result;

      // condination
      Assert.AreEqual(actual, expected);
    }
  }
}
