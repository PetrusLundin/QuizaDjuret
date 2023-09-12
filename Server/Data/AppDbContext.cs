using Microsoft.EntityFrameworkCore;
using QuizaDjuret.Shared;
using static System.Net.WebRequestMethods;

namespace QuizaDjuret.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<UserModel> Highscore { get; set; }
        public DbSet<AnswerModel> Answers { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder); -klassiker -Gabriel 2k23
            modelBuilder.Entity<QuestionModel>().HasMany(u => u.Answers).WithOne(r => r.Question).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<QuestionModel>().HasData(
                new QuestionModel
                {
                    QuestionId = 1,
                    Text = "Gissa djuret",
                    CorrectAnswerId = 1,
                    Hint = "Vanligt husdjur och människans bästavän",
                    FunFact = "Hundar är en av de äldsta tamdjursarterna och har funnits som människans följeslagare i över 15 000 år.",
                    MediaURL = "https://i.imgur.com/E1yr3A4.jpg",
					DifficultyLevel = 1
                },
				new QuestionModel
				{
					QuestionId = 2,
					Text = "Gissa djuret",
					CorrectAnswerId = 4,
					Hint = "Har en av de längsta nackarna i djurriket",
					FunFact = "Giraffer har faktiskt samma antal halskotor som människor, det vill säga sju, men varje halskota är enormt stor och kan vara upp till 2,5 meter lång!",
					MediaURL = "https://i.imgur.com/HTwzNY0.jpg",
					DifficultyLevel = 1
				},
	            new QuestionModel
	            {
		            QuestionId = 3,
		            Text = "Gissa djuret",
		            CorrectAnswerId = 7,
		            Hint = "Har en karakteristisk pung för att bära sina ungar i",
		            FunFact = "Kängurur kan inte hoppa bakåt på grund av deras stora svansar, så om de försöker gå bakåt kommer de snubbla istället!",
		            MediaURL = "https://i.imgur.com/yowTeLd.jpg",
		            DifficultyLevel = 1
	            },
				new QuestionModel
				{
					QuestionId = 4,
					Text = "Gissa djuret",
					CorrectAnswerId = 10,
					Hint = "Känd för att vara 'kungen av djungeln'",
					FunFact = "Lejon har en imponerande man som inte bara gör dem majestätiska utan också skyddar deras hals mot attacker från andra djur.",
					MediaURL = "https://i.imgur.com/qYLjY7V.jpg",
					DifficultyLevel = 1
				},
				 new QuestionModel
				 {
					 QuestionId = 5,
					 Text = "Gissa djuret",
					 CorrectAnswerId = 13,
					 Hint = "Lever i Kina och äter mestadels bambu",
					 FunFact = "Pandors avtryck i snön kan vara så lika en människas fotspår att det har lett till myter om \"människo-pandor\" i Kina!",
					 MediaURL = "https://i.imgur.com/3AhigqN.jpg",
					 DifficultyLevel = 1
				 },
				new QuestionModel
				{
					QuestionId = 6,
					Text = "Gissa djuret",
					CorrectAnswerId = 16,
					Hint = "Lever i haven och är utmärkta simmare",
					FunFact = "Delfiner har faktiskt namn och svarar på sina egna namn när de kallas, precis som husdjur!",
					MediaURL = "https://i.imgur.com/sCZLvlk.jpg",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 7,
					Text = "Gissa djuret",
					CorrectAnswerId = 19,
					Hint = "Symbol för styrka och frihet",
					FunFact = "En örn kan ha en vingspann på upp till 2,5 meter, vilket är större än de flesta människors höjd!",
					MediaURL = "https://i.imgur.com/KJdADuA.jpg",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 8,
					Text = "Gissa djuret",
					CorrectAnswerId = 22,
					Hint = "Lever nära vatten och har en kompakt kroppsform med korta ben",
					FunFact = "Flodhästar simmar väldigt sällan, de rör sig i stället genom att studsande gå längs botten av floder och sjöar med fötterna!",
					MediaURL = "https://i.imgur.com/YCm4pG8.jpg",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 9,
					Text = "Gissa djuret",
					CorrectAnswerId = 25,
					Hint = "Lever på en diet som främst består av eukalyptusblad",
					FunFact = "Koalor sover upp till 20 timmar per dyng",
					MediaURL = "https://i.imgur.com/54Ef30u.jpg",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 10,
					Text = "Gissa djuret",
					CorrectAnswerId = 28,
                    Hint = "Finns i Afrika och är känd för sin långa hals",
                    FunFact = "Strutsar kan sticka huvudet i sanden när de känner sig hotade i tron om att de är gömda",
                    MediaURL = "https://i.imgur.com/K6ZkhNV.jpg",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 11,
					Text = "Gissa del av djuret",
					CorrectAnswerId = 31,
					Hint = "Känd för sitt slitsamma arbete att samla mat",
					FunFact = "Myror kan bli \"lata\" ibland och skaffa sig husdjur, som bladlöss, för att mjölka dem på honungsdagg, vilket sparar myrornas egna ansträngningar!",
					MediaURL = "https://i.imgur.com/qSCH06v.png",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 12,
					Text = "Gissa del av djuret",
					CorrectAnswerId = 34,
					Hint = "Lever ofta i närheten av kusten och äter fisk",
					FunFact = "Sälar kan ha powernaps under vattnet som varar i upp till 15 minuter utan att behöva komma upp till ytan för att andas.",
					MediaURL = "https://i.imgur.com/A31vC3i.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 13,
					Text = "Gissa del av djuret",
					CorrectAnswerId = 37,
					Hint = "Lever ofta i våtmarker och har ett karakteristiskt trumpetande ljud",
					FunFact = "När tranor flyger formar de ett V-liknande mönster, tranan längst fram styr vägen framåt",
					MediaURL = "https://i.imgur.com/hugB42z.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 14,
					Text = "Gissa del av djuret",
					CorrectAnswerId = 40,
					Hint = "Kan vara hårig eller naken, beroende på ras",
					FunFact = "Hamstrar har kindpåsar som de kan lagra mat i, och de kan fylla dessa påsar med mat så mycket som dubbel sin kroppsvikt!",
					MediaURL = "https://i.imgur.com/9tB3vyX.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 15,
					Text = "Gissa del av djuret",
					CorrectAnswerId = 43,
					Hint = "Lever i Afrika och är en skicklig jägare",
					FunFact = "Geparder är de snabbaste landdjuren i världen, men de har faktiskt ett mycket blygsamt temperament och kan ibland förlora sina byten till mer aggressiva rovdjur.",
					MediaURL = "https://i.imgur.com/R8l5ZXt.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 16,
					Text = "Gissa del av djuret",
					CorrectAnswerId = 46,
					Hint = "Kan vara grå, brun eller svart",
					FunFact = "Råttor har utmärkt nattsyn och kan se i totalt mörker, men de lider av färgblindhet och ser världen i svartvitt.",
					MediaURL = "https://i.imgur.com/LjvmNvY.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 17,
					Text = "Gissa del av djuret",
					CorrectAnswerId = 49,
					Hint = "Kan vara röd, blå, grön eller gul",
					FunFact = "Papergojor har en fantastisk förmåga att efterlikna ljud, och vissa arter kan låta som allt från fågelkvitter till surrande insekter.",
					MediaURL = "https://i.imgur.com/JnNOgpJ.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 18,
					Text = "Gissa del av djuret",
					CorrectAnswerId = 52,
					Hint = "Gör honung och bor i bikupor",
					FunFact = "Bina har faktiskt en liten \"mustasch\" under sina huvuden som hjälper dem att känna av blommornas form och färg när de samlar nektar!",
					MediaURL = "https://i.imgur.com/c7qukSG.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 19,
					Text = "Gissa del av djuret",
					CorrectAnswerId = 55,
					Hint = "Lever i regnskogen och gillar bananer",
					FunFact = "Orangutanger delar omkring 97 % av sin DNA med människor",
					MediaURL = "https://i.imgur.com/USujWHm.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 20,
					Text = "Gissa del av djuret",
					CorrectAnswerId = 58,
					Hint = "Har en karakteristisk sång under natten",
					FunFact = "Vissa grodor har en unik förmåga att ändra färg beroende på sin omgivning, och de kan till och med bli blåa när de är nervösa!",
					MediaURL = "https://i.imgur.com/V6sg2vK.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 21,
					Text = "Gissa ljudet",
					CorrectAnswerId = 61,
					Hint = "Lever ofta i närheten av kusten och äter fisk",
					FunFact = "Sälar kallas ibland för \"vattenhundar\" eftersom de kan vara lika lekfulla och nyfikna som hundar när de simmar i vattnet.",
					MediaURL =  "Säl.mp3",
					DifficultyLevel = 3
				},
				new QuestionModel
				{
					QuestionId = 22,
					Text = "Gissa ljudet",
					CorrectAnswerId = 64,
					Hint = "Känd för att vara 'kungen av djungeln'",
					FunFact = "Lejon kan vara riktigt lata och sova upp till 20 timmar om dagen, vilket gör dem till några av de mest avslappnade stora kattdjuren på savannen!",
					MediaURL = "Lejon.mp3",
					DifficultyLevel = 3
				},
				new QuestionModel
				{
					QuestionId = 23,
					Text = "Gissa ljudet",
					CorrectAnswerId = 67,
					Hint = "Lever i havet och är en utmärkt simmare",
					FunFact = "Delfiner älskar lek och humor så mycket att de ibland skapar sina egna \"vattenringar\" och sedan leka med dem som om de vore leksaker!",
					MediaURL = "Delfin.mp3",
					DifficultyLevel = 3
				},
				new QuestionModel
				{
					QuestionId = 24,
					Text = "Gissa ljudet",
					CorrectAnswerId = 70,
					Hint = "Ofta används för ridning och dragarbete",
					FunFact = "Hästar kan inte kräkas, vilket betyder att de måste vara försiktiga med vad de äter eftersom de inte kan bli av med oönskad mat på samma sätt som människor.",
					MediaURL = "Häst.mp3",
					DifficultyLevel = 3
				},
				new QuestionModel
				{
					QuestionId = 25,
					Text = "Gissa ljudet",
					CorrectAnswerId = 73,
					Hint = "Vanligt husdjur och människans bästavän",
					FunFact = "Hundar kan känna av människors känslor och är faktiskt kapabla att skilja på olika humör i människors ansiktsuttryck.",
					MediaURL = "Hund.mp3",
					DifficultyLevel = 3
				},
				new QuestionModel
				{
					QuestionId = 26,
					Text = "Gissa ljudet",
					CorrectAnswerId = 76,
					Hint = "Är känd för att jaga möss och andra smådjur",
					FunFact = "Katter kan göra upp till 100 olika ljud, medan hundar bara kan göra omkring 10.",
					MediaURL = "Katt.mp3",
					DifficultyLevel = 3
				},
				new QuestionModel
				{
					QuestionId = 27,
					Text = "Gissa ljudet",
					CorrectAnswerId = 79,
					Hint = "Symbol för styrka och frihet",
					FunFact = "Örnar har så bra syn att om du skulle ta en tidning och hålla den upp i luften, skulle en örn kunna läsa rubrikerna från en halv mils avstånd!",
					MediaURL = "Örn.mp3",
					DifficultyLevel = 3
				},
				new QuestionModel
				{
					QuestionId = 28,
					Text = "Gissa ljudet",
					CorrectAnswerId = 82,
					Hint = "Kan vara röd, blå, grön eller gul",
					FunFact = "Papergojor har faktiskt funnits i över 2 000 år och användes ursprungligen i Kina för att skicka meddelanden inom militären.",
					MediaURL = "Papegoja.mp3",
					DifficultyLevel = 3
				},
				new QuestionModel
				{
					QuestionId = 29,
					Text = "Gissa ljudet",
					CorrectAnswerId = 85,
					Hint = "Lever ofta i våtmarker och har ett karakteristiskt trumpetande ljud",
					FunFact = "Tranor är kända för sina melodiska och uttrycksfulla sånger, och de använder dessa sånger för att prata med varandra.",
					MediaURL = "Trana.mp3",
					DifficultyLevel = 3
				},
				new QuestionModel
				{
					QuestionId = 30,
					Text = "Gissa ljudet",
					CorrectAnswerId = 88,
					Hint = "Kan vara hårig eller naken, beroende på ras",
					FunFact = "Hamstrar är kända för sin imponerande uppsättning tänder, och deras framtänder växer hela livet.",
					MediaURL = "Hamster.mp3",
					DifficultyLevel = 3
				},
				new QuestionModel
				{
					QuestionId = 31,
					Text = "Ett långhalsat djur med fläckig päls",
					CorrectAnswerId = 91,
					Hint = "Har en av de längsta nackarna i djurriket",
					FunFact = "Giraffer har det högsta blodtrycken bland alla landlevande djur, vilket hjälper dem att pumpa blod upp genom sin långa hals och vidare till hjärnan",
					MediaURL = "",
					DifficultyLevel = 4
				},
				new QuestionModel
				{
					QuestionId = 32,
					Text = "Ett pungdjur från Australien som hoppar på sina bakben",
					CorrectAnswerId = 94,
					Hint = "Har en karakteristisk pung för att bära sina ungar i",
					FunFact = "Känguruer är kända för sin \"kängurupåse\" där de bär sina ungar, men de kan faktiskt kontrollera musklerna i påsen för att öppna och stänga den vid behov.",
					MediaURL = "",
					DifficultyLevel = 4
				},
				new QuestionModel
				{
					QuestionId = 33,
					Text = "En björnart med svartvita markeringar",
					CorrectAnswerId = 97,
					Hint = "Lever i Kina och äter mestadels bambu",
					FunFact = "Pandor äter upp till 40 kilo bambu per dag.",
					MediaURL = "",
					DifficultyLevel = 4
				},
				new QuestionModel
				{
					QuestionId = 34,
					Text = "Ett stort, tungt djur som lever i vattnet",
					CorrectAnswerId = 100,
					Hint = "Även om de är kraftiga simmare, befinner de sig oftast på land",
					FunFact = "Flodhästar är att de har en förmåga att \"svettas\" en rödaktig vätska som fungerar som ett naturligt solskydd.",
					MediaURL = "",
					DifficultyLevel = 4
				},
				new QuestionModel
				{
					QuestionId = 35,
					Text = "En stor gräsätande fågel som inte kan flyga",
					CorrectAnswerId = 103,
					Hint = "Finns i Afrika och är känd för sin långa hals",
					FunFact = "Strutsarnas ögon är faktiskt större än deras hjärna!",
					MediaURL = "",
					DifficultyLevel = 4
				},
				new QuestionModel
				{
					QuestionId = 36,
					Text = "En liten insekt som ofta arbetar i kolonier",
					CorrectAnswerId = 106,
					Hint = "Känd för sitt arbete att samla mat",
					FunFact = "Myror är så starka i förhållande till sin storlek att, om de var lika stora som människor skulle de kunna lyfta bilar!",
					MediaURL = "",
					DifficultyLevel = 4
				},
				new QuestionModel
				{
					QuestionId = 37,
					Text = "Ett marint däggdjur med kraftiga morrhår",
					CorrectAnswerId = 109,
					Hint = "Lever ofta i närheten av kusten och äter fisk",
					FunFact = "Sälar har utvecklat en speciell förmåga att hålla andan under vatten och kan göra det i upp till två timmar i sträck när de dyker efter föda!",
					MediaURL = "",
					DifficultyLevel = 4
				},
				new QuestionModel
				{
					QuestionId = 38,
					Text = "En liten gnagare som ofta ses i burar som husdjur",
					CorrectAnswerId = 112,
					Hint = "Kan vara hårig eller naken, beroende på ras",
					FunFact = "Hamstrar kan springa upp till 13 kilometer på en natt i sina hjul, vilket gör dem till små maratonlöpare!",
					MediaURL = "",
					DifficultyLevel = 4
				},
				new QuestionModel
				{
					QuestionId = 39,
					Text = "Ett snabbt och smidigt djur som ofta förekommer i städer",
					CorrectAnswerId = 115,
					Hint = "Kan vara grå, brun eller svart",
					FunFact = "Råttor är extremt sociala djur och kan bli ensamma och deprimerade om de inte har sällskap av andra råttor.",
					MediaURL = "",
					DifficultyLevel = 4
				},
				new QuestionModel
				{
					QuestionId = 40,
					Text = "En färgglad fågel som ofta kan härma mänskliga ljud",
					CorrectAnswerId = 118,
					Hint = "Kan vara röd, blå, grön eller gul",
					FunFact = "Papergojor kan nå imponerande höjder och har rekord på över 30 000 meter, vilket är högre än de flesta flygplan flyger!",
					MediaURL = "",
					DifficultyLevel = 4
				}
			);

            modelBuilder.Entity<AnswerModel>().HasData(
                new AnswerModel { AnswerId = 1, QuestionId = 1, IsCorrect = true, Text = "Hund" },
                new AnswerModel { AnswerId = 2, QuestionId = 1, IsCorrect = false, Text = "Katt" },
                new AnswerModel { AnswerId = 3, QuestionId = 1, IsCorrect = false, Text = "Leopard" },

				new AnswerModel { AnswerId = 4, QuestionId = 2, IsCorrect = true, Text = "Giraff" },
				new AnswerModel { AnswerId = 5, QuestionId = 2, IsCorrect = false, Text = "Zebra" },
				new AnswerModel { AnswerId = 6, QuestionId = 2, IsCorrect = false, Text = "Koala" },

				new AnswerModel { AnswerId = 7, QuestionId = 3, IsCorrect = true, Text = "Känguru" },
				new AnswerModel { AnswerId = 8, QuestionId = 3, IsCorrect = false, Text = "Lejon" },
				new AnswerModel { AnswerId = 9, QuestionId = 3, IsCorrect = false, Text = "Koala" },

				new AnswerModel { AnswerId = 10, QuestionId = 4, IsCorrect = true, Text = "Lejon" },
				new AnswerModel { AnswerId = 11, QuestionId = 4, IsCorrect = false, Text = "Tiger" },
				new AnswerModel { AnswerId = 12, QuestionId = 4, IsCorrect = false, Text = "Panter" },

				new AnswerModel { AnswerId = 13, QuestionId = 5, IsCorrect = true, Text = "Panda" },
				new AnswerModel { AnswerId = 14, QuestionId = 5, IsCorrect = false, Text = "Koala" },
				new AnswerModel { AnswerId = 15, QuestionId = 5, IsCorrect = false, Text = "Isbjörn" },
				
				new AnswerModel { AnswerId = 16, QuestionId = 6, IsCorrect = true, Text = "Delfin" },
				new AnswerModel { AnswerId = 17, QuestionId = 6, IsCorrect = false, Text = "Val" },
				new AnswerModel { AnswerId = 18, QuestionId = 6, IsCorrect = false, Text = "Säl" },

				new AnswerModel { AnswerId = 19, QuestionId = 7, IsCorrect = true, Text = "Örn" },
				new AnswerModel { AnswerId = 20, QuestionId = 7, IsCorrect = false, Text = "Falk" },
				new AnswerModel { AnswerId = 21, QuestionId = 7, IsCorrect = false, Text = "Kondor" },

				new AnswerModel { AnswerId = 22, QuestionId = 8, IsCorrect = true, Text = "Flodhäst" },
				new AnswerModel { AnswerId = 23, QuestionId = 8, IsCorrect = false, Text = "Havssköldpadda" },
				new AnswerModel { AnswerId = 24, QuestionId = 8, IsCorrect = false, Text = "Val" },

				new AnswerModel { AnswerId = 25, QuestionId = 9, IsCorrect = false, Text = "Känguru" },
				new AnswerModel { AnswerId = 26, QuestionId = 9, IsCorrect = false, Text = "Echidna" },
				new AnswerModel { AnswerId = 27, QuestionId = 9, IsCorrect = true, Text = "Koala" },

				new AnswerModel { AnswerId = 28, QuestionId = 10, IsCorrect = true, Text = "Struts" },
				new AnswerModel { AnswerId = 29, QuestionId = 10, IsCorrect = false, Text = "Emu" },
				new AnswerModel { AnswerId = 30, QuestionId = 10, IsCorrect = false, Text = "Pelikan" },
				
				new AnswerModel { AnswerId = 31, QuestionId = 11, IsCorrect = true, Text = "Myra" },
				new AnswerModel { AnswerId = 32, QuestionId = 11, IsCorrect = false, Text = "Fjäril" },
				new AnswerModel { AnswerId = 33, QuestionId = 11, IsCorrect = false, Text = "Larv" },

				new AnswerModel { AnswerId = 34, QuestionId = 12, IsCorrect = true, Text = "Säl" },
				new AnswerModel { AnswerId = 35, QuestionId = 12, IsCorrect = false, Text = "Delfin" },
				new AnswerModel { AnswerId = 36, QuestionId = 12, IsCorrect = false, Text = "Späckhuggare" },

				new AnswerModel { AnswerId = 37, QuestionId = 13, IsCorrect = true, Text = "Tran" },
				new AnswerModel { AnswerId = 38, QuestionId = 13, IsCorrect = false, Text = "Stork" },
				new AnswerModel { AnswerId = 39, QuestionId = 13, IsCorrect = false, Text = "Flamingo" },

				new AnswerModel { AnswerId = 40, QuestionId = 14, IsCorrect = true, Text = "Hamster" },
				new AnswerModel { AnswerId = 41, QuestionId = 14, IsCorrect = false, Text = "Marsvin" },
				new AnswerModel { AnswerId = 42, QuestionId = 14, IsCorrect = false, Text = "Kanin" },

				new AnswerModel { AnswerId = 43, QuestionId = 15, IsCorrect = true, Text = "Gepard" },
				new AnswerModel { AnswerId = 44, QuestionId = 15, IsCorrect = false, Text = "Tiger" },
				new AnswerModel { AnswerId = 45, QuestionId = 15, IsCorrect = false, Text = "Lejon" },

				new AnswerModel { AnswerId = 46, QuestionId = 16, IsCorrect = true, Text = "Råtta" },
				new AnswerModel { AnswerId = 47, QuestionId = 16, IsCorrect = false, Text = "Ekorre" },
				new AnswerModel { AnswerId = 48, QuestionId = 16, IsCorrect = false, Text = "Igelkott" },

				new AnswerModel { AnswerId = 49, QuestionId = 17, IsCorrect = true, Text = "Papegoja" },
				new AnswerModel { AnswerId = 50, QuestionId = 17, IsCorrect = false, Text = "Kolibri" },
				new AnswerModel { AnswerId = 51, QuestionId = 17, IsCorrect = false, Text = "Pippifågel" },

				new AnswerModel { AnswerId = 52, QuestionId = 18, IsCorrect = true, Text = "Bi" },
				new AnswerModel { AnswerId = 53, QuestionId = 18, IsCorrect = false, Text = "Fjäril" },
				new AnswerModel { AnswerId = 54, QuestionId = 18, IsCorrect = false, Text = "Fluga" },

				new AnswerModel { AnswerId = 55, QuestionId = 19, IsCorrect = true, Text = "Orangutang" },
				new AnswerModel { AnswerId = 56, QuestionId = 19, IsCorrect = false, Text = "Gorilla" },
				new AnswerModel { AnswerId = 57, QuestionId = 19, IsCorrect = false, Text = "Schimpans" },

				new AnswerModel { AnswerId = 58, QuestionId = 20, IsCorrect = true, Text = "Groda" },
				new AnswerModel { AnswerId = 59, QuestionId = 20, IsCorrect = false, Text = "Ödla" },
				new AnswerModel { AnswerId = 60, QuestionId = 20, IsCorrect = false, Text = "Salmander" },

				new AnswerModel { AnswerId = 61, QuestionId = 21, IsCorrect = true, Text = "Säl" },
				new AnswerModel { AnswerId = 62, QuestionId = 21, IsCorrect = false, Text = "Späckhuggare" },
				new AnswerModel { AnswerId = 63, QuestionId = 21, IsCorrect = false, Text = "Haj" },

				new AnswerModel { AnswerId = 64, QuestionId = 22, IsCorrect = true, Text = "Lejon" },
				new AnswerModel { AnswerId = 65, QuestionId = 22, IsCorrect = false, Text = "Tiger" },
				new AnswerModel { AnswerId = 66, QuestionId = 22, IsCorrect = false, Text = "Puma" },

				new AnswerModel { AnswerId = 67, QuestionId = 23, IsCorrect = true, Text = "Delfin" },
				new AnswerModel { AnswerId = 68, QuestionId = 23, IsCorrect = false, Text = "Val" },
				new AnswerModel { AnswerId = 69, QuestionId = 23, IsCorrect = false, Text = "Säl" },

				new AnswerModel { AnswerId = 70, QuestionId = 24, IsCorrect = true, Text = "Häst" },
				new AnswerModel { AnswerId = 71, QuestionId = 24, IsCorrect = false, Text = "Ko" },
				new AnswerModel { AnswerId = 72, QuestionId = 24, IsCorrect = false, Text = "Gris" },

				new AnswerModel { AnswerId = 73, QuestionId = 25, IsCorrect = true, Text = "Hund" },
				new AnswerModel { AnswerId = 74, QuestionId = 25, IsCorrect = false, Text = "Katt" },
				new AnswerModel { AnswerId = 75, QuestionId = 25, IsCorrect = false, Text = "Tiger" },

				new AnswerModel { AnswerId = 76, QuestionId = 26, IsCorrect = true, Text = "Katt" },
				new AnswerModel { AnswerId = 77, QuestionId = 26, IsCorrect = false, Text = "Leopard" },
				new AnswerModel { AnswerId = 78, QuestionId = 26, IsCorrect = false, Text = "Puma" },

				new AnswerModel { AnswerId = 79, QuestionId = 27, IsCorrect = true, Text = "Örn" },
				new AnswerModel { AnswerId = 80, QuestionId = 27, IsCorrect = false, Text = "Falk" },
				new AnswerModel { AnswerId = 81, QuestionId = 27, IsCorrect = false, Text = "Kondor" },

				new AnswerModel { AnswerId = 82, QuestionId = 28, IsCorrect = true, Text = "Papegoja" },
				new AnswerModel { AnswerId = 83, QuestionId = 28, IsCorrect = false, Text = "Kolibri" },
				new AnswerModel { AnswerId = 84, QuestionId = 28, IsCorrect = false, Text = "Pippifågel" },

				new AnswerModel { AnswerId = 85, QuestionId = 29, IsCorrect = true, Text = "Trana" },
				new AnswerModel { AnswerId = 86, QuestionId = 29, IsCorrect = false, Text = "Flamingo" },
				new AnswerModel { AnswerId = 87, QuestionId = 29, IsCorrect = false, Text = "Stork" },

				new AnswerModel { AnswerId = 88, QuestionId = 30, IsCorrect = true, Text = "Hamster" },
				new AnswerModel { AnswerId = 89, QuestionId = 30, IsCorrect = false, Text = "Kanin" },
				new AnswerModel { AnswerId = 90, QuestionId = 30, IsCorrect = false, Text = "Marsvin" },

				new AnswerModel { AnswerId = 91, QuestionId = 31, IsCorrect = true, Text = "Giraff" },
				new AnswerModel { AnswerId = 92, QuestionId = 31, IsCorrect = false, Text = "Zebra" },
				new AnswerModel { AnswerId = 93, QuestionId = 31, IsCorrect = false, Text = "Tiger" },

				new AnswerModel { AnswerId = 94, QuestionId = 32, IsCorrect = true, Text = "Känguru" },
				new AnswerModel { AnswerId = 95, QuestionId = 32, IsCorrect = false, Text = "Koala" },
				new AnswerModel { AnswerId = 96, QuestionId = 32, IsCorrect = false, Text = "Hund" },

				new AnswerModel { AnswerId = 97, QuestionId = 33, IsCorrect = true, Text = "Panda" },
				new AnswerModel { AnswerId = 98, QuestionId = 33, IsCorrect = false, Text = "Koala" },
				new AnswerModel { AnswerId = 99, QuestionId = 33, IsCorrect = false, Text = "Isbjörn" },

				new AnswerModel { AnswerId = 100, QuestionId = 34, IsCorrect = true, Text = "Flodhäst" },
				new AnswerModel { AnswerId = 101, QuestionId = 34, IsCorrect = false, Text = "Val" },
				new AnswerModel { AnswerId = 102, QuestionId = 34, IsCorrect = false, Text = "Havssköldpadda" },

				new AnswerModel { AnswerId = 103, QuestionId = 35, IsCorrect = true, Text = "Struts" },
				new AnswerModel { AnswerId = 104, QuestionId = 35, IsCorrect = false, Text = "Emu" },
				new AnswerModel { AnswerId = 105, QuestionId = 35, IsCorrect = false, Text = "Pelikan" },

				new AnswerModel { AnswerId = 106, QuestionId = 36, IsCorrect = true, Text = "Myra" },
				new AnswerModel { AnswerId = 107, QuestionId = 36, IsCorrect = false, Text = "Fjäril" },
				new AnswerModel { AnswerId = 108, QuestionId = 36, IsCorrect = false, Text = "Bi" },

				new AnswerModel { AnswerId = 109, QuestionId = 37, IsCorrect = true, Text = "Säl" },
				new AnswerModel { AnswerId = 110, QuestionId = 37, IsCorrect = false, Text = "Späckhuggare" },
				new AnswerModel { AnswerId = 111, QuestionId = 37, IsCorrect = false, Text = "Delfin" },

				new AnswerModel { AnswerId = 112, QuestionId = 38, IsCorrect = true, Text = "Hamster" },
				new AnswerModel { AnswerId = 113, QuestionId = 38, IsCorrect = false, Text = "Kanin" },
				new AnswerModel { AnswerId = 114, QuestionId = 38, IsCorrect = false, Text = "Marsvin" },

				new AnswerModel { AnswerId = 115, QuestionId = 39, IsCorrect = true, Text = "Råtta" },
				new AnswerModel { AnswerId = 116, QuestionId = 39, IsCorrect = false, Text = "Igelkott" },
				new AnswerModel { AnswerId = 117, QuestionId = 39, IsCorrect = false, Text = "Ekorre" },

				new AnswerModel { AnswerId = 118, QuestionId = 40, IsCorrect = true, Text = "Papegoja" },
				new AnswerModel { AnswerId = 119, QuestionId = 40, IsCorrect = false, Text = "Pippifågel" },
				new AnswerModel { AnswerId = 120, QuestionId = 40, IsCorrect = false, Text = "Kolibri" }
			);

        }
    }
}
