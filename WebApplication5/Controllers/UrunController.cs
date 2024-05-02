using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace MVCViewModelExample.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            Urun urun1 = new();
            urun1.Id = 1;
            urun1.Ad = "Samsung 19 Inch Led Monitor ";
            urun1.Kategori = "Monitörler";
            urun1.Stok = 100;
            urun1.Fiyat = 3299;

            Urun urun2 = new Urun()
            {
                Id = 2,
                Ad = "Lg 21 Inch Led Monitor",
                Kategori = "Monitorler",
                Stok = 100,
                Fiyat = 4399
            };
            List<Urun> urunListesi = new List<Urun>();
            urunListesi.Add(urun1);
            urunListesi.Add(urun2);

            return View(urunListesi);
        }

        public IActionResult IndexVM()
        {
            Urun urun1 = new();
            urun1.Id = 1;
            urun1.Ad = "Samsung 19 Inch Led Monitor ";
            urun1.Kategori = "Monitörler";
            urun1.Stok = 100;
            urun1.Fiyat = 3299;
            Urun urun2 = new Urun()
            {
                Id = 2,
                Ad = "Lg 21 Inch Led Monitor",
                Kategori = "Monitorler",
                Stok = 100,
                Fiyat = 4399
            };
            //Asagidaki adimlarda Urun sinifindaki nesne UrunVM sinifindaki nesneye map'leniyor. Bu islemi otomatiklestirmek icin AutoMapper gibi paketler kullaniliyor.
            UrunVM urunVM1 = new UrunVM();
            urunVM1.Ad = urun1.Ad;
            urunVM1.Fiyat = urun1.Fiyat;
            urunVM1.Stok = urun1.Stok;

            UrunVM urunVM2 = new UrunVM();
            urunVM2.Ad = urun2.Ad;
            urunVM2.Fiyat = urun2.Fiyat;
            urunVM2.Stok = urun2.Stok;

            List<UrunVM> urunVMListesi = new List<UrunVM>();
            urunVMListesi.Add(urunVM1);
            urunVMListesi.Add(urunVM2);

            return View(urunVMListesi);
        }
    }
}