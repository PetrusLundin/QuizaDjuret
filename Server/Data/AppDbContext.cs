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
                    Text = "Vad är detta för djur?",
                    CorrectAnswerId = 1,
                    Hint = "Vanligt husdjur och bästa vän till människor",
                    FunFact = "Hundar är kända för att vara utmärkta simmare och kan simma flera kilometer i öppet vatten",
                    ImageURL = "https://i.imgur.com/nMVJSnF.jpeg",
					DifficultyLevel = 1
                },
				new QuestionModel
				{
					QuestionId = 2,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 4,
					Hint = "Har en av de längsta nackarna i djurriket",
					FunFact = "Giraffer sover bara i korta stunder och står upp",
					ImageURL = "https://i.imgur.com/HTwzNY0.jpg",
					DifficultyLevel = 1
				},
	            new QuestionModel
	            {
		            QuestionId = 3,
		            Text = "Vad är detta för djur?",
		            CorrectAnswerId = 7,
		            Hint = "Har en karakteristisk pung för att bära sina ungar",
		            FunFact = "Känguruer kan hoppa mycket långa sträckor och vara väldigt snabba",
		            ImageURL = "https://i.imgur.com/LRrt7dB.jpg",
		            DifficultyLevel = 1
	            },
				new QuestionModel
				{
					QuestionId = 4,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 10,
					Hint = "Känd för att vara 'kungen av djungeln'",
					FunFact = "Lejonets rytande kan höras på flera kilometers avstånd",
					ImageURL = "https://i.imgur.com/3YTx841.jpg",
					DifficultyLevel = 1
				},
				 new QuestionModel
				 {
					 QuestionId = 5,
					 Text = "Vad är detta för djur?",
					 CorrectAnswerId = 13,
					 Hint = "Lever i Kina och äter mest bambu",
					 FunFact = "Pandor är kända för sin söta och knubbiga utseende",
					 ImageURL = "https://i.imgur.com/vVxD2Vr.jpg",
					 DifficultyLevel = 1
				 },
				new QuestionModel
				{
					QuestionId = 6,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 16,
					Hint = "Lever i haven och är en utmärkt simmare",
					FunFact = "Delfiner kommunicerar med varandra genom att använda olika ljud och klickar",
					ImageURL = "https://i.imgur.com/UYNPT5l.jpg",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 7,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 19,
					Hint = "Symbol för styrka och frihet",
					FunFact = "Örnar har en utmärkt syn och kan se byten från hög höjd",
					ImageURL = "https://i.imgur.com/KJdADuA.jpg",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 8,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 22,
					Hint = "Även om de är kraftiga simmare, är de oftast landbaserade",
					FunFact = "Flodhästar är kända för sina massiva käkar och tänder",
					ImageURL = "https://i.imgur.com/Usfrgma.jpg",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 9,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 25,
					Hint = "Lever på en diet som främst består av eukalyptusblad",
					FunFact = "Koalor sover upp till 20 timmar om dagen",
					ImageURL = "https://i.imgur.com/9PzgFus.jpg",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 10,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 28,
					Hint = "Känd för sitt arbete att samla mat",
					FunFact = "En del myror kan lyfta objekt som är mycket tyngre än de själva",
					ImageURL = "https://i.imgur.com/REFAZzh.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 11,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 31,
					Hint = "Känd för sitt arbete att samla mat",
					FunFact = "En del myror kan lyfta objekt som är mycket tyngre än de själva",
					ImageURL = "https://i.imgur.com/qSCH06v.png",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 12,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 34,
					Hint = "Lever ofta i närheten av kusten och äter fisk",
					FunFact = "Sälar är skickliga simmare och dykare",
					ImageURL = "https://i.imgur.com/bRlhcaM.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 13,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 37,
					Hint = "Lever ofta i våtmarker och har ett karakteristiskt trumpetande ljud",
					FunFact = "Tranor är kända för sina graciösa danser under parningen",
					ImageURL = "https://i.imgur.com/pWr4Xxu.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 14,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 40,
					Hint = "Kan vara hårig eller naken, beroende på ras",
					FunFact = "Hamstrar har kindpåsar där de kan lagra mat",
					ImageURL = "https://i.imgur.com/tWHofmn.png",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 15,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 43,
					Hint = "Lever i Afrika och är en skicklig jägare",
					FunFact = "Geparder är de snabbaste landdjuren på jorden",
					ImageURL = "https://i.imgur.com/X7kpZ0P.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 16,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 46,
					Hint = "Kan vara grå, brun eller svart",
					FunFact = "Råttor är mycket intelligenta och kan lösa komplexa problem",
					ImageURL = "https://i.imgur.com/vyesMf1.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 17,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 49,
					Hint = "Kan vara röd, blå, grön eller gul",
					FunFact = "Papegojor kan ha ett mycket brett ordförråd och förstå enkla meningar",
					ImageURL = "https://i.imgur.com/nO4aFC3.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 18,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 52,
					Hint = "Gör honung och bor i bikupor",
					FunFact = "Bin är viktiga pollinatörer för många växter",
					ImageURL = "https://i.imgur.com/tfhdJ40.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 19,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 55,
					Hint = "Lever i regnskogen och använder verktyg",
					FunFact = "Orangutanger delar omkring 97 % av sin DNA med människor",
					ImageURL = "https://i.imgur.com/EPK88mg.jpg",
					DifficultyLevel = 2
				},
				new QuestionModel
				{
					QuestionId = 20,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 58,
					Hint = "Har en karakteristisk sång under natten",
					FunFact = "Groddjur genomgår en metamorfos från groda till groda",
					ImageURL = "https://i.imgur.com/TY9PKPZ.jpg",
					DifficultyLevel = 2
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

				new AnswerModel { AnswerId = 25, QuestionId = 9, IsCorrect = true, Text = "Känguru" },
				new AnswerModel { AnswerId = 26, QuestionId = 9, IsCorrect = false, Text = "Echidna" },
				new AnswerModel { AnswerId = 27, QuestionId = 9, IsCorrect = false, Text = "Koala" },

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
				new AnswerModel { AnswerId = 60, QuestionId = 20, IsCorrect = false, Text = "Salmander" }
			);
        }
    }
}
