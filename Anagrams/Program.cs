using System;
using System.Linq;
using System.IO;

namespace Anagrams
{
  public class Program
  {
    static void Main(string[] args)
    {

    }

    public static bool IsAnagram(string s1, string s2)
    {
      if (s1.Length != s2.Length) return false;

      char[] c1 = s1.ToCharArray(), c2 = s2.ToCharArray();

      Array.Sort(c1);
      Array.Sort(c2);

      if (c1.SequenceEqual(c2)) return true;

      return false;
    }

    public static bool FindAnSpecificAnagramInFile(string path, string g)
    {

      bool isAnagramAux = true;
      var content = File.ReadAllLines(path);
      content.GroupBy(w => String.Concat(w.OrderBy(c => c)));
      content.Where(g => g.Count() > 1);
      content.ToList();

      foreach (string x in content)
      {
        if (g.Length == x.Length && g != x)
        {
          if (IsAnagram(g, x))
          {
            if (isAnagramAux) Console.Write(g);
            Console.Write(" " + x);
            isAnagramAux = false;
          }
        }
      }
      return !(isAnagramAux);

    }

    public static void WriteInFile(string outPath, string g)
    {
      using (StreamWriter file =
        new StreamWriter(outPath, true))
      {
        file.WriteLine(g);
      }
    }
  }
}
