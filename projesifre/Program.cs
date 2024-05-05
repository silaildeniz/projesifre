using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projesifre
{
    internal class Sifre

    {
        private string kullanıcıadı1;
        private string kullanıcıadı2;
        private string kullanıcıadı3;
        private string kullanıcıadı4;
        private string kullanıcıadı5;
        private string v;


        public Sifre(string name1, string name2, string name3, string name4, string name5,string v)
        {
            kullanıcıadı1 = name1;
            kullanıcıadı2 = name2;
            kullanıcıadı3 = name3;
            kullanıcıadı4 = name4;
            kullanıcıadı5 = name5;
        }

        public Sifre(string v)
        {
            this.v = v;
        }

        public void Bilgi()
        {



            Console.WriteLine("Kullanıcı Adı {0}", kullanıcıadı1);
            

        }
        private static string SifreOlusturma(int length = 8)
        {
              
            string Karakterler = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            Random random = new Random();

             
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = Karakterler[random.Next(Karakterler.Length)];
            }
            return new string(chars);
        }

    }
    internal class Program
    {



        static void Main(string[] args)

        {
            Console.WriteLine("Kullanıcı adı giriniz");
            Sifre name1 = new Sifre("");
            Sifre name2 = new Sifre("");
            Sifre name3 = new Sifre("");
            Sifre name4 = new Sifre("");
            Sifre name5 = new Sifre("");

            name1.Bilgi();
            name2.Bilgi();
            name3.Bilgi();
            name4.Bilgi();
            name5.Bilgi();
            


        }

    }
}
