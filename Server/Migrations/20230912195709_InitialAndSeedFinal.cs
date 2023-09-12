using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizaDjuret.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialAndSeedFinal : Migration
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
                    MediaURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                columns: new[] { "QuestionId", "CorrectAnswerId", "DifficultyLevel", "FunFact", "Hint", "MediaURL", "Text" },
                values: new object[,]
                {
                    { 1, 1, 1, "Hundar är en av de äldsta tamdjursarterna och har funnits som människans följeslagare i över 15 000 år.", "Vanligt husdjur och människans bästavän", "https://i.imgur.com/E1yr3A4.jpg", "Gissa djuret" },
                    { 2, 4, 1, "Giraffer har faktiskt samma antal halskotor som människor, det vill säga sju, men varje halskota är enormt stor och kan vara upp till 2,5 meter lång!", "Har en av de längsta nackarna i djurriket", "https://i.imgur.com/HTwzNY0.jpg", "Gissa djuret" },
                    { 3, 7, 1, "Kängurur kan inte hoppa bakåt på grund av deras stora svansar, så om de försöker gå bakåt kommer de snubbla istället!", "Har en karakteristisk pung för att bära sina ungar i", "https://i.imgur.com/yowTeLd.jpg", "Gissa djuret" },
                    { 4, 10, 1, "Lejon har en imponerande man som inte bara gör dem majestätiska utan också skyddar deras hals mot attacker från andra djur.", "Känd för att vara 'kungen av djungeln'", "https://i.imgur.com/qYLjY7V.jpg", "Gissa djuret" },
                    { 5, 13, 1, "Pandors avtryck i snön kan vara så lika en människas fotspår att det har lett till myter om \"människo-pandor\" i Kina!", "Lever i Kina och äter mestadels bambu", "https://i.imgur.com/3AhigqN.jpg", "Gissa djuret" },
                    { 6, 16, 1, "Delfiner har faktiskt namn och svarar på sina egna namn när de kallas, precis som husdjur!", "Lever i haven och är utmärkta simmare", "https://i.imgur.com/sCZLvlk.jpg", "Gissa djuret" },
                    { 7, 19, 1, "En örn kan ha en vingspann på upp till 2,5 meter, vilket är större än de flesta människors höjd!", "Symbol för styrka och frihet", "https://i.imgur.com/KJdADuA.jpg", "Gissa djuret" },
                    { 8, 22, 1, "Flodhästar simmar väldigt sällan, de rör sig i stället genom att studsande gå längs botten av floder och sjöar med fötterna!", "Lever nära vatten och har en kompakt kroppsform med korta ben", "https://i.imgur.com/YCm4pG8.jpg", "Gissa djuret" },
                    { 9, 25, 1, "Koalor sover upp till 20 timmar per dyng", "Lever på en diet som främst består av eukalyptusblad", "https://i.imgur.com/54Ef30u.jpg", "Gissa djuret" },
                    { 10, 28, 1, "Strutsar kan sticka huvudet i sanden när de känner sig hotade i tron om att de är gömda", "Finns i Afrika och är känd för sin långa hals", "https://i.imgur.com/K6ZkhNV.jpg", "Gissa djuret" },
                    { 11, 31, 2, "Myror kan bli \"lata\" ibland och skaffa sig husdjur, som bladlöss, för att mjölka dem på honungsdagg, vilket sparar myrornas egna ansträngningar!", "Känd för sitt slitsamma arbete att samla mat", "https://i.imgur.com/qSCH06v.png", "Gissa del av djuret" },
                    { 12, 34, 2, "Sälar kan ha powernaps under vattnet som varar i upp till 15 minuter utan att behöva komma upp till ytan för att andas.", "Lever ofta i närheten av kusten och äter fisk", "https://i.imgur.com/A31vC3i.jpg", "Gissa del av djuret" },
                    { 13, 37, 2, "När tranor flyger formar de ett V-liknande mönster, tranan längst fram styr vägen framåt", "Lever ofta i våtmarker och har ett karakteristiskt trumpetande ljud", "https://i.imgur.com/hugB42z.jpg", "Gissa del av djuret" },
                    { 14, 40, 2, "Hamstrar har kindpåsar som de kan lagra mat i, och de kan fylla dessa påsar med mat så mycket som dubbel sin kroppsvikt!", "Kan vara hårig eller naken, beroende på ras", "https://i.imgur.com/9tB3vyX.jpg", "Gissa del av djuret" },
                    { 15, 43, 2, "Geparder är de snabbaste landdjuren i världen, men de har faktiskt ett mycket blygsamt temperament och kan ibland förlora sina byten till mer aggressiva rovdjur.", "Lever i Afrika och är en skicklig jägare", "https://i.imgur.com/R8l5ZXt.jpg", "Gissa del av djuret" },
                    { 16, 46, 2, "Råttor har utmärkt nattsyn och kan se i totalt mörker, men de lider av färgblindhet och ser världen i svartvitt.", "Kan vara grå, brun eller svart", "https://i.imgur.com/LjvmNvY.jpg", "Gissa del av djuret" },
                    { 17, 49, 2, "Papergojor har en fantastisk förmåga att efterlikna ljud, och vissa arter kan låta som allt från fågelkvitter till surrande insekter.", "Kan vara röd, blå, grön eller gul", "https://i.imgur.com/JnNOgpJ.jpg", "Gissa del av djuret" },
                    { 18, 52, 2, "Bina har faktiskt en liten \"mustasch\" under sina huvuden som hjälper dem att känna av blommornas form och färg när de samlar nektar!", "Gör honung och bor i bikupor", "https://i.imgur.com/c7qukSG.jpg", "Gissa del av djuret" },
                    { 19, 55, 2, "Orangutanger delar omkring 97 % av sin DNA med människor", "Lever i regnskogen och gillar bananer", "https://i.imgur.com/USujWHm.jpg", "Gissa del av djuret" },
                    { 20, 58, 2, "Vissa grodor har en unik förmåga att ändra färg beroende på sin omgivning, och de kan till och med bli blåa när de är nervösa!", "Har en karakteristisk sång under natten", "https://i.imgur.com/V6sg2vK.jpg", "Gissa del av djuret" },
                    { 21, 61, 3, "Sälar kallas ibland för \"vattenhundar\" eftersom de kan vara lika lekfulla och nyfikna som hundar när de simmar i vattnet.", "Lever ofta i närheten av kusten och äter fisk", "Säl.mp3", "Gissa ljudet" },
                    { 22, 64, 3, "Lejon kan vara riktigt lata och sova upp till 20 timmar om dagen, vilket gör dem till några av de mest avslappnade stora kattdjuren på savannen!", "Känd för att vara 'kungen av djungeln'", "Lejon.mp3", "Gissa ljudet" },
                    { 23, 67, 3, "Delfiner älskar lek och humor så mycket att de ibland skapar sina egna \"vattenringar\" och sedan leka med dem som om de vore leksaker!", "Lever i havet och är en utmärkt simmare", "Delfin.mp3", "Gissa ljudet" },
                    { 24, 70, 3, "Hästar kan inte kräkas, vilket betyder att de måste vara försiktiga med vad de äter eftersom de inte kan bli av med oönskad mat på samma sätt som människor.", "Ofta används för ridning och dragarbete", "Häst.mp3", "Gissa ljudet" },
                    { 25, 73, 3, "Hundar kan känna av människors känslor och är faktiskt kapabla att skilja på olika humör i människors ansiktsuttryck.", "Vanligt husdjur och människans bästavän", "Hund.mp3", "Gissa ljudet" },
                    { 26, 76, 3, "Katter kan göra upp till 100 olika ljud, medan hundar bara kan göra omkring 10.", "Är känd för att jaga möss och andra smådjur", "Katt.mp3", "Gissa ljudet" },
                    { 27, 79, 3, "Örnar har så bra syn att om du skulle ta en tidning och hålla den upp i luften, skulle en örn kunna läsa rubrikerna från en halv mils avstånd!", "Symbol för styrka och frihet", "Örn.mp3", "Gissa ljudet" },
                    { 28, 82, 3, "Papergojor har faktiskt funnits i över 2 000 år och användes ursprungligen i Kina för att skicka meddelanden inom militären.", "Kan vara röd, blå, grön eller gul", "Papegoja.mp3", "Gissa ljudet" },
                    { 29, 85, 3, "Tranor är kända för sina melodiska och uttrycksfulla sånger, och de använder dessa sånger för att prata med varandra.", "Lever ofta i våtmarker och har ett karakteristiskt trumpetande ljud", "Trana.mp3", "Gissa ljudet" },
                    { 30, 88, 3, "Hamstrar är kända för sin imponerande uppsättning tänder, och deras framtänder växer hela livet.", "Kan vara hårig eller naken, beroende på ras", "Hamster.mp3", "Gissa ljudet" },
                    { 31, 91, 4, "Giraffer har det högsta blodtrycken bland alla landlevande djur, vilket hjälper dem att pumpa blod upp genom sin långa hals och vidare till hjärnan", "Har en av de längsta nackarna i djurriket", "", "Ett långhalsat djur med fläckig päls" },
                    { 32, 94, 4, "Känguruer är kända för sin \"kängurupåse\" där de bär sina ungar, men de kan faktiskt kontrollera musklerna i påsen för att öppna och stänga den vid behov.", "Har en karakteristisk pung för att bära sina ungar i", "", "Ett pungdjur från Australien som hoppar på sina bakben" },
                    { 33, 97, 4, "Pandor äter upp till 40 kilo bambu per dag.", "Lever i Kina och äter mestadels bambu", "", "En björnart med svartvita markeringar" },
                    { 34, 100, 4, "Flodhästar är att de har en förmåga att \"svettas\" en rödaktig vätska som fungerar som ett naturligt solskydd.", "Även om de är kraftiga simmare, befinner de sig oftast på land", "", "Ett stort, tungt djur som lever i vattnet" },
                    { 35, 103, 4, "Strutsarnas ögon är faktiskt större än deras hjärna!", "Finns i Afrika och är känd för sin långa hals", "", "En stor gräsätande fågel som inte kan flyga" },
                    { 36, 106, 4, "Myror är så starka i förhållande till sin storlek att, om de var lika stora som människor skulle de kunna lyfta bilar!", "Känd för sitt arbete att samla mat", "", "En liten insekt som ofta arbetar i kolonier" },
                    { 37, 109, 4, "Sälar har utvecklat en speciell förmåga att hålla andan under vatten och kan göra det i upp till två timmar i sträck när de dyker efter föda!", "Lever ofta i närheten av kusten och äter fisk", "", "Ett marint däggdjur med kraftiga morrhår" },
                    { 38, 112, 4, "Hamstrar kan springa upp till 13 kilometer på en natt i sina hjul, vilket gör dem till små maratonlöpare!", "Kan vara hårig eller naken, beroende på ras", "", "En liten gnagare som ofta ses i burar som husdjur" },
                    { 39, 115, 4, "Råttor är extremt sociala djur och kan bli ensamma och deprimerade om de inte har sällskap av andra råttor.", "Kan vara grå, brun eller svart", "", "Ett snabbt och smidigt djur som ofta förekommer i städer" },
                    { 40, 118, 4, "Papergojor kan nå imponerande höjder och har rekord på över 30 000 meter, vilket är högre än de flesta flygplan flyger!", "Kan vara röd, blå, grön eller gul", "", "En färgglad fågel som ofta kan härma mänskliga ljud" }
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
                    { 25, false, 9, "Känguru" },
                    { 26, false, 9, "Echidna" },
                    { 27, true, 9, "Koala" },
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
