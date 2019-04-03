using System;

namespace hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            play();
        }

        static void play(){
            System.Console.WriteLine("Please select a level! 1 2 3 4 or 5" );
            int level = Console.ReadKey().KeyChar;
            string[,] wordArr = new string[,]
            { 
                {
                    "growth","airplane","similar","fewer","palace","station","these","some","sudden","park",
                    "movie","buffalo","gravity","way","picture","breeze","package","look","behavior","organization"
                },
                {
                    "rose","rabbit","look","listen","author","goose","game","play","wool","expression",
                    "waste","guess","sat","ranch","result","arrange","relationship","replied","neighbor","tank"
                },
                {
                    "cream","exclaimed","wore","important","equally","mathematics","product","solve","chapter","tower",
                    "show","cook","bottom","citizen","salmon","fog","writing","personal","nature","speech"
                },
                {
                    "task","fully","troops","region","die","north","tape","these","dirty","advice",
                    "pair","forget","other","double","test","concerned","reach","pocket","built","everybody"
                },
                {
                    "Compressed air energy storage","External combustion engine","Fischer-Tropsch process","Habitat reduction","Grid energy storage",
                    "Savonius wind turbine","Thermal depolymerization","Water quality improvement","Vibration energy scavenging","Valence electrons",
                    "Geothermal exchange heat pump","Uranium","Unbalanced force","Small Sealed Transportable Autonomous Reactor (SSTAR)","Recycling nutrients",
                    "Piezoelectricity","Ocean thermal energy conversion","Nuclear fusion","Methanol economy","Magnetohydrodynamic"
                },

            };
        

            Random random = new Random();
            string word = "";
            word = wordArr[level, random.Next(0,20)];
            guessWord(word);
        }

        static void guessWord(string word)
        {
            char[] correct = new char[word.Length];
            string incorrect = "";
            int g = -1;
            int count = 0;
            bool result = false;
            for(int i = 0; i < word.Length; i++)
            {
                Console.Write("_ ");
                correct[i] = '_';             
            }
            Console.WriteLine();
            // Console.WriteLine($"Guess A Letter! You have {7-g} incorrect guesses left!");

            while(g < 7)
            {
                char guess = Console.ReadKey().KeyChar;
                System.Console.WriteLine();
                
                if(!word.Contains(guess))
                {
                    g++;
                    System.Console.WriteLine($"Incorrect Guess! You have {7-g} trials left");
                    incorrect += guess;
                    System.Console.WriteLine("Incorrect Guesses: "+ incorrect);
                    if(g == 0)
                    {
                        System.Console.WriteLine("______________");
                        System.Console.WriteLine("|           |");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                            
                    } else if(g == 1)
                    {
                        System.Console.WriteLine("______________");
                        System.Console.WriteLine("|           |");
                        System.Console.WriteLine("|           O");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                            
                    } else if(g == 2)
                    {
                        System.Console.WriteLine("______________");
                        System.Console.WriteLine("|           |");
                        System.Console.WriteLine("|           O");
                        System.Console.WriteLine("|           |");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                            
                    } else if(g == 3)
                    {
                        System.Console.WriteLine("______________");
                        System.Console.WriteLine("|           |");
                        System.Console.WriteLine("|           O");
                        System.Console.WriteLine("|          /|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                            
                    }  else if(g == 4)
                    {
                        System.Console.WriteLine("______________");
                        System.Console.WriteLine("|           |");
                        System.Console.WriteLine("|           O");
                        System.Console.WriteLine("|          /|\\");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                            
                    }   else if(g == 5)
                    {
                        System.Console.WriteLine("______________");
                        System.Console.WriteLine("|           |");
                        System.Console.WriteLine("|           O");
                        System.Console.WriteLine("|          /|\\");
                        System.Console.WriteLine("|          /");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                            
                    }  else if(g == 6)
                    {
                        System.Console.WriteLine("______________");
                        System.Console.WriteLine("|           |");
                        System.Console.WriteLine("|           O");
                        System.Console.WriteLine("|          /|\\");
                        System.Console.WriteLine("|          / \\");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        System.Console.WriteLine("|");
                        break;
                    }
                } 
                

                
                for(int i = 0; i < word.Length; i++)
                {
                    if(guess == word[i] && correct[i] == '_'){
                        correct[i] = guess;
                        count++;
                    } 
                }
                if(count == word.Length)
                {
                    result =  true;
                    System.Console.WriteLine(word);
                    break;
                }


                // Console.WriteLine("Correct Guesses: ");
                foreach(char c in correct)
                {
                    Console.Write(c+ " ");
                }
                Console.WriteLine();
                
            }
            if(result == true)
            {
                System.Console.WriteLine("You Win!");
                System.Console.WriteLine();
                System.Console.WriteLine("Do you wan play again? Yes | No");
                string answer = Console.ReadLine();
                if(answer.ToLower() == "yes"){
                    play();
                }
            } else{
                System.Console.WriteLine("You Lost!");
                System.Console.WriteLine("The word was "+word);
                System.Console.WriteLine();
                System.Console.WriteLine("Do you wan play again? Yes | No");
                string answer = Console.ReadLine();
                if(answer.ToLower() == "yes"){
                    play();
                }
            }
        }
    }
}
