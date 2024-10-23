
public class Sabit
{


    // Const değeri : bir kere başlangıç değeri aldığı zaman
    // tekrardan değer verilemez bir tiptir.!!!    
    public const string Username = "wissenbesiktaş";


    // bir conts değişken tanımlıyorsanız, başlangıç değeri vermek zorundasınız, Eğer vermezseniz derleme zamanı hatası alırsınız
    // Conts değişkenlere, derleme aşamasında değer vermemiz gerekir.!!
    // const değişkene değer vermedik ve hata aldık!!
    //public const string Password;


    //ReadOnly keyword'ü!!
     


    //ReadOnly değişken tanımlama aşağıdaki gibidir.!!!
    // Readonly adından da anlaşılabileceği gibi, bir sabit değerdir ve üstüne yazma işlemi gerçekleşmez
    //sadece okuma işlemi yapabileceğinizden ötürü bir sabittir.!!

    // Conts ile arasındaki en önemli fark, conts derleme aşamasında değer verilmesini zorunlu tutarken, 
    //read only değişkene çalışma zamanında da değer verilebilir!!

    // aşağıda değer vermeden oluşturulan bir readonly değişkenini görüyorsunuz!!!
    public Sabit(string firmaAdi)
    {
        // readonly bir sabite nesne üzerinden değer atanamaz!!
        // nesne kullanıcısı tarafından değer atanmak istenirse, ctor kullanılarak değer ataması gerçekletirilebilir!!
        this.FirmaAdi = firmaAdi;
    }
        public readonly string FirmaAdi;

    //public string Password ="1010";



    // 500
    // döviz kodu : 848 : Dolar 
    // 500 Tl çek 
    // kargoyu çık
    /*  if(eÖdeme ok ise){




    }*/

}