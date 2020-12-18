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

    [Test]
    public void Escenario1_3()
    {
      bool expected = Program.IsAnagram("giro", "orr ");
      Assert.AreEqual(expected, false);
    }

    [Test]
    public void Escenario2_1()
    {
      bool expected = Program.FindAnSpecificAnagramInFile(@"C:\Users\kevin\Projects\anagrams-cs\Anagrams\bin\Debug\Input.txt", "paro");
      Assert.AreEqual(expected, true);
    }

    [Test]
    public void Escenario2_2()
    {
      bool expected = Program.FindAnSpecificAnagramInFile(@"C:\Users\kevin\Projects\anagrams-cs\Anagrams\bin\Debug\Input.txt", "lolo");
      Assert.AreEqual(expected, false);
    }

    [Test]
    public void Escenario3_1()
    {
      int expected = Program.FindAllAnagramsInFile(@"C:\Users\kevin\Projects\anagrams-cs\Anagrams\bin\Debug\Input.txt", @"C:\Users\kevin\Projects\anagrams-cs\Anagrams\bin\Debug\Output.txt");
      Assert.AreEqual(expected, 2);
    }
    [Test]
    public void Escenario3_2()
    {
      int expected = Program.FindAllAnagramsInFile(@"C:\Users\kevin\Projects\anagrams-cs\wordlist.txt", @"C:\Users\kevin\Projects\anagrams-cs\Anagrams\bin\Debug\Output.txt");
      Assert.AreEqual(expected, 20683);
    }
  }

}