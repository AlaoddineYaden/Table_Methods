﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TableauC
{
    class table
    {
        int[] arrInt;
        String[] arrString;
        int taille;
        // constructeur du tableau

        public table(int taille)
        {
            this.taille = taille;
            arrInt = new int[taille];
            arrString = new string[taille];
        }
        // methode inserer int
        public int insert(int valeurInt, int index)
        {
            if (index < taille && index >= 0)
            {
                arrInt[index] = valeurInt;
                return 1;
            }
            else {
                return 0;
            }
        }
        // methode inserer string
        public int insert(String valeurString, int index)
        {
            if (index < taille && index >= 0)
            {
                arrString[index] = valeurString;
                return 1;
            }
            else
            {
                return 0;
            }
        }
        // methode supprimer int

        public int supprimerVal(int valeurInt)
        {
            int i;
            int v = 0;
            for (i = 0; i < arrInt.Length; i++)
            {
                if (arrInt[i] == valeurInt)
                {
                    for (int j = i; j < arrInt.Length-1; j++)
                    {
                        arrInt[j] = arrInt[j + 1];
                        if((j+1) == arrInt.Length - 1)
                        {
                            arrInt[j + 1] = 0;
                        }
                    }
                    v = 1;
                    break;
                }
            }
            return v;
        }
        // methode supprimer int avec index

        public int supprimerIndex(int index)
        {
            int i;
            int v = 0;
            if (index < taille && index >= 0)
            {
                for (i = index; i < arrInt.Length-1; i++)
                {
                    arrInt[i] = arrInt[i + 1];
                    if ((i + 1) == arrInt.Length-1 )
                    {
                        arrInt[i+ 1] = 0;
                    }
                    v = 1;
                    
                }
                return v;
            }
            else
            {
                return v;
            }
        }
        // methode supprimer string
        public int supprimerVal(String valeurString)
        {
            int i;
            int v = 0;
            for (i = 0; i < arrInt.Length; i++)
            {
                if (arrString[i] == valeurString)
                {
                    for (int j = i; j < arrString.Length; j++)
                    {
                        arrString[j] = arrString[j + 1];
                    }
                    v = 1;
                    break;
                }
            }
            return v;
        }

        // methode supprimer string avec index
        public int supprimerStringIndex(int index)
        {
            int i;
            int v = 0;
            if (index < taille && index >= 0)
            {
                for (i = index; i < arrString.Length; i++)
                {
                    arrString[i] = arrString[i + 1];
                    v = 1;
                    break;
                }
                return v;
            }
            else
            {
                return v;
            }
        }
        // methode recherche valeur int 
        public int racherche(int valeurInt)
        {
            int v = 0;
            for (int i = 0; i < taille; i++)
            {
                if (arrInt[i] == valeurInt)
                {
                    v = 1;
                    break;
                }
            }
            return v;
        }
        public int racherche(String valeurString)
        {
            int v = 0;
            for (int i = 0; i < taille; i++)
            {
                if (arrString[i] == valeurString)
                {
                    v = 1;
                    break;
                }
            }
            return v;
        }
        public int Trie()
        {
            int v = 0;
            int z = 0;
            for (int i = 0; i < taille - 1; i++)
            {
                for (int j = i + 1; j < taille; j++)
                {
                    if (arrInt[i] > arrInt[j])
                    {
                        z = arrInt[i];
                        arrInt[i] = arrInt[j];
                        arrInt[j] = z;
                        v = 1;
                    }
                }

            }
            return v;
        }
        public int Symetrie()
        {
            int v = 1;

            for (int i = 0, j = taille - 1; i < taille / 2 && j > taille / 2; i++, j--)
            {
                if (arrInt[i] != arrInt[j])
                {
                    v = 0;

                }
            }
            return v;
        }
        public int Reverse()
        {
            int v = 1;
            int z = 0;

            for (int i = 0, j = taille - 1; i < taille / 2 && j > taille / 2; i++, j--)
            {
                z = arrInt[i];
                arrInt[i] = arrInt[j];
                arrInt[j] = z;
                v = 1;
            }
            return v;
        }
        public int length()
        {
            int i, count = 0;
            for (i = 0; i < this.arrInt.Length; i++)
            {
                count++;
            }
            return count;
        }
        //public table concate(table tab, table tab2)
        //{
        //    int i, j;
        //    int length =tab.length() + tab2.length();
        //    table arrInt = new table(length);
        //    for (i = 0; i < tab.Length; i++)
        //    {
        //        arrInt[i] = tab[i];
        //    }
        //    int z;
        //    for (j = i,  z = 0; j < taille && z<tab2.Length; j++, z++)
        //    {
        //        arrInt[j] = tab2[z];
        //    }
        //    return this;
        //}


        public void affiche()
        {
            foreach(int n in arrInt)
            {
                Console.WriteLine(n);
            }
        }
    }
}
