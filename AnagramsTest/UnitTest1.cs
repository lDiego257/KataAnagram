using NUnit.Framework;
using Anagrams;

namespace AnagramsTest
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
      bool expected = Program.IsAnagram("amor", "mora");
      Assert.AreEqual(expected, true);
    }
  }
}