using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ConsoleApplication1
{
    class Program
    {
    
        static void Main(string[] args)
        {
            int[] last_next_posision = new int[2];
            int[] apple_posision = new int[2];
   
            comunication_of_player talking = new comunication_of_player();

            consol_print EL_OF_consol_print = new consol_print();

            constants_of_sneak sneek = new constants_of_sneak();
            
            ConsoleKeyInfo key_info;

            Geolation_direction new_navigation = new Geolation_direction();
            set_random_apple new_apple = new set_random_apple();
                

            Console.SetWindowSize(sneek.width_of_window, sneek.height_of_window);

            Console.ForegroundColor = ConsoleColor.Green;


            talking.show_9gag(sneek.width_of_window, sneek.height_of_window, EL_OF_consol_print);

            talking.change_settings(sneek, EL_OF_consol_print);

            apple_posision = new_apple.do_apple_pozision(sneek.DS, sneek.size_of_sneak, sneek.width_of_window, sneek.height_of_window);
            
            EL_OF_consol_print.print_DS(sneek.DS, sneek.sneaks_boddy, sneek.size_of_sneak, apple_posision, sneek.char_of_apple);

            EL_OF_consol_print.print_window(sneek.width_of_window, sneek.height_of_window);

            key_info = Console.ReadKey(true);
            do
            {
                last_next_posision[0] = sneek.DS[0, 0];
                last_next_posision[1] = sneek.DS[1, 0];


                if (Console.KeyAvailable == true)
                {
                    key_info = Console.ReadKey(true);
                }

                Thread.Sleep(sneek.speed_of_sneak);

                if(key_info.Key == ConsoleKey.Escape)
                    key_info = Console.ReadKey(true);
                else
                    if (key_info.Key == ConsoleKey.RightArrow && sneek.last_comand == 'r') {last_next_posision = new_navigation.navigation(last_next_posision, 'r'); sneek.last_comand = 'r';}
                    else
                        if (key_info.Key == ConsoleKey.DownArrow && sneek.last_comand == 'r') {last_next_posision = new_navigation.navigation(last_next_posision, 'd'); sneek.last_comand = 'd';}
                        else
                            if (key_info.Key == ConsoleKey.LeftArrow && sneek.last_comand == 'r') {last_next_posision = new_navigation.navigation(last_next_posision, 'r'); sneek.last_comand = 'r';}
                            else
                                if (key_info.Key == ConsoleKey.UpArrow && sneek.last_comand == 'r') {last_next_posision = new_navigation.navigation(last_next_posision, 'u'); sneek.last_comand = 'u';}
                                else//----------------------------------------------------------------------------------------------------------------------------------
                                    if (key_info.Key == ConsoleKey.RightArrow && sneek.last_comand == 'd') {last_next_posision = new_navigation.navigation(last_next_posision, 'r'); sneek.last_comand = 'r';}
                                    else
                                        if (key_info.Key == ConsoleKey.DownArrow && sneek.last_comand == 'd') {last_next_posision = new_navigation.navigation(last_next_posision, 'd'); sneek.last_comand = 'd';}
                                        else
                                            if (key_info.Key == ConsoleKey.LeftArrow && sneek.last_comand == 'd') {last_next_posision = new_navigation.navigation(last_next_posision, 'l'); sneek.last_comand = 'l';}
                                            else
                                                if (key_info.Key == ConsoleKey.UpArrow && sneek.last_comand == 'd') {last_next_posision = new_navigation.navigation(last_next_posision, 'd'); sneek.last_comand = 'd';}
                                                else//----------------------------------------------------------------------------------------------------------------------------------
                                                    if (key_info.Key == ConsoleKey.RightArrow && sneek.last_comand == 'l') {last_next_posision = new_navigation.navigation(last_next_posision, 'l'); sneek.last_comand = 'l';}
                                                    else
                                                        if (key_info.Key == ConsoleKey.DownArrow && sneek.last_comand == 'l') {last_next_posision = new_navigation.navigation(last_next_posision, 'd'); sneek.last_comand = 'd';}
                                                        else
                                                            if (key_info.Key == ConsoleKey.LeftArrow && sneek.last_comand == 'l') {last_next_posision = new_navigation.navigation(last_next_posision, 'l'); sneek.last_comand = 'l';}
                                                            else
                                                                if (key_info.Key == ConsoleKey.UpArrow && sneek.last_comand == 'l') {last_next_posision = new_navigation.navigation(last_next_posision, 'u'); sneek.last_comand = 'u';}
                                                                else//----------------------------------------------------------------------------------------------------------------------------------
                                                                    if (key_info.Key == ConsoleKey.RightArrow && sneek.last_comand == 'u') {last_next_posision = new_navigation.navigation(last_next_posision, 'r'); sneek.last_comand = 'r';}
                                                                    else
                                                                        if (key_info.Key == ConsoleKey.DownArrow && sneek.last_comand == 'u') {last_next_posision = new_navigation.navigation(last_next_posision, 'u'); sneek.last_comand = 'u';}
                                                                        else
                                                                            if (key_info.Key == ConsoleKey.LeftArrow && sneek.last_comand == 'u') {last_next_posision = new_navigation.navigation(last_next_posision, 'l'); sneek.last_comand = 'l';}
                                                                            else
                                                                                if (key_info.Key == ConsoleKey.UpArrow && sneek.last_comand == 'u') { last_next_posision = new_navigation.navigation(last_next_posision, 'u'); sneek.last_comand = 'u'; }
                                                                                else
                                                                                { last_next_posision = new_navigation.navigation(last_next_posision, sneek.last_comand);} //zapis' izlishnyaya
                
                EL_OF_consol_print.move(sneek.DS, last_next_posision, sneek.size_of_sneak);
                EL_OF_consol_print.print_DS(sneek.DS, sneek.sneaks_boddy, sneek.size_of_sneak, apple_posision, sneek.char_of_apple);
                EL_OF_consol_print.print_window(sneek.width_of_window, sneek.height_of_window);
                EL_OF_consol_print.print_level(sneek.players_level);

                if (last_next_posision[0] == sneek.width_of_window - 1 || last_next_posision[1] == sneek.height_of_window - 2 || last_next_posision[0] == 0 || last_next_posision[1] == 0)
                {
                    new_apple.game_over(sneek.width_of_window, sneek.players_name, sneek.players_level);
                    break;
                }


                if (last_next_posision[0] == apple_posision[0] && last_next_posision[1] == apple_posision[1])
                {
                    apple_posision = new_apple.do_apple_pozision(sneek.DS, sneek.size_of_sneak, sneek.width_of_window, sneek.height_of_window);
                    sneek.players_level++;
                    
                    sneek.change_sneaks_boddy(sneek.sneaks_boddy + '*');
                    sneek.construction_sneeks_states();
                }
            } while (true);
           
        }
    }

    class Geolation_direction
    {
        public int[] navigation(int[] last_posision, char nav)
        {
 
            switch (nav)
            {
                case 'r': last_posision[0]++; break;
                case 'd': last_posision[1]++; break;
                case 'l': last_posision[0]--; break;
                case 'u': last_posision[1]--; break;

                    
                //default:  return last_posision[]; break;
            }
            return last_posision;            
        }

    }

    class consol_print
    {
        
        public void move( int[,] DS, int[] next_posision, int size_of_sneak)
        {
            
            
            for (int i = size_of_sneak - 1; i != 0; i--)
            {
               DS[0, i] = DS[0, i-1];
               DS[1, i] = DS[1, i-1];
            }

            DS[0, 0] = next_posision[0];
            DS[1, 0] = next_posision[1];

        }

        public void print_DS(int[,] DS, string sneaks_boddy, int size_of_sneak, int[] apple_posision,char apple)// izlishnee peremennoie
        {
            Console.Clear();
            for (int i = 0; i < size_of_sneak; i++)
            {
                Console.SetCursorPosition(DS[0, i], DS[1, i]);
                Console.Write(sneaks_boddy[size_of_sneak - i - 1]);
            }
            Console.SetCursorPosition(apple_posision[0],apple_posision[1]);
            Console.Write(apple);
     
        }

        public void print_window(int width_of_window, int height_of_window )// izlishnee peremennoie
        {

            
            for (int i = 0; i < height_of_window - 1; i++)
            {
                Console.SetCursorPosition(0,i);
                Console.Write("|");
                Console.SetCursorPosition(width_of_window - 1, i);
                Console.Write("|");
            }
                Console.SetCursorPosition(0,0);
                Console.Write("--------------------------------------------------------------------------------");
                Console.SetCursorPosition(0, height_of_window - 2);
                Console.Write("--------------------------------------------------------------------------------");
        }

        public void print_level(int level)// izlishnee peremennoie
        {
                Console.SetCursorPosition(0, 0);
                Console.Write("level: ");
                Console.Write(level);
        }
    }

    class constants_of_sneak
    {
        public int size_of_sneak = 10;

        public int players_level = 0;

        public int speed_of_sneak = 150;

        public string sneaks_boddy;

        public string players_name = "void";

        public int width_of_window = 80;

        public int height_of_window = 25;

        public int[,] DS;

        public char last_comand = 'r';

        public char char_of_apple = '@';

        public void constructor()
        {
            DS = new int[2, size_of_sneak];

            for (int i = 0; i < size_of_sneak; i++)
            {
                DS[0, i] = size_of_sneak - i;
                DS[1, i] = 12;
            }
        }

        public void construction_sneeks_states()
        {

            int[,] new_DS = new int[2, size_of_sneak];

            for (int i = 0; i < size_of_sneak - 1; i++)
            {
               new_DS[0,i] = DS[0, i];
               new_DS[1,i] = DS[1, i];
            }

            DS = new int[2, size_of_sneak];

            for (int i = 0; i < size_of_sneak - 1; i++)
            {
                DS[0, i] = new_DS[0, i];
                DS[1, i] = new_DS[1, i];
            }


        }

        public void change_sneaks_boddy(string new_boddy_of_sneak)
        {
            if (new_boddy_of_sneak.Length != 0)
            {
                this.size_of_sneak = new_boddy_of_sneak.Length;

                this.sneaks_boddy = new_boddy_of_sneak;
            }
    
        }
    }

    class comunication_of_player
    {
        public void show_9gag(int width_of_window, int height_of_window, consol_print EL_OF_consol_print)
        {
            EL_OF_consol_print.print_window(width_of_window, height_of_window);

            Console.SetCursorPosition(width_of_window / 3 , 2);
            Console.WriteLine("        // \\\\");
            Console.SetCursorPosition(width_of_window / 3, 3);
            Console.WriteLine("      //     \\\\");
            Console.SetCursorPosition(width_of_window / 3, 4);
            Console.WriteLine("    //         \\\\");
            Console.SetCursorPosition(width_of_window / 3, 5);
            Console.WriteLine("  //             \\\\");
            Console.SetCursorPosition(width_of_window / 3, 6);
            Console.WriteLine("//                 \\\\");
            Console.SetCursorPosition(width_of_window / 3, 7);
            Console.WriteLine("\\\\                 //|");
            Console.SetCursorPosition(width_of_window / 3, 8);
            Console.WriteLine("  \\\\             // ||");
            Console.SetCursorPosition(width_of_window / 3, 9);
            Console.WriteLine("    \\\\         //   ||");
            Console.SetCursorPosition(width_of_window / 3, 10);
            Console.WriteLine("      \\\\     //     ||");
            Console.SetCursorPosition(width_of_window / 3, 11);
            Console.WriteLine("        \\\\ //       ||");
            Console.SetCursorPosition(width_of_window / 3, 12);
            Console.WriteLine("                    ||");
            Console.SetCursorPosition(width_of_window / 3, 13);
            Console.WriteLine("\\\\                 //");
            Console.SetCursorPosition(width_of_window / 3, 14);
            Console.WriteLine("  \\\\             //");
            Console.SetCursorPosition(width_of_window / 3, 15);
            Console.WriteLine("    \\\\         //");
            Console.SetCursorPosition(width_of_window / 3, 16);
            Console.WriteLine("      \\\\     //");
            Console.SetCursorPosition(width_of_window / 3, 17);
            Console.WriteLine("        \\\\ //");

            Console.SetCursorPosition(width_of_window / 2 - 10, 19);
            Console.WriteLine("Special for 9gag");
            Thread.Sleep(4000);
            Console.Clear();

            EL_OF_consol_print.print_window(width_of_window, height_of_window);

            Console.SetCursorPosition(width_of_window / 4, 5);
            Console.WriteLine("   ______                 / /          / /");
            Console.SetCursorPosition(width_of_window / 4, 6);
            Console.WriteLine("  / -----\\\\          ----/ /----------/-/----");
            Console.SetCursorPosition(width_of_window / 4, 7);
            Console.WriteLine(" //                 ----/ /----------/-/----");
            Console.SetCursorPosition(width_of_window / 4, 8);
            Console.WriteLine("||                     / /          / /");
            Console.SetCursorPosition(width_of_window / 4, 9);
            Console.WriteLine("||                    / /          / /");
            Console.SetCursorPosition(width_of_window / 4, 10);
            Console.WriteLine("||                   / /          / /");
            Console.SetCursorPosition(width_of_window / 4, 11);
            Console.WriteLine("||                  / /          / /");
            Console.SetCursorPosition(width_of_window / 4, 12);
            Console.WriteLine("||                 / /          / /");
            Console.SetCursorPosition(width_of_window / 4, 13);
            Console.WriteLine("||            ----/ /----------/ /----");
            Console.SetCursorPosition(width_of_window / 4, 14);
            Console.WriteLine(" \\\\          ----/ /----------/ /----");
            Console.SetCursorPosition(width_of_window / 4, 15);
            Console.WriteLine("  \\\\_____//     / /          / /");
            Console.SetCursorPosition(width_of_window / 4, 16);
            Console.WriteLine("   -------");

            Thread.Sleep(4000);
            Console.Clear();
        }


        private void get_players_name(constants_of_sneak snake, consol_print EL_OF_consol_print)
        {
            string str_yes_no;
            string user_name;
            EL_OF_consol_print.print_window(snake.width_of_window, snake.height_of_window);
            Console.SetCursorPosition(snake.width_of_window / 2 - 20, 5);
            Console.WriteLine(" [0] ...back");
            Console.SetCursorPosition(snake.width_of_window / 2 - 20, 6);
            Console.WriteLine(" [1] Enter name ");
            Console.SetCursorPosition(snake.width_of_window / 2 - 18, 7);
            str_yes_no = Console.ReadLine();

            switch (str_yes_no[0])
            { 
                case '1':
                    do{
                        Console.Clear();
                        EL_OF_consol_print.print_window(snake.width_of_window, snake.height_of_window);
                        Console.SetCursorPosition(snake.width_of_window / 2 - 20, 5);
                        Console.WriteLine("Enter your name please");
                        Console.SetCursorPosition(snake.width_of_window / 2 - 20, 6);
                        user_name = Console.ReadLine();

                    }while(user_name.Length < 2);

                    Console.SetCursorPosition(snake.width_of_window / 2 - 20, 7);
                    Console.WriteLine("Thank you {0}", user_name);
                    snake.players_name = user_name;
                    snake.change_sneaks_boddy(snake.players_name);
                    snake.constructor();
                    break;
               
                default:  
                    Console.Clear();
                    EL_OF_consol_print.print_window(snake.width_of_window, snake.height_of_window);
                    Console.SetCursorPosition(snake.width_of_window / 2 - 20, 5);
                    Console.WriteLine("User name will be 9GAGER");

                    snake.change_sneaks_boddy("**********");
                    snake.constructor();
                    snake.players_name = "9GAGER";
                    break;
            }
            Thread.Sleep(2000);
        }

        private void change_color(constants_of_sneak snake, consol_print EL_OF_consol_print)
        {
            string str_yes_no;
            
            EL_OF_consol_print.print_window(snake.width_of_window, snake.height_of_window);
            Console.SetCursorPosition(snake.width_of_window / 2 - 20, 5);
            Console.WriteLine(" [0] ...back");
            Console.SetCursorPosition(snake.width_of_window / 2 - 20, 6);
            Console.WriteLine(" [1] Chane color ");
            Console.SetCursorPosition(snake.width_of_window / 2 - 18, 7);
            str_yes_no = Console.ReadLine();
            
            switch (str_yes_no[0])
            {
                case '1':

                    string color;
                    do
                    {
                        Console.Clear();
                        EL_OF_consol_print.print_window(snake.width_of_window, snake.height_of_window);

                        Console.SetCursorPosition(snake.width_of_window / 2 - 20, 5);
                        Console.WriteLine("Enter color [b, g, y, r]");
                        Console.SetCursorPosition(snake.width_of_window / 2 - 20, 6);
                        color = Console.ReadLine();

                    } while (!(color[0] == 'b'||color[0] == 'g'||color[0] == 'y'||color[0] == 'r'));
                              
                    if(color[0] == 'b' || color[0] == 'B')
                        Console.ForegroundColor = ConsoleColor.Blue;

                    else
                        if(color[0] == 'g' || color[0] == 'G')
                            Console.ForegroundColor = ConsoleColor.Green;
                        else
                            if(color[0] == 'y' || color[0] == 'Y')
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            else
                                if(color[0] == 'r' || color[0] == 'R')
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    break;
                default:
                    Console.Clear();
                    EL_OF_consol_print.print_window(snake.width_of_window, snake.height_of_window);
                    Console.SetCursorPosition(snake.width_of_window / 2 - 20, 5);
                    Console.WriteLine("The color will default");
                    break;
            }
            Thread.Sleep(2000);
        }

        private void change_apple(constants_of_sneak snake, consol_print EL_OF_consol_print)
        {
            string str_yes_no;

            EL_OF_consol_print.print_window(snake.width_of_window, snake.height_of_window);
            Console.SetCursorPosition(snake.width_of_window / 2 - 20, 5);
            Console.WriteLine(" [0] ...back");
            Console.SetCursorPosition(snake.width_of_window / 2 - 20, 6);
            Console.WriteLine(" [1] Chane apple ");
            Console.SetCursorPosition(snake.width_of_window / 2 - 18, 7);
            str_yes_no = Console.ReadLine();

            switch (str_yes_no[0])
            {
                case '1':

                    string char_og_apple;
                    do
                    {
                        Console.Clear();
                        EL_OF_consol_print.print_window(snake.width_of_window, snake.height_of_window);

                        Console.SetCursorPosition(snake.width_of_window / 2 - 20, 5);
                        Console.WriteLine("Enter character of apple");
                        Console.SetCursorPosition(snake.width_of_window / 2 - 20, 6);
                        char_og_apple = Console.ReadLine();

                    } while (char_og_apple.Length < 1);

                    snake.char_of_apple = char_og_apple[0];
                    Console.SetCursorPosition(snake.width_of_window / 2 - 20, 7);
                    Console.WriteLine("Ok apple will be '{0}'", char_og_apple[0]);
                    break;

                default:
                    Console.Clear();
                    EL_OF_consol_print.print_window(snake.width_of_window, snake.height_of_window);
                    Console.SetCursorPosition(snake.width_of_window / 2 - 20, 5);
                    Console.WriteLine("The apple will default");
                    break;
            }
            Thread.Sleep(2000);
        }

        private void change_speed(constants_of_sneak snake, consol_print EL_OF_consol_print)
        {
            string str_yes_no;

            EL_OF_consol_print.print_window(snake.width_of_window, snake.height_of_window);
            Console.SetCursorPosition(snake.width_of_window / 2 - 20, 5);
            Console.WriteLine(" [0] ...back");
            Console.SetCursorPosition(snake.width_of_window / 2 - 20, 6);
            Console.WriteLine(" [1] Chane speed ");
            Console.SetCursorPosition(snake.width_of_window / 2 - 18, 7);
            str_yes_no = Console.ReadLine();

            switch (str_yes_no[0])
            {
                case '1':

                    string speed;
                    do
                    {
                        Console.Clear();
                        EL_OF_consol_print.print_window(snake.width_of_window, snake.height_of_window);

                        Console.SetCursorPosition(snake.width_of_window / 2 - 20, 5);
                        Console.WriteLine("Enter speed Slow - [s], Medium - [m], Fast - [f]");
                        Console.SetCursorPosition(snake.width_of_window / 2 - 20, 6);
                        speed = Console.ReadLine();

                    } while (!(speed[0] == 's' || speed[0] == 'm' || speed[0] == 'f'));

                    if (speed[0] == 's')
                        snake.speed_of_sneak = 200;
                    else
                        if (speed[0] == 'm')
                            snake.speed_of_sneak = 150;
                        else
                            snake.speed_of_sneak = 100;

                    Console.SetCursorPosition(snake.width_of_window / 2 - 20, 7);
                    Console.WriteLine("Ok speed of snake will be '{0}'", speed[0]);
                    break;

                default:
                    Console.Clear();
                    EL_OF_consol_print.print_window(snake.width_of_window, snake.height_of_window);
                    Console.SetCursorPosition(snake.width_of_window / 2 - 20, 5);
                    Console.WriteLine("Speed of snake will be default");
                    break;
            }
            Thread.Sleep(2000);
        }
        public  void change_settings(constants_of_sneak snake, consol_print EL_OF_consol_print)
        {
            char yes_no;
            string str_yes_no;
            bool cicle = true;

            Console.SetCursorPosition(snake.width_of_window / 2 - 20, 5);
            Console.WriteLine("Change settings and enter the name ?");

            yes_no = get_yes_no(snake.width_of_window / 2 - 20, 6);

            if (yes_no == 'y')
            {
                do
                {
                    Console.Clear();
                    EL_OF_consol_print.print_window(snake.width_of_window, snake.height_of_window);

                    Console.SetCursorPosition(snake.width_of_window / 2 - 20, 5);
                    Console.WriteLine(" [0] start");

                    Console.SetCursorPosition(snake.width_of_window / 2 - 20, 6);
                    Console.WriteLine(" [1] Change speed of snake");

                    Console.SetCursorPosition(snake.width_of_window / 2 - 20, 7);
                    Console.WriteLine(" [2] Change apple");

                    Console.SetCursorPosition(snake.width_of_window / 2 - 20, 8);
                    Console.WriteLine(" [3] Change color");

                    Console.SetCursorPosition(snake.width_of_window / 2 - 20, 9);
                    Console.WriteLine(" [4] Enter name");

                    Console.SetCursorPosition(snake.width_of_window / 2 - 18, 10);

                    str_yes_no = Console.ReadLine();
                    if (str_yes_no != "")
                    {

                        switch (str_yes_no[0])
                        {
                            case '1': Console.Clear(); change_speed(snake, EL_OF_consol_print); break;
                            case '2': Console.Clear(); change_apple(snake, EL_OF_consol_print); break;
                            case '3': Console.Clear(); change_color(snake, EL_OF_consol_print); break;
                            case '4': Console.Clear(); get_players_name(snake, EL_OF_consol_print); break;

                            default:
                                Console.Clear();
                                EL_OF_consol_print.print_window(snake.width_of_window, snake.height_of_window);
                                Console.SetCursorPosition(snake.width_of_window / 2 - 20, 5);
                                Console.WriteLine("Ok bye bye");
                                Thread.Sleep(2000); cicle = false;
                                break;
                        }
                    }
                } while (cicle);

            }
           
                Console.Clear();
                EL_OF_consol_print.print_window(snake.width_of_window, snake.height_of_window);

                if (snake.players_name == "void")
                {

                    snake.change_sneaks_boddy("**********");
                    snake.constructor();
                    snake.players_name = "9GAGER";
                }
                Console.Clear();
                EL_OF_consol_print.print_window(snake.width_of_window, snake.height_of_window);
                Console.SetCursorPosition(snake.width_of_window / 2 - 20, 5);
                Console.WriteLine("For pause press 'Escape'");
            Thread.Sleep(2000);
        }

        private char get_yes_no(int local_width_of_window, int local_height_of_window)
        {
            Console.SetCursorPosition(local_width_of_window, local_height_of_window);
            Console.Write("Please press 'y' or 'n' to continue [y]/[n]");
            Console.SetCursorPosition(local_width_of_window, local_height_of_window + 1);
            string yes_no = Console.ReadLine();
            if (yes_no != ""  && (yes_no[0] == 'y' || yes_no[0] == 'Y'))
            {
                Console.Clear();
                return 'y';
            }
            else
            {
                Console.Clear();
                return 'n';
            }
        }
    }


    class set_random_apple 
    {
        public int[] do_apple_pozision(int[,] DS,int size_of_sneak, int width_of_window, int height_of_window)
        {

            int width_of_apple;
            int height_of_apple;
            int[] apple_posision = new int[2];

            Random new_posission_of_apple = new Random();

            m1:// rewrite with while

            width_of_apple = new_posission_of_apple.Next(1, width_of_window - 2);
            height_of_apple = new_posission_of_apple.Next(1, height_of_window - 3);

            for (int i = 0; i < size_of_sneak; i++)
                    if (DS[0, i] == width_of_apple && DS[1, 0] == height_of_apple)
                    goto m1;


                apple_posision[0] = width_of_apple;
                apple_posision[1] = height_of_apple;
                return apple_posision;

        }

             public void game_over(int width_of_window, string player_name, int level)
        {

            Console.SetCursorPosition(width_of_window / 2, 6);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} LEVEL: {1}",player_name, level);

            for (int i = 0; i <= level; i++)
            {
                Console.SetCursorPosition(width_of_window / 2, i + 8);
                Console.WriteLine("WASTED");
                Thread.Sleep(300);
            }
            Console.ReadLine();
            

        }
    }
}

