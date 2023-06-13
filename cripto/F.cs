using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

 public class F
  {
    

    public static List<string> separar(string palavra)
    {
        List<string> l = new List<string>();
        foreach(char c in palavra)
            l.Add(c.ToString());
        return l;
    }


    public static string Cif(string palavra)
    {
        string r ="";
        foreach(char c in palavra)
        {
            if(char.IsLetter(c))
            {
                char cf = (char)(((char.ToUpper(c) - 'A' + 7) % 26) + 'A');
                r += char.IsLower(c) ? char.ToLower(cf) : cf;
            }
            else
            {
                r += c;
            }
        }
        return r;
    }

    public static string gerar()
    {
        Random b = new Random();
        const string ca = "abcdefghijklmnopqrstuvwxyz_";
        string g = new string(Enumerable.Repeat(ca, 10).Select(c =>
        c[b.Next(c.Length)]).ToArray());

        return g;
    }
}

