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
					CorrectAnswerId = 2,
					Hint = "Har en av de längsta nackarna i djurriket",
					FunFact = "Giraffer sover bara i korta stunder och står upp",
					ImageURL = "https://i.imgur.com/HTwzNY0.jpg",
					DifficultyLevel = 1
				},
	            new QuestionModel
	            {
		            QuestionId = 3,
		            Text = "Vad är detta för djur?",
		            CorrectAnswerId = 3,
		            Hint = "Har en karakteristisk pung för att bära sina ungar",
		            FunFact = "Känguruer kan hoppa mycket långa sträckor och vara väldigt snabba",
		            ImageURL = "https://i.imgur.com/LRrt7dB.jpg",
		            DifficultyLevel = 1
	            },
				new QuestionModel
				{
					QuestionId = 4,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 4,
					Hint = "Känd för att vara 'kungen av djungeln'",
					FunFact = "Lejonets rytande kan höras på flera kilometers avstånd",
					ImageURL = "https://i.imgur.com/3YTx841.jpg",
					DifficultyLevel = 1
				},
				 new QuestionModel
				 {
					 QuestionId = 5,
					 Text = "Vad är detta för djur?",
					 CorrectAnswerId = 5,
					 Hint = "Lever i Kina och äter mest bambu",
					 FunFact = "Pandor är kända för sin söta och knubbiga utseende",
					 ImageURL = "https://i.imgur.com/vVxD2Vr.jpg",
					 DifficultyLevel = 1
				 },
				new QuestionModel
				{
					QuestionId = 6,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 6,
					Hint = "Lever i haven och är en utmärkt simmare",
					FunFact = "Delfiner kommunicerar med varandra genom att använda olika ljud och klickar",
					ImageURL = "https://i.imgur.com/UYNPT5l.jpg",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 7,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 7,
					Hint = "Symbol för styrka och frihet",
					FunFact = "Örnar har en utmärkt syn och kan se byten från hög höjd",
					ImageURL = "https://i.imgur.com/KJdADuA.jpg",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 8,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 8,
					Hint = "Även om de är kraftiga simmare, är de oftast landbaserade",
					FunFact = "Flodhästar är kända för sina massiva käkar och tänder",
					ImageURL = "https://i.imgur.com/Usfrgma.jpg",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 9,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 9,
					Hint = "Lever på en diet som främst består av eukalyptusblad",
					FunFact = "Koalor sover upp till 20 timmar om dagen",
					ImageURL = "https://i.imgur.com/9PzgFus.jpg",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 10,
					Text = "Vad är detta för djur?",
					CorrectAnswerId = 10,
					Hint = "Finns i Afrika och är känd för sin långa hals",
					FunFact = "Strutsar är de största och tyngsta fåglarna på jorden",
					ImageURL = "https://i.imgur.com/REFAZzh.jpg",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 11,
					Text = "En liten insekt som ofta arbetar i kolonier",
					CorrectAnswerId = 33,
					Hint = "Känd för sitt arbete att samla mat",
					FunFact = "En del myror kan lyfta objekt som är mycket tyngre än de själva",
					ImageURL = "Länk till bild här",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 12,
					Text = "Ett marint däggdjur med kraftiga morrhår",
					CorrectAnswerId = 36,
					Hint = "Lever ofta i närheten av kusten och äter fisk",
					FunFact = "Sälar är skickliga simmare och dykare",
					ImageURL = "Länk till bild här",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 13,
					Text = "En stor fågel med lång hals och långa ben",
					CorrectAnswerId = 39,
					Hint = "Lever ofta i våtmarker och har ett karakteristiskt trumpetande ljud",
					FunFact = "Tranor är kända för sina graciösa danser under parningen",
					ImageURL = "Länk till bild här",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 14,
					Text = "En liten gnagare som ofta ses i burar som husdjur",
					CorrectAnswerId = 45,
					Hint = "Kan vara hårig eller naken, beroende på ras",
					FunFact = "Hamstrar har kindpåsar där de kan lagra mat",
					ImageURL = "Länk till bild här",
					DifficultyLevel = 1
				},
				new QuestionModel
				{
					QuestionId = 15,
					Text = "En stor kattdjur med fläckig päls och långa ben",
					CorrectAnswerId = 48,
					Hint = "Lever i Afrika och är en skicklig jägare",
					FunFact = "Geparder är de snabbaste landdjuren på jorden",
					ImageURL = "Länk till bild här",
					DifficultyLevel = 1
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

				new AnswerModel { AnswerId = 22, QuestionId = 9, IsCorrect = true, Text = "Känguru" },
				new AnswerModel { AnswerId = 23, QuestionId = 9, IsCorrect = false, Text = "Echidna" },
				new AnswerModel { AnswerId = 24, QuestionId = 9, IsCorrect = false, Text = "Koala" },

				new AnswerModel { AnswerId = 25, QuestionId = 10, IsCorrect = true, Text = "Struts" },
				new AnswerModel { AnswerId = 26, QuestionId = 10, IsCorrect = false, Text = "Emu" },
				new AnswerModel { AnswerId = 27, QuestionId = 10, IsCorrect = false, Text = "Pelikan" }
			);
        }
    }
}
