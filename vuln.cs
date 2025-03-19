using Microsoft.AspNetCore.Mvc.RazorPages;

public class XssModel : PageModel
{
    public string KullaniciMesaji { get; set; }
    public string GosterilecekMesaj { get; set; }

    public void OnPost(string kullaniciMesaji)
    {
        KullaniciMesaji = kullaniciMesaji;
        // DİKKAT: Güvenli olmayan bir şekilde doğrudan HTML'e yazdırılıyor
        GosterilecekMesaj = KullaniciMesaji;
    }

    public void OnGet()
    {
        // Sayfa ilk yüklendiğinde varsayılan değer
        GosterilecekMesaj = "Bir mesaj girin.";
    }
}
