// See https://aka.ms/new-console-template for more information
class Program
{

    static void Main(string[] args)
    {
        
       bool playagain = true;
        while (playagain) {
            int numbering = 1;
            string Input;
            int score = 0;
            int count = 1;
            Console.WriteLine("Please enter your name");
            string Name = Console.ReadLine();
            Console.WriteLine("Welcome Mr " + Name + "\n press any button to continue");
            Console.ReadLine();

            
            string[] Questions = {    ">> What is the capital of Algeria ",  ">> What is the capital of Albenia",
                                  ">> What is the capital of Brazil",    ">> What is the capital of Belarus ",
                                  ">> What is the capital of Belgium",   ">> What is the capital of Costa Rica",
                                  ">> What is the capital of Egypt",     ">> What is the capital of Finland",
                                  ">> What is the capital of Cameroon",  ">> What is the capital of Hungary",
                                  ">> What is the capital of Isreal",    ">> What is the capital of Nigeria",
                                  ">> What is the capital of Kenya ",    ">> What is the capital of Senegal",
                                  ">> What is the capital of Mexico",    ">> What is the capital of Qarter",
                                  ">> What is the capital of Japan ",    ">> What is the capital of Norway ",
                                  ">> What is the capital of Peru ",     ">> What is the capital of Monaco" };
            while (count < 11)
            {
               
                Random select = new Random();
            another:
                int set = select.Next(Questions.Length);
              
                if (Questions[set] == "o")
                {
                    goto another;
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("QUESTION " + numbering++);
                    Console.WriteLine(Questions[set]);
                }
              
                count++;
               
                if (set == 0)
                {

                    Console.WriteLine(" (a) Algiers\n (b) Belarus\n (c) Norway\n (d) Ciro");
                    Input = Console.ReadLine();
                    if (Input == "a" || Input == "A") { score++; }
                    Questions[0] = "o";
                    Console.Clear();
                }
                if (set == 1)
                {

                    Console.WriteLine(" (a) Algiers\n (b) Abuja\n (c) Tirana\n (d) Yaonde");
                    Input = Console.ReadLine();
                    if (Input == "c" || Input == "C") { score++; }
                    Questions[1] = "o";
                    Console.Clear();
                }
                if (set == 2)
                {

                    Console.WriteLine(" (a) Skopje\n (b) Ottawa\n (c) Uranus\n (d) Brasilia");
                    Input = Console.ReadLine();
                    if (Input == "d" || Input == "D") { score++; }
                    Questions[2] = "o";
                    Console.Clear();
                }
                if (set == 3)
                {

                    Console.WriteLine(" (a) Belaus\n (b) Minsk\n (c) congo\n (d) jerusalem");
                    Input = Console.ReadLine();
                    if (Input == "b" || Input == "B") { score++; }
                    Questions[3] = "o";
                    Console.Clear();
                }
                if (set == 4)
                {

                    Console.WriteLine(" (a) Brocks\n (b) Bruselle\n (c) Brussels\n (d) Minsk");
                    Input = Console.ReadLine();
                    if (Input == "c" || Input == "C") { score++; }
                    Questions[4] = "o";
                    Console.Clear();
                }
                if (set == 5)
                {

                    Console.WriteLine(" (a) San Jose\n (b) Belar\n (c) wayig\n (d) Ciro");
                    Input = Console.ReadLine();
                    if (Input == "a" || Input == "A") { score++; }
                    Questions[5] = "o";
                    Console.Clear();
                }
                if (set == 6)
                {

                    Console.WriteLine(" (a) Jews\n (b) Gentine\n (c) Cairo\n (d) Ciruso");
                    Input = Console.ReadLine();
                    if (Input == "c" || Input == "C") { score++; }
                    Questions[6] = "o";
                    Console.Clear();
                }
                if (set == 7)
                {

                    Console.WriteLine(" (a) Arius\n (b) Helsinki\n (c) Ottawa\n (d) Cumse");
                    Input = Console.ReadLine();
                    if (Input == "b" || Input == "B") { score++; }
                    Questions[7] = "o";
                    Console.Clear();
                }
                if (set == 8)
                {

                    Console.WriteLine(" (a) Alfganistan\n (b) Africa\n (c) Congo\n (d) Yaounde");
                    Input = Console.ReadLine();
                    if (Input == "d" || Input == "D") { score++; }
                    Questions[8] = "o";
                    Console.Clear();
                }
                if (set == 9)
                {

                    Console.WriteLine(" (a) None \n (b) Budapest\n (c) Option A\n (d) southafrica");
                    Input = Console.ReadLine();
                    if (Input == "B" || Input == "B") { score++; }
                    Questions[9] = "o";
                    Console.Clear();
                }
                if (set == 10)
                {

                    Console.WriteLine(" (a) None\n (b) Iraq\n (c) Abuja\n (d) Jerusalem");
                    Input = Console.ReadLine();
                    if (Input == "d" || Input == "D") { score++; }
                    Questions[10] = "o";
                    Console.Clear();
                }
                if (set == 11)
                {

                    Console.WriteLine(" (a) Abuja\n (b) Belarus\n (c) Ciro\n (d) ottawa");
                    Input = Console.ReadLine();
                    if (Input == "a" || Input == "A") { score++; }
                    Questions[11] = "o";
                    Console.Clear();
                }
                if (set == 12)
                {

                    Console.WriteLine(" (a) Tokyo\n (b) saner\n (c) Nairobi\n (d) Prohgst");
                    Input = Console.ReadLine();
                    if (Input == "c" || Input == "C") { score++; }
                    Questions[12] = "o";
                    Console.Clear();
                }
                if (set == 13)
                {

                    Console.WriteLine(" (a) Altie\n (b) Dakar\n (c) Senegal\n (d) soweto");
                    Input = Console.ReadLine();
                    if (Input == "b" || Input == "B") { score++; }
                    Questions[13] = "o";
                    Console.Clear();
                }
                if (set == 14)
                {

                    Console.WriteLine(" (a) Mexican\n (b) Mexico\n (c) Mexico City\n (d) Mexicano");
                    Input = Console.ReadLine();
                    if (Input == "c" || Input == "C") { score++; }
                    Questions[14] = "o";
                    Console.Clear();
                }
                if (set == 15)
                {

                    Console.WriteLine(" (a) Ahola\n (b) Seritus\n (c) Daura\n (d) Doha");
                    Input = Console.ReadLine();
                    if (Input == "d" || Input == "D") { score++; }
                    Questions[15] = "o";
                    Console.Clear();
                }
                if (set == 16)
                {

                    Console.WriteLine(" (a) Tokyo\n (b) chinochow\n (c) Singapore\n (d) None");
                    Input = Console.ReadLine();
                    if (Input == "a" || Input == "A") { score++; }
                    Questions[16] = "o";
                    Console.Clear();
                }
                if (set == 17)
                {

                    Console.WriteLine(" (a) Oslo\n (b) Belarus\n (c) Monaco\n (d) Ciro");
                    Input = Console.ReadLine();
                    if (Input == "a" || Input == "A") { score++; }
                    Questions[17] = "o";
                    Console.Clear();
                }
                if (set == 18)
                {

                    Console.WriteLine(" (a) Turin\n (b) Lima\n (c) Manchester\n (d) paris");
                    Input = Console.ReadLine();
                    if (Input == "b" || Input == "B") { score++; }
                    Questions[18] = "o";
                    Console.Clear();
                }
                if (set == 19)
                {

                    Console.WriteLine(" (a) Aoweto\n (b) Cuba\n (c) Monte Carlo\n (d) Mumbabu");
                    Input = Console.ReadLine();
                    if (Input == "c" || Input == "C") { score++; }
                    Questions[19] = "o";
                    Console.Clear();
                }

                if (count > 10)
                {
                    score = (score * 100) / 10;
                    if (score < 50) { Console.WriteLine("\t\t\t\t\tYou scored " + score + "% " + Name + " \n\t\t\tYour Score is Below Average Better luck next Time"); }
                    else
                    {
                        Console.WriteLine("\t\t\tYour score is {0}", score + "% Congratulations you passed " + Name);
                    }
                start:
                    Console.WriteLine("\n\tDo you wish to play again?\n>> Press Y for Yes\n>>Press N for no ");
                    Input = Console.ReadLine();
                    if (Input == "Y" || Input == "y")
                    {
                        playagain = true;
                        Console.Clear();

                    }
                    else if (Input == "n" || Input == "N")
                    { playagain = false; }
                    else { Console.WriteLine("Please enter N or Y"); goto start; }
                }

            }
        }

    }
}




