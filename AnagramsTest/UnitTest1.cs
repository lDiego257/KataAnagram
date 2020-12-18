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
    public void Escenario1_1()
    {
      bool expected = Program.IsAnagram("amor", "mora");
      Assert.AreEqual(expected, true);
    }

    [Test]
    public void Escenario1_2()
    {
      bool expected = Program.IsAnagram("giro", "ori");
      Assert.AreEqual(expected, false);
    }
  }

}