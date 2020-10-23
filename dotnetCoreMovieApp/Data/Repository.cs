using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCoreMovieApp.Models
{
    public static class Repository
    {
        private static List<Movie> _movies = null;
        static Repository()
        {
            _movies = new List<Movie>()
            {
                new Movie(){Id=1,Name="Başlangıç (Inception)",ShortDesc="Inception",Description="<p>Kısa sürede unutulmaz efsane filmler arasında yer almayı başarmış bir diğer Oscar ödüllü Christopher Nolan filmiyle listemize devam ediyoruz. Başlangıç (Inception) adıyla karşımıza gelen bu inanılmaz film de gizem ve bilim kurgu türünün en etkileyici örneklerinden biri olarak hayranlık uyandırıyor. Aynı zamanda zengin oyuncu kadrosuyla da merak uyandırmayı başaran Başlangıç, son 10 yılın en iyi filmleri arasına da adını yazdırıyor.</p>",
                    ImageUrl ="2.jpg",CategoryId=1},
                new Movie(){Id=2,Name="Yaralı Yüz (Scarface)",ShortDesc="Scarface",Description="<p>“I’m Tony Montana” repliğinin geçtiği sahne, sinema dünyasında gelmiş geçmiş en simgesel anlardan biri olmuştur. Al Pacino’nun kalitesini konuşturduğu Yaralı Yüz (Scarface), halen daha hayranlıkla izlediğimiz filmlerden bir tanesidir.</p>",
                    ImageUrl ="8.jpg",CategoryId=3},
                new Movie(){Id=3,Name="3 Aptal (3 Idiot)",ShortDesc="3 Idiot",Description="<p>Aamir Khan, Sharman Joshi, Kareena Kapoor, Boman Irani ve R. Madhavan’ın başrollerini paylaşmış oldukları 3 Idiots, en iyilerin yer aldıkları her listeye dahil olması gereken yapımlardan bir tanesidir. Müzikleriyle de hayranlık uyandıran 3 Idiots, son 20 yılın unutulmaz  filmleri arasına da adını yazdırıyor.</p>",
                    ImageUrl ="3.jpg",CategoryId=2},
                new Movie(){Id=4,Name="Piyanist (The Pianist)",ShortDesc="The Pianist",Description="<p>Bizleri gözyaşlarına boğan bir başka başyapıtla daha listemize devam ediyoruz. Piyanist (The Pianist) adıyla 2002 yılında vizyona giren bu başyapıt, yakın tarihin çarpıcı gerçeklerini gözler önüne seriyor. Fransa, Almanya ve Polonya ortak yapımı bir film olarak karşımıza gelen Roman Polanski filmi Piyanist, Adrien Brody’nin de büyüleyici performansıyla da hayranlık uyandırıyor.</p>",
                    ImageUrl ="7.jpg",CategoryId=4},
                new Movie(){Id=5,Name="Gladyatör (Gladiator)",ShortDesc="Gladiator",Description="<p>Oscar ödüllü bir Ridley Scott filmi olan 2000 yapımı Gladyatör (Gladiator), Russell Crowe’un efsaneleştiği başyapıtlardan bir tanesidir. Ayrıca Joaquin Phoenix ve Connie Nielsen’in de etkileyici performanslarıyla da büyüleyici bir yapım haline gelen Gladyatör de en unutulmaz filmler arasında yer alıyor.</p>",
                    ImageUrl ="5.jpg",CategoryId=2},
                new Movie(){Id=6,Name="Kara Şövalye (Dark Knight)",ShortDesc="Dark Knight",Description="<p>Son 10 yılın en başarılı yönetmenlerinden biri olan Christopher Nolan birbirinden etkileyici filmleri izleyicilerle buluşturmaya devam ediyor. Oscar ödüllü bir süper kahraman filmi olan Kara Şövalye (Dark Knight); Christian Bale ve Gary Oldman gibi başarılı isimlerin yanı sıra Heath Ledger’in büyüleyici Joker performansıyla da unutulmaz efsane filmler arasında yer almayı başarıyor.</p>",
                    ImageUrl ="6.jpg",CategoryId=1},
                new Movie(){Id=7,Name="Baba (The Godfather) Serisi",ShortDesc="The Godfather",Description="</p>Francis Ford Coppola’nın en başarılı filmlerinden olan Baba (The Godfather) Serisi, telefonlara ve hatta kornalara bile uyarlanan müziğiyle de efsaneleşmeyi başarmıştı. Marlon Brando, Al Pacino, Robert Duvall, James Caan ve Diane Keaton gibi usta isimlerin yer aldığı oyuncu kadrosuyla da unutulmaz filmler arasına adını yazdırmıştır.</p>",
                    ImageUrl ="1.jpg",CategoryId=1}
            };
        }

        public static List<Movie> Movies {
            get {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(x => x.Id == id);
        }
    }
}
