using BandsApp.Web.Models;

namespace BandsApp.Web.Services;

public class BandService
{

    List<Band> bands =
        [
        new Band { 
            Id = 1, 
            Name = "Led Zeppelin", 
            Description = "Led Zeppelin var ett brittiskt rockband som bildades 1968 och räknas som ett av de mest inflytelserika banden inom rock och hårdrock. Bandet bestod av Robert Plant, Jimmy Page, John Paul Jones och John Bonham. De är kända för sin kraftfulla blandning av blues, rock och psykedeliska influenser, samt för låtar som Stairway to Heaven, Whole Lotta Love och Kashmir. Led Zeppelin hade stort inflytande på utvecklingen av hårdrocken och deras musik fortsätter att inspirera musiker världen över.",
            YoutubeUrl = "https://www.youtube.com/embed/K4x6T0LB5aE?si=ddR1jx6ZlyYaUzWH"
        },
        new Band { 
            Id = 2, 
            Name = "Black Sabbath", 
            Description = "Black Sabbath bildades i Birmingham, England, 1968 och brukar ofta beskrivas som ett av banden som lade grunden för heavy metal. Med Tony Iommis tunga gitarriff, Geezer Butlers mörka texter, Bill Wards kraftfulla trummor och Ozzy Osbournes karakteristiska sång skapade bandet ett mörkare och tyngre sound än mycket av den samtida rockmusiken. Album som Paranoid, Master of Reality och Black Sabbath har blivit klassiker inom genren. Bandets stil har haft enorm betydelse för utvecklingen av heavy metal.",
            YoutubeUrl = "https://www.youtube.com/embed/BOTIIw76qiE?si=JHKsQSXD_-9z0DLc"
        },
        new Band { Id = 3, Name = "Iron Maiden", 
            Description = "Iron Maiden är ett brittiskt heavy metal-band som bildades i London 1975 av basisten Steve Harris. Bandet blev en central del av den så kallade New Wave of British Heavy Metal under slutet av 1970-talet och början av 1980-talet. De är kända för sina melodiska gitarrsolon, energiska liveframträdanden och episka låtar med historiska och litterära teman. Bland deras mest kända låtar finns The Trooper, Run to the Hills och Fear of the Dark. Bandets maskot Eddie har dessutom blivit en ikonisk symbol inom heavy metal.",
            YoutubeUrl = "https://www.youtube.com/embed/p32b5nNq1zw?si=QENAJe7eEt7cb1da"
        }
        ];

    public Band GetBandById(int id)
    {
        return bands.First(b => b.Id == id); 
    }

    public Band[] GetAll()
    {
        return bands.OrderBy(b => b.Id).ToArray();
    }
}
