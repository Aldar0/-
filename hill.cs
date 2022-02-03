using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Форма_Хилл
{
    interface hill
    {
        string Word { get; set; }
        string Key { get; set; }
        string Word1 { get; set; }
        string Key1 { get; set; }
    }
    public abstract class Encryption : hill
    {
        public string Enc;
        public string Dec;
        public int C;
        public string Word { get; set; }
        public string Key { get; set; }
        public string Word1 { get; set; }
        public string Key1 { get; set; }
        protected char [] alf = new char [] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ',', '.', ' ' };
        public Encryption ( string text,string text1,string text2,string text3)
        {
            Word = text;
            Key = text1;
            Word1 = text2;
            Key1 = text3;
        }
        public virtual void Encpted()
        {

        }
        public virtual void Decpted()
        {

        }
        public virtual void Check()
        {

        }
    }
    public class Hill:Encryption
    {
        public Hill(string text, string text1, string text2, string text3) : base(text,text1,text2,text3)
        {

        }
        public static int[,] converttomass(int n, string word, char[] alf)
        {
            int[,] massword = new int[3, 3];
            int[] mass1 = new int[9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (word[i] == alf[j])
                    {
                        mass1[i] = j;
                    }
                }
            }
            int k = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    massword[i, j] = mass1[k];
                    k++;
                }
            }
            return massword;
        }
        public static int[,] multmass(int[,] massword, int[,] masskey)
        {
            int[,] resh = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int s = 0; s < 3; s++)
                    {
                        resh[i, j] += massword[i, s] * masskey[s, j];
                    }
                }
            }
            return resh;
        }
        public static int reverse(int n, int a, int y2, int y1)
        {
            int q = n / a;
            int r = n % a;
            n = a;
            int y = y2 - q * y1;
            y2 = y1;
            y1 = y;
            a = r;
            if (r == 0)
            {
                return (y2);
            }
            else
                return reverse(n, a, y2, y1);
        }
        public override void Check()
        {
            string Key = this.Key;
            int n = 29;
            int[,] masskey = converttomass(n, Key, alf);
            int opred = masskey[0, 0] * masskey[1, 1] * masskey[2, 2] + masskey[0, 1] * masskey[1, 2] * masskey[2, 0] + masskey[1, 0] * masskey[2, 1] * masskey[0, 2] - masskey[0, 2] * masskey[1, 1] * masskey[2, 0] - masskey[0, 1] * masskey[1, 0] * masskey[2, 2] - masskey[0, 0] * masskey[1, 2] * masskey[2, 1];
            if (opred == 0)
            {
                this.C = 1;
            }
        }
        public override void Encpted()
        {
            string Word = this.Word;
            string Key = this.Key;
            string enc = "";
            int n = 29;
            if (Word.Length<9)
            {
                int x = 9 - Word.Length;
                for (int i = 0; i < x; i++)
                {
                    Word += ' ';
                }
            }
            while (Key.Length != 9)
            {
                Console.WriteLine("Ведите новый ключ");
            }
            int[,] massword = converttomass(n, Word, alf);
            int[,] masskey = converttomass(n, Key, alf);
            int opred = masskey[0, 0] * masskey[1, 1] * masskey[2, 2] + masskey[0, 1] * masskey[1, 2] * masskey[2, 0] + masskey[1, 0] * masskey[2, 1] * masskey[0, 2] - masskey[0, 2] * masskey[1, 1] * masskey[2, 0] - masskey[0, 1] * masskey[1, 0] * masskey[2, 2] - masskey[0, 0] * masskey[1, 2] * masskey[2, 1];
            if (opred == 0)
            {
                Console.WriteLine("Введите другой ключ");
            }
            int[,] resh = multmass(massword, masskey);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resh[i, j] = Math.Abs(resh[i, j] % n);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int s = 0; s < 29; s++)
                    {
                        if (resh[i, j] == s)
                        {
                            enc += Convert.ToString(alf[s]);
                        }
                    }
                }
            }
            this.Enc = enc;
        }
        public override void Decpted()
        {
            string Word = this.Word1;
            string Key = this.Key1;
            string dec = "";
            int n = 29;
            int[,] massword = converttomass(n, Word, alf);
            int[,] masskey = converttomass(n, Key, alf);
            int opred = masskey[0, 0] * masskey[1, 1] * masskey[2, 2] + masskey[0, 1] * masskey[1, 2] * masskey[2, 0] + masskey[1, 0] * masskey[2, 1] * masskey[0, 2] - masskey[0, 2] * masskey[1, 1] * masskey[2, 0] - masskey[0, 1] * masskey[1, 0] * masskey[2, 2] - masskey[0, 0] * masskey[1, 2] * masskey[2, 1];
            if (opred == 0)
            {
                Console.WriteLine("Введите другой ключ");
            }
            opred %= n;
            if (opred < 0)
            {
                opred += n;
            }
            int rev = reverse(n, opred, 0, 1);
            if (rev < 0)
            {
                rev += n;
            }
            int[,] algebdop = new int[3, 3];
            algebdop[0, 0] = (masskey[1, 1] * masskey[2, 2] - masskey[1, 2] * masskey[2, 1]) % 29;
            algebdop[0, 1] = -1 * (masskey[1, 0] * masskey[2, 2] - masskey[1, 2] * masskey[2, 0]) % 29;
            algebdop[0, 2] = (masskey[1, 0] * masskey[2, 1] - masskey[1, 1] * masskey[2, 0]) % 29;
            algebdop[1, 0] = -1 * (masskey[0, 1] * masskey[2, 2] - masskey[0, 2] * masskey[2, 1]) % 29;
            algebdop[1, 1] = (masskey[0, 0] * masskey[2, 2] - masskey[0, 2] * masskey[2, 0]) % 29;
            algebdop[1, 2] = -1 * (masskey[0, 0] * masskey[2, 1] - masskey[0, 1] * masskey[2, 0]) % 29;
            algebdop[2, 0] = (masskey[0, 1] * masskey[1, 2] - masskey[0, 2] * masskey[1, 1]) % 29;
            algebdop[2, 1] = -1 * (masskey[0, 0] * masskey[1, 2] - masskey[0, 2] * masskey[1, 0]) % 29;
            algebdop[2, 2] = (masskey[0, 0] * masskey[1, 1] - masskey[0, 1] * masskey[1, 0]) % 29;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (algebdop[i, j] < 0)
                    {
                        algebdop[i, j] += n;
                    }
                }
            }
            int[,] trans = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    trans[i, j] = algebdop[j, i];
                }
            }
            int[,] keyrev = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    keyrev[i, j] = trans[i, j] * rev % 29;
                }
            }
            int[,] resh1 = multmass(massword, keyrev);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resh1[i, j] = Math.Abs(resh1[i, j] % n);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int s = 0; s < 29; s++)
                    {
                        if (resh1[i, j] == s)
                        {
                            dec += Convert.ToString(alf[s]);
                        }
                    }
                }
            }
            this.Dec = dec;
        }
    }
}
