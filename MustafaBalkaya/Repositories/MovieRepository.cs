using MinimalJwt.Models;

namespace MinimalJwt.Repositories
{
    public class MovieRepository
    {
        public static List<Movie> Movies = new()
        {
            new() { Id = 1, Title = "Hababam Sınıfı Sınıfta Kaldı", Description = "Hababam Sınıfı( 6 edebiyat A) mezun olmadığı halde Mahmut hocayı hastanede mutlu edebilmek için sahte diplomalar hazırlamıştır. Fakat Mahmut hocanın okula dönüşüyle yasaklar yine başlar. Okula yeni gelen ve zor şartlar altında çalışmış olan Semra öğretmenden aşk mektubu aldığını zanneden Şaban ona cevap mektupları gönderir fakat daha sonra okulda işler iyice karışacaktır.", Rating = 6.8 },
            new() { Id = 2, Title = "Babam ve Oğlum", Description = "1980 darbesinde annesini kaybeden küçük Deniz (babası o dönemde bir çok erkek çocuğa verilen ismi koymuş) yedi yıl sonra hiç görmediği dedesinin Ege’deki çiftliğine doğru bir yolculuğa çıkar. Deniz’in dedesini hiç görmemesinin nedeni dedesiyle babasının yıllardır küs oluşudur. Hüseyin Efendi (Çetin Tekindor)okumaya diye gönderdiği oğlunun politik olaylara karıştığını öğrenince onu evlatlıktan silmiştir", Rating = 8.2 },
            new() { Id = 3, Title = "G.O.R.A.", Description = "Anadolu’nun turistik kentlerinden birinde tüccarlık yapan Arif uzaylılar tarafından kaçırılarak G.O.R.A adlı gezegene götürülür. Arif, gezegenden kaçmak için uğraşır. Bunun için de uzaylı Komutan Logar’a karşı mücadele vermesi gerekir. Bu mücadele esnasında gezegenin kralının kızı olan Ceku'ya aşık olan Arif, G.O.R.A'da tanıştığı dostlarının da yardımıyla Logar'ı alt etmeye çalışır.\n", Rating = 6.6 },
            new() { Id = 4, Title = "Organize İşler", Description = "İstanbul'da oto hırsızlığı yapmakta olan bir çetenin reisi bir kovalamaca sırasında intihar etmek üzere olan birinin evine sığınır. Hayatını kurtardığına inandığı bu kişiye iş vermek ve hırsızlığa teşvik etmek ister. Yaptığının büyük bir hata olduğunu kısa sürede anlayacaktır.", Rating = 6.4 },
            new() { Id = 5, Title = "İncir Reçeli", Description = "Metin 30’lu yaşlarında hayatını TV’lere skeç yazarak kazanan bir adamdır. Yazdığı senaryoları reddedilen bir gün gittiği barda, hayatını tümüyle değiştiren Duygu’yla tanışır. Duygu ve Metin bir masala başlarlar ama sonu başından belli bir masaldır bu...", Rating = 7.4 },
        };
    }
}
