using System;
using System.Collections.Generic;

namespace TableauC
{
    class Program
    {
        static void Main(string[] args)
        {
            table tab = new table(7);
            
            tab.insert(2,0);
            tab.insert(5,1);
            tab.insert(1,2);
            tab.insert(4,3);
            tab.insert(1,4);
            tab.insert(5,5);
            tab.insert(2,6);
            
            tab.affiche();
            Console.WriteLine("sym");
            Console.WriteLine(tab.Symetrie() + " : on remarque que la table est  symetrique");
            tab.Trie();
            Console.WriteLine("le trie");
            tab.affiche();
            Console.WriteLine("sym");
            Console.WriteLine(tab.Symetrie()+ " : on remarque que la table n'est pas symetrie");
            Console.WriteLine("rev");
            tab.Reverse();
            tab.affiche();
            Console.WriteLine("recherche le nombre 2");
            tab.racherche(2);
            Console.WriteLine("le recherche est " + tab.racherche(2));
            Console.WriteLine("longueur du tableu");
            Console.WriteLine(tab.length());
            Console.WriteLine("delete l'element qui a index 2 ");
            tab.supprimerIndex(2);
            tab.affiche();

        }
    }
    
}
