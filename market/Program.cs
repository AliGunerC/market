using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //**************************** ÖDEV **********************//
            // Giriş alanında admin girişi yapılırsa ürün ve fiyat bilgileri girilsin
            // Giriş alanında member girişi 
            // dizi fiyat[7,3,2]yapılırsa 
            // dizi ürünler[Kola,bisküvi,çikolata]
            // Ürünler ekrana yazdırın. Müşteri ürün adını girerek ürün almak istesin. İstenilen ürün fiyatını ekrana yazdırarak kullanıcıdan para alın ve para üstünü verin
            int a = 4;
            int b = 0;
            string[] urunler = new string[a];
            double[] fiyatlar = new double[a];
            
            urunler[0] = "Bounty";
            urunler[1] = "Snickers";
            urunler[2] = "Doritos Cubun";
            fiyatlar[0] = 7;
            fiyatlar[1] = 3;
            fiyatlar[2] = 2;

            string personel_kimlik = "nurialco";


            Console.Write("1-)Personel Girişi  \n2-)Alışveriş Girişi \nSeçiminiz: ");
            string secim = Console.ReadLine();
            while (true) {
                 #region ADMİN GİRİŞİ
                if (secim == "1")
                {
                    int hak = 5;
                    while (hak > 0)
                    {






                        Console.Write("Lütfen personel kimliğinizi giriniz : ");
                        string girilen_kimlik = Console.ReadLine(); 
                        




                        if (girilen_kimlik == personel_kimlik)
                        {
                            while (true)
                            {
                                Console.Write(" 1-)Ürünleri gör \n 2-) Ürün ekle \n 3-)Ürün Güncelle \n Seçiminiz : ");
                                string secim_admin = Console.ReadLine();

                                if (secim_admin == "1")
                                {
                                    for (int i = 0; i < urunler.Length; i++)
                                    {
                                        Console.WriteLine(urunler[i] + " " + fiyatlar[i]);
                                    }
                                }
                                if (secim_admin == "2")
                                {


                                    Console.Write("eklemek istediğin ürün adını giriniz : ");
                                    string girilecek_urun = Console.ReadLine();
                                    Console.Write("ürünün fiyatını giriniz : ");
                                    int girilecek_urun_fiyat = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 3; i < urunler.Length; i++)
                                    {

                                        urunler[i] = girilecek_urun;
                                        fiyatlar[i] = girilecek_urun_fiyat;
                                        Console.WriteLine(urunler[i] + " " + fiyatlar[i]);
                                        a++;
                                    }





                                }
                                if (secim_admin == "3")
                                {
                                    Console.Write("Güncellemek istediğiniz ürün adını giriniz : ");
                                    string update = Console.ReadLine();




                                    if (urunler[b] != update)
                                    {
                                        Console.WriteLine("yok");
                                        b++;
                                    }
                                    else
                                    {
                                        int urunun_dizideki_yeri = Array.IndexOf(urunler, update);
                                        Console.Write("ürünün yeni adı ne olsun : ");
                                        string yeni_isim = Console.ReadLine();

                                        for (int i = 0; i < urunler.Length; i++)
                                        {
                                            urunler[urunun_dizideki_yeri] = yeni_isim;

                                            Console.WriteLine(urunler[i]);


                                        }




                                    }










                                }






                            }
                        }
                        else if (girilen_kimlik != personel_kimlik)
                        {
                            Console.WriteLine("hatalı giriş yaptınız");
                            hak-=1;
                            
                        }
                    }


                }
                #endregion


                if (secim == "2")
                {
                    
                    

                    while (true)
                    {
                        Console.Write("1-)Ürünleri Gör  \n2-)Kasa \nSeçiminiz: ");
                        string secim_al = Console.ReadLine();

                        if (secim_al == "1")
                        {
                            Console.WriteLine("********* MİGROURSA *********"); // MİGROSA CarrefourSA ve Migrosun kırması hocam.
                            for (int i = 0; i  < urunler.Length; i++)
                            {
                                Console.WriteLine(urunler[i] + " " + fiyatlar[i] + "TL" );
                            }
                            
                        }
                        if(secim_al == "2")
                        {
                            
                            Console.Write("kaç adet ürün almak istersin : ");
                            int adet = Convert.ToInt32(Console.ReadLine());
                            string[] almakistenilen = new string[adet+1];
                            for (int i = 0;i < adet; i++)
                            {
                                Console.WriteLine(i+1 + ". almak istedigin urun adı");
                                almakistenilen[i] = Console.ReadLine();
                                int j = Array.IndexOf(urunler , almakistenilen[i]);
                                if (almakistenilen[i] == urunler[j])
                                {
                                    Console.WriteLine("Almak istediğiniz ürün" + fiyatlar[j] + "TL");
                                    Console.WriteLine("Ödeme nasıl olucak?");
                                    Console.Write("1-) Nakit \n2-)Kredi Kartı\nSeçiminiz : ");
                                    string odeme_secim = Console.ReadLine();
                                    if (odeme_secim == "1")
                                    {
                                        Console.WriteLine("********* Nakit Ödeme *********");
                                        Console.Write("Kaç para verdiniz : ");
                                        int verilen_para = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("para üstünüz : " , verilen_para - fiyatlar[j]);
                                    }
                                    if (odeme_secim != "1" && odeme_secim != "2")
                                    {
                                        break;
                                    }
                                }
                                else if (almakistenilen[i] != urunler[j]) {
                                    Console.WriteLine("böyle bir ürün yok");
                                }
                            }
                        }
                        if(secim_al != "1" && secim_al != "2") { break; }


                    }



                }


























                if (secim != "1" && secim !="2")
                {
                    break;
                }
    



            }









            Console.ReadLine();
        }
    }
}
