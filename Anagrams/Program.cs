using System;
using System.Linq;

namespace Anagrams
{
  public class Program
  {
    static void Main(string[] args)
    {

    }

    public static bool IsAnagram(string s1, string s2)
    {
      char[] c1 = s1.ToCharArray();
      char[] c2 = s2.ToCharArray();

      Array.Sort(c1);
      Array.Sort(c2);

      if (c1.SequenceEqual(c2))
      {
        return true;
      }
      return false;
    }
  }
}
