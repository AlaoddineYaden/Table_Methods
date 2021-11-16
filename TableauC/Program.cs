using System;
using System.Collections.Generic;

namespace TableauC
{
    class Program
    {
        static void Main(string[] args)
        {
            table tab = new table(7);
            table tab2 = new table(3);
            tab.insert(2,0);
            tab.insert(5,1);
            tab.insert(1,2);
            tab.insert(4,3);
            tab.insert(1,4);
            tab.insert(5,5);
            tab.insert(2,6);
            tab2.insert(33,0);
            tab2.insert(333, 1);
            tab2.insert(3333, 2);
            tab.affiche();
            Console.WriteLine("sym");
            Console.WriteLine(tab.Symetrie());
            tab.Trie();
            Console.WriteLine("le trie");
            tab.affiche();
            Console.WriteLine("sym");
            Console.WriteLine(tab.Symetrie());
            Console.WriteLine("rev");
            tab.Reverse();
            tab.affiche();
            Console.WriteLine("recherche");
            tab.racherche(2);
            Console.WriteLine("le recherche est " + tab.racherche(2));
            Console.WriteLine("length");
            Console.WriteLine(tab.length());
            Console.WriteLine("delete");
            tab.supprimerIndex(2);
            tab.affiche();

        }
    }
    
}
