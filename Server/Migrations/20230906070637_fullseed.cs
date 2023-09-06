using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizaDjuret.Server.Migrations
{
    /// <inheritdoc />
    public partial class fullseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Highscore",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Highscore", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorrectAnswerId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FunFact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DifficultyLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "CorrectAnswerId", "DifficultyLevel", "FunFact", "Hint", "ImageURL", "Text" },
                values: new object[,]
                {
                    { 1, 1, 1, "Hundar är kända för att vara utmärkta simmare och kan simma flera kilometer i öppet vatten", "Vanligt husdjur och männikans bästavän", "https://i.imgur.com/nMVJSnF.jpeg", "Vad är detta för djur?" },
                    { 2, 4, 1, "Giraffer sover bara i korta stunder och står upp", "Har en av de längsta nackarna i djurriket", "https://i.imgur.com/HTwzNY0.jpg", "Vad är detta för djur?" },
                    { 3, 7, 1, "Känguruer kan hoppa mycket långa sträckor och är extremt snabba", "Har en karakteristisk pung för att bära sina ungar i", "https://i.imgur.com/LRrt7dB.jpg", "Vad är detta för djur?" },
                    { 4, 10, 1, "Lejonets rytande kan hörs på flera kilometers avstånd", "Känd för att vara 'kungen av djungeln'", "https://i.imgur.com/3YTx841.jpg", "Vad är detta för djur?" },
                    { 5, 13, 1, "Pandor är kända för sin söta och knubbiga utseende", "Lever i Kina och äter mestadels bambu", "https://i.imgur.com/vVxD2Vr.jpg", "Vad är detta för djur?" },
                    { 6, 16, 1, "Delfiner kommunicerar med varandra genom att använda olika ljud och klickar", "Lever i haven och är utmärkta simmare", "https://i.imgur.com/UYNPT5l.jpg", "Vad är detta för djur?" },
                    { 7, 19, 1, "Örnar har en utmärkt syn och kan se byten från hög höjd", "Symbol för styrka och frihet", "https://i.imgur.com/KJdADuA.jpg", "Vad är detta för djur?" },
                    { 8, 22, 1, "Flodhästar är kända för sina massiva käkar och tänder", "Även om de är kraftiga simmare, så lever de mestadels på land", "https://i.imgur.com/Usfrgma.jpg", "Vad är detta för djur?" },
                    { 9, 25, 1, "Koalor sover upp till 20 timmar per dyng", "Lever på en diet som främst består av eukalyptusblad", "https://i.imgur.com/9PzgFus.jpg", "Vad är detta för djur?" },
                    { 10, 28, 1, "Strutsar är de största och tyngsta fåglarna på jorden", "Finns i Afrika och är känd för sin långa hals", "https://i.imgur.com/REFAZzh.jpg", "Vad är detta för djur?" },
                    { 11, 31, 2, "En del myror kan lyfta objekt som är mycket tyngre än de själva", "Känd för sitt arbete att samla mat", "https://i.imgur.com/qSCH06v.png", "Vad är detta för djur?" },
                    { 12, 34, 2, "Sälar är skickliga simmare och dykare", "Lever ofta i närheten av kusten och äter fisk", "https://i.imgur.com/bRlhcaM.jpg", "Vad är detta för djur?" },
                    { 13, 37, 2, "Tranor är kända för sina graciösa danser under parningssäsongen", "Lever ofta i våtmarker och har ett karakteristiskt trumpetande ljud", "https://i.imgur.com/pWr4Xxu.jpg", "Vad är detta för djur?" },
                    { 14, 40, 2, "Hamstrar har kindpåsar där de lagra mat", "Kan vara hårig eller naken, beroende på ras", "https://i.imgur.com/tWHofmn.png", "Vad är detta för djur?" },
                    { 15, 43, 2, "Geparder är de snabbaste landdjuren på jorden", "Lever i Afrika och är en skicklig jägare", "https://i.imgur.com/X7kpZ0P.jpg", "Vad är detta för djur?" },
                    { 16, 46, 2, "Råttor är mycket intelligenta och kan lösa komplexa problem", "Kan vara grå, brun eller svart", "https://i.imgur.com/vyesMf1.jpg", "Vad är detta för djur?" },
                    { 17, 49, 2, "Papegojor kan ha ett mycket brett ordförråd och förstå enkla meningar", "Kan vara röd, blå, grön eller gul", "https://i.imgur.com/nO4aFC3.jpg", "Vad är detta för djur?" },
                    { 18, 52, 2, "Bin är viktiga pollinatörer för många växter", "Gör honung och bor i bikupor", "https://i.imgur.com/tfhdJ40.jpg", "Vad är detta för djur?" },
                    { 19, 55, 2, "Orangutanger delar omkring 97 % av sin DNA med människor", "Lever i regnskogen och gillar bananer", "https://i.imgur.com/EPK88mg.jpg", "Vad är detta för djur?" },
                    { 20, 58, 2, "Groddjur genomgår en förvandling från simmande grodyngel till groda", "Har en karakteristisk sång under natten", "https://i.imgur.com/TY9PKPZ.jpg", "Vad är detta för djur?" },
                    { 21, 61, 3, "Sälar är skickliga simmare och dykare", "Lever ofta i närheten av kusten och äter fisk", "Säl.mp3", "Vilket djur gör detta ljud?" },
                    { 22, 64, 3, "Lejonets rytande kan höras på flera kilometers avstånd", "Känd för att vara 'kungen av djungeln'", "Lejon.mp3", "Vilket djur gör detta ljud?" },
                    { 23, 67, 3, "Delfiner kommunicerar med varandra genom att använda olika ljud och klickar", "Lever i havet och är en utmärkt simmare", "Delfin.mp3", "Vilket djur gör detta ljud?" },
                    { 24, 70, 3, "Hästar har en utmärkt förmåga att kommunicera med kroppsspråk", "Ofta används för ridning och dragarbete", "Häst.mp3", "Vilket djur gör detta ljud?" },
                    { 25, 73, 3, "Hundar är kända för att vara utmärkta simmare och kan simma flera kilometer i öppet vatten", "Vanligt husdjur och människans bästavän", "Hund.mp3", "Vilket djur gör detta ljud?" },
                    { 26, 76, 3, "Katter kan hoppa flera gånger sin egen kroppslängd i en enda hopp", "Är känd för att jaga möss och andra smådjur", "Katt.mp3", "Vilket djur gör detta ljud?" },
                    { 27, 79, 3, "Örnar har en utmärkt syn och kan se byten från hög höjd", "Symbol för styrka och frihet", "Örn.mp3", "Vilket djur gör detta ljud?" },
                    { 28, 82, 3, "Papegojor kan ha ett mycket brett ordförråd och förstå enkla meningar", "Kan vara röd, blå, grön eller gul", "Papegoja.mp3", "Vilket djur gör detta ljud?" },
                    { 29, 85, 3, "Tranor är kända för sina graciösa danser under parningssäsongen", "Lever ofta i våtmarker och har ett karakteristiskt trumpetande ljud", "Trana.mp3", "Vilket djur gör detta ljud?" },
                    { 30, 88, 3, "Hamstrar har kindpåsar där de lagra mat", "Kan vara hårig eller naken, beroende på ras", "Hamster.mp3", "Vilket djur gör detta ljud?" },
                    { 31, 91, 4, "Giraffer sover bara i korta stunder och står upp", "Har en av de längsta nackarna i djurriket", "", "Ett långhalsat djur med fläckig päls" },
                    { 32, 94, 4, "Känguruer kan hoppa mycket långa sträckor och är extremt snabba", "Har en karakteristisk pung för att bära sina ungar i", "", "Ett pungdjur från Australien som hoppar på sina bakben" },
                    { 33, 97, 4, "Pandor är kända för sin söta och knubbiga utseende", "Lever i Kina och äter mestadels bambu", "", "En björnart med svartvita markeringar" },
                    { 34, 100, 4, "Flodhästar är kända för sina massiva käkar och tänder", "Även om de är kraftiga simmare, befinner de sig oftast på land", "", "Ett stort, tungt djur som lever i vattnet" },
                    { 35, 103, 4, "Strutsar är de största och tyngsta fåglarna på jorden", "Finns i Afrika och är känd för sin långa hals", "", "En stor gräsätande fågel som inte kan flyga" },
                    { 36, 106, 4, "Myror kan lyfta objekt som är mycket tyngre än de själva", "Känd för sitt arbete att samla mat", "", "En liten insekt som ofta arbetar i kolonier" },
                    { 37, 109, 4, "Sälar är skickliga simmare och dykare", "Lever ofta i närheten av kusten och äter fisk", "", "Ett marint däggdjur med kraftiga morrhår" },
                    { 38, 112, 4, "Hamstrar har kindpåsar där de lagra mat", "Kan vara hårig eller naken, beroende på ras", "", "En liten gnagare som ofta ses i burar som husdjur" },
                    { 39, 115, 4, "Råttor är mycket intelligenta och kan lösa komplexa problem", "Kan vara grå, brun eller svart", "", "Ett snabbt och smidigt djur som ofta förekommer i städer" },
                    { 40, 118, 4, "Papegojor kan ha ett mycket brett ordförråd och förstå enkla meningar", "Kan vara röd, blå, grön eller gul", "", "En färgglad fågel som ofta kan härma mänskliga ljud" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 1, true, 1, "Hund" },
                    { 2, false, 1, "Katt" },
                    { 3, false, 1, "Leopard" },
                    { 4, true, 2, "Giraff" },
                    { 5, false, 2, "Zebra" },
                    { 6, false, 2, "Koala" },
                    { 7, true, 3, "Känguru" },
                    { 8, false, 3, "Lejon" },
                    { 9, false, 3, "Koala" },
                    { 10, true, 4, "Lejon" },
                    { 11, false, 4, "Tiger" },
                    { 12, false, 4, "Panter" },
                    { 13, true, 5, "Panda" },
                    { 14, false, 5, "Koala" },
                    { 15, false, 5, "Isbjörn" },
                    { 16, true, 6, "Delfin" },
                    { 17, false, 6, "Val" },
                    { 18, false, 6, "Säl" },
                    { 19, true, 7, "Örn" },
                    { 20, false, 7, "Falk" },
                    { 21, false, 7, "Kondor" },
                    { 22, true, 8, "Flodhäst" },
                    { 23, false, 8, "Havssköldpadda" },
                    { 24, false, 8, "Val" },
                    { 25, true, 9, "Känguru" },
                    { 26, false, 9, "Echidna" },
                    { 27, false, 9, "Koala" },
                    { 28, true, 10, "Struts" },
                    { 29, false, 10, "Emu" },
                    { 30, false, 10, "Pelikan" },
                    { 31, true, 11, "Myra" },
                    { 32, false, 11, "Fjäril" },
                    { 33, false, 11, "Larv" },
                    { 34, true, 12, "Säl" },
                    { 35, false, 12, "Delfin" },
                    { 36, false, 12, "Späckhuggare" },
                    { 37, true, 13, "Tran" },
                    { 38, false, 13, "Stork" },
                    { 39, false, 13, "Flamingo" },
                    { 40, true, 14, "Hamster" },
                    { 41, false, 14, "Marsvin" },
                    { 42, false, 14, "Kanin" },
                    { 43, true, 15, "Gepard" },
                    { 44, false, 15, "Tiger" },
                    { 45, false, 15, "Lejon" },
                    { 46, true, 16, "Råtta" },
                    { 47, false, 16, "Ekorre" },
                    { 48, false, 16, "Igelkott" },
                    { 49, true, 17, "Papegoja" },
                    { 50, false, 17, "Kolibri" },
                    { 51, false, 17, "Pippifågel" },
                    { 52, true, 18, "Bi" },
                    { 53, false, 18, "Fjäril" },
                    { 54, false, 18, "Fluga" },
                    { 55, true, 19, "Orangutang" },
                    { 56, false, 19, "Gorilla" },
                    { 57, false, 19, "Schimpans" },
                    { 58, true, 20, "Groda" },
                    { 59, false, 20, "Ödla" },
                    { 60, false, 20, "Salmander" },
                    { 61, true, 21, "Säl" },
                    { 62, false, 21, "Späckhuggare" },
                    { 63, false, 21, "Haj" },
                    { 64, true, 22, "Lejon" },
                    { 65, false, 22, "Tiger" },
                    { 66, false, 22, "Puma" },
                    { 67, true, 23, "Delfin" },
                    { 68, false, 23, "Val" },
                    { 69, false, 23, "Säl" },
                    { 70, true, 24, "Häst" },
                    { 71, false, 24, "Ko" },
                    { 72, false, 24, "Gris" },
                    { 73, true, 25, "Hund" },
                    { 74, false, 25, "Katt" },
                    { 75, false, 25, "Tiger" },
                    { 76, true, 26, "Katt" },
                    { 77, false, 26, "Leopard" },
                    { 78, false, 26, "Puma" },
                    { 79, true, 27, "Örn" },
                    { 80, false, 27, "Falk" },
                    { 81, false, 27, "Kondor" },
                    { 82, true, 28, "Papegoja" },
                    { 83, false, 28, "Kolibri" },
                    { 84, false, 28, "Pippifågel" },
                    { 85, true, 29, "Trana" },
                    { 86, false, 29, "Flamingo" },
                    { 87, false, 29, "Stork" },
                    { 88, true, 30, "Hamster" },
                    { 89, false, 30, "Kanin" },
                    { 90, false, 30, "Marsvin" },
                    { 91, true, 31, "Giraff" },
                    { 92, false, 31, "Zebra" },
                    { 93, false, 31, "Tiger" },
                    { 94, true, 32, "Känguru" },
                    { 95, false, 32, "Koala" },
                    { 96, false, 32, "Hund" },
                    { 97, true, 33, "Panda" },
                    { 98, false, 33, "Koala" },
                    { 99, false, 33, "Isbjörn" },
                    { 100, true, 34, "Flodhäst" },
                    { 101, false, 34, "Val" },
                    { 102, false, 34, "Havssköldpadda" },
                    { 103, true, 35, "Struts" },
                    { 104, false, 35, "Emu" },
                    { 105, false, 35, "Pelikan" },
                    { 106, true, 36, "Myra" },
                    { 107, false, 36, "Fjäril" },
                    { 108, false, 36, "Bi" },
                    { 109, true, 37, "Säl" },
                    { 110, false, 37, "Späckhuggare" },
                    { 111, false, 37, "Delfin" },
                    { 112, true, 38, "Hamster" },
                    { 113, false, 38, "Kanin" },
                    { 114, false, 38, "Marsvin" },
                    { 115, true, 39, "Råtta" },
                    { 116, false, 39, "Igelkott" },
                    { 117, false, 39, "Ekorre" },
                    { 118, true, 40, "Papegoja" },
                    { 119, false, 40, "Pippifågel" },
                    { 120, false, 40, "Kolibri" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Highscore");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
