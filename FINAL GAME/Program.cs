using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_GAME
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0; // variable for menu loop
            bool endGame = true; // variable for main game loop

            //menu loop starts
            while (menu != 1)
            {
                Console.Clear();
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                      Lion Order                                             ");
                Console.WriteLine("                         A Game Detailing The Keys To Success                                ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                 Miguel Favero Studios                                       ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("   ~~~~~~~                 Disclaimer, I know how to spell and                    ~~~~~~~    ");
                Console.WriteLine("   ~~~~~~~       any spelling/grammer mistakes in this game are intentional.      ~~~~~~~    ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("   ~~~~~~~~              Please enlarge the screen before playing.                ~~~~~~~    ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                     1)New Game                                              ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                       2) Quit                                               ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                string menuCheck = Console.ReadLine();
                int.TryParse(menuCheck, out menu); //change input into a integer variable

                if (menu == 1) //check input if correct
                {
                    Console.Clear();
                }
                else if (menu == 2)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Invalid input, please try again.");
                    Console.WriteLine("Press ENTER to continue."); //menu selection error message
                    Console.ReadLine();
                }

            }

            string playerChoiceCheck;
            int playerChoice = 0; //variables for player input for the rest of the game
            Player player = new Player(20, 0, 1); //calling new player, variables will always stay the same. variables for hp, score and level
            Enemy ChefDee = new Enemy(1, 3, 8, 150, 301); //calling a new enemy type, variables for HP, two damage variables and two score variables
            Enemy WaterBeast = new Enemy(2, 7, 10, 200, 450);


            //main game loop begins
            while (endGame == true)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("You look around in a daze not sure how you got here.");
                Console.WriteLine("You're standing on a marble floor, all around you are expensive things.");
                Console.WriteLine("All of a sudden someone enters the room. It's a big man with a fresh cut and a trimmed beard.");
                Console.WriteLine("He comes forward and opens his mouth to talk.");
                Console.WriteLine("");
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Stranger: Hello Beautiful, whatz ur name gurl? (Please Enter Username)");
                player.playerName = Console.ReadLine();

                while (player.playerName == null || player.playerName == "") //check username validity
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("USERNAME CAN NOT BE EMPTY.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Stranger: Hello Beautiful, whatz ur name gurl? (Please Enter Username)");
                    player.playerName = Console.ReadLine(); //assign username to variable in player class
                }

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("DJKhaled: My name is DJKhaled! Rid wit me through the journey of success {0}", player.playerName); // calling variable into a string
                Console.WriteLine("DJKhaled: First things first, you gotta start your day right.");
                Console.WriteLine("");
                Console.WriteLine("Your companion leaves the room, do you choose to follow or will you look around first?");
                Console.WriteLine("");
                Console.WriteLine("1 - to leave room~~~");
                Console.WriteLine("2 - to look around~~");
                playerChoiceCheck = Console.ReadLine();
                int.TryParse(playerChoiceCheck, out playerChoice);

                while (playerChoice != 1 && playerChoice != 2) // while loop for player choice validity
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, please try again.");
                    Console.WriteLine();
                    Console.WriteLine("");
                    Console.WriteLine("DJKhaled: My name is DJKhaled! Rid wit me through the journey of success {0}", player.playerName);
                    Console.WriteLine("DJKhaled: First things first, you gotta start your day right.");
                    Console.WriteLine("");
                    Console.WriteLine("Your companion leaves the room, do you choose to follow or will you look around first?");
                    Console.WriteLine("");
                    Console.WriteLine("1 - to leave room~~~");
                    Console.WriteLine("2 - to look around~~");
                    playerChoiceCheck = Console.ReadLine();
                    int.TryParse(playerChoiceCheck, out playerChoice);
                }

                //check player choice and adjust story accordingly 
                if (playerChoice == 1)
                {
                    Console.Clear();
                }
                else if (playerChoice == 2)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("As you take a look around, you see that you're in a large open area.");
                    Console.WriteLine("Although the area is big, you are surprised to see you're in a house. It looks like the entrance area.");
                    Console.WriteLine("You go over to a wall and take a look outside the window.");
                    Console.WriteLine("On either side down the whole street you see MASSIVE houses, so big you could almost call them mansions.");
                    Console.WriteLine("You try to leave through the front door but you see there is no handle as you swipe at air.");
                    Console.WriteLine();
                    Console.WriteLine("'This must be a dream.' you think to yourself. You turn around and go down the hallway you last saw DJKhaled going through.");
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                }

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You follow after this stranger, not knowing at all what got you here.");
                Console.WriteLine("Nevertheless, you're very impressed by the house.");
                Console.WriteLine("You both turn into a new room, this time a kitchen.");
                Console.WriteLine("There is a big island counter in the middle of the room and across two of the walls a counter extends.");
                Console.WriteLine();
                Console.WriteLine("DJKhaled: Yo Chef Dee what's good!");
                Console.WriteLine("A black lady of medium build turns around. She has long hair and wears a chefs attire.");
                Console.WriteLine("She starts to say what's for breakfast, the food ready on the table, but then she sees you.");
                Console.WriteLine("Chef Dee: A challenger eh? Only I can be the one to cook for DJ Khaled!!!! REEEEE");
                Console.WriteLine("She grabs a large knife that was on the counter and lunges at you from across the room! What do you do now!!!");
                Console.WriteLine();
                Console.WriteLine("1 - Grab the rolling pin on the counter.~~~~~~~~~~~");
                Console.WriteLine("2 - Spin on your heel and run as fast as you can~~~");
                playerChoiceCheck = Console.ReadLine(); //take player choice as string first
                int.TryParse(playerChoiceCheck, out playerChoice); // change player choice into a integer if possible

                while (playerChoice != 1 && playerChoice != 2)//player choice validity
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Invalid input, try again");
                    Console.WriteLine();
                    Console.WriteLine("She grabs a large knife that was on the counter and lunges at you from across the room! What do you do now!!!");
                    Console.WriteLine();
                    Console.WriteLine("1 - Grab the rolling pin on the counter.~~~~~~~~~~~~");
                    Console.WriteLine("2 - Spin on your heel and run as fast as you can.~~~");
                    playerChoiceCheck = Console.ReadLine();
                    int.TryParse(playerChoiceCheck, out playerChoice);
                }

                //add new weapon to player class, just changing the two damage variables
                if (playerChoice == 1)
                {
                    Player.playerDamageX = 1;
                    Player.playerDamageY = 10;
                }
                else if (playerChoice == 2)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("You spin as quickly as you can and run for the closest window, however, Chef Dee is quicker.");
                    Console.WriteLine("She is able to throw the knife and it hits you in the lower back.");
                    Console.WriteLine("As you crumple to the floor and Chef Dee stands over you victorious, all you hear from DJ Khaled is:");
                    Console.WriteLine();
                    Console.WriteLine("DJKhaled: The key to success is to not get stabbed in the back.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                    YOU ARE DEAD.                                                    ");
                    Console.WriteLine("Press ENTER to close the game.");
                    Console.ReadLine();
                    endGame = false;
                }

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You make a mad dash for the rolling pin, the head Chef getting closer to you with every heart beat.");
                Console.WriteLine("You grab the pin and raise it above your head just in time to block the blade that was swooping down.");
                Console.WriteLine("You jump back and hold the pin at arms length, ready to fight to the death!");
                Console.WriteLine();
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine();

                while (player.playerHealth > 0 && ChefDee.enemyHealth > 0)//battle system, keep loop running while both fighters alive
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("You attack for {0} damage.", player.weaponDMG()); //call forward RNG for player
                    Console.WriteLine("ChefDee attacks for {0} damage.", ChefDee.enemyDMG());//call forward RNG for enemy
                    Console.WriteLine();
                    if (player.weaponDMG() > 6) //some custom stuff for crits
                    {
                        Console.WriteLine("Critical strike!!");

                    }else if (ChefDee.enemyDMG() > 1)
                    {
                        Console.WriteLine("Chef Dee crits!");
                    }
                    ChefDee.enemyHealth = ChefDee.enemyHealth - player.weaponDMG(); // damage calculation, hp remaining
                    player.playerHealth = player.playerHealth - ChefDee.enemyDMG();
                    Console.WriteLine("You have {0} hp left.", player.playerHealth); //show player how much health remains
                    Console.WriteLine("ChefDee has {0} hp left.", ChefDee.enemyHealth);
                    Console.WriteLine();

                    if (player.playerHealth > 0 && ChefDee.enemyHealth > 0) //if fighters still alive, fight again!
                    {
                        Console.WriteLine("Press ENTER to attack again!");
                        Console.ReadLine();
                    }

                }

                if (player.playerHealth < 1)//if player lost fight, show this
                {
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Chef Dee strikes quickly and true, the blade catching your arm.");
                    Console.WriteLine("You hesitate breifly from the pain but it's all the time your enemy needs.");
                    Console.WriteLine("She grabs your hair and pulls you down, before bringing the blade down to your neck.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                    YOU ARE DEAD.                                                    ");
                    Console.WriteLine("Press ENTER to close the game.");
                    Console.ReadLine();
                    endGame = false;//you died. exit main game loop

                } else if (ChefDee.enemyHealth < 1)//enemy died, continue with story
                {
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("You hear the crunch of bones breaking as you smash the rolling pin down once again.");
                    Console.WriteLine("Chef Dee falls to her knees and drops her weapon. She brings her arms up in defense but you show no mercy.");
                    Console.WriteLine("Her lifeless body falls to the ground as you gasp for breath. The battle took a lot out of you.");
                    Console.WriteLine();
                    Console.WriteLine("~~Chef Dee's swag seeps out of her and is drawn to you. Your street cred increases by 2.~~");
                    player.playerLevel = player.playerLevel + 2;//add onto players level
                    player.playerScore = ChefDee.scoreGive();
                    Console.WriteLine("Reputation = {0}", player.playerLevel);//show player level
                    Console.WriteLine("Score = {0}", player.playerScore);
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();
                }

                //after Chef Dee battle arc
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("DJKhaled: Alright homie that was savage. Chef Dee didn't deserve this but, such is life.");
                Console.WriteLine("DJKhaled: Let's eat BEKFAST. I'm starving!");
                Console.WriteLine();
                Console.WriteLine("You both sit down at the island counter and dig in. This is a meal fit for kings!");
                Console.WriteLine("You feel a new wave of power inside, healing you as it washes over.");
                Player.hpGainX = 1; Player.hpGainY = 6; //same line because I find it better. Giving values to the healthGain method
                player.playerHealth += player.healthGain(); //health gain. max hp can climb
                Console.WriteLine("Health gain = {0}", player.healthGain());
                Console.WriteLine("Health = {0}", player.playerHealth);
                Console.WriteLine("Press ENTER to continue."); //continue
                Console.ReadLine();

                Console.Clear(); //more story
                Console.WriteLine();
                Console.WriteLine("DJKhaled: You gotta take cara urself gurl.");
                Console.WriteLine("DJKhaled: Always wash urself, keep ur face sauft.");
                Console.WriteLine("DJKhaled: Havin sauft skin is a key to success.");
                Console.WriteLine();
                Console.WriteLine("You follow DJKhaled to the downstairs lavatory, still shaken from the recent events.");
                Console.WriteLine("'Maybe he's right, if I wash my face I will be able to think clearly and get through this mess', you decide.");
                Console.WriteLine();
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine();

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You turn into a new hallway and at the end of the hallway you see an open door.");
                Console.WriteLine("You're interested to see water flowing out of the room. DJKhaled is walking towards it.");
                Console.WriteLine("Following behind DJKhaled, you look around yourself.");
                Console.WriteLine("You see a toolbox on top of a chest in the hallway. It has a dirty trowel beside it.");
                Console.WriteLine();
                Console.WriteLine("1 - Keep on walking down the corridor. That leak might be serious. `~~");
                Console.WriteLine("2 - Take a look inside the toolbox. It'll only take a minute. ~~~~~~~~");
                playerChoiceCheck = Console.ReadLine();
                int.TryParse(playerChoiceCheck, out playerChoice);

                while (playerChoice != 1 && playerChoice != 2)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Try again.");
                    Console.WriteLine();
                    Console.WriteLine("You see a toolbox on top of a chest in the hallway. It has a dirty trowel beside it.");
                    Console.WriteLine();
                    Console.WriteLine("1 - Keep on walking down the corridor. That leak might be serious. `~~");
                    Console.WriteLine("2 - Take a look inside the toolbox. It'll only take a minute. ~~~~~~~~");
                    playerChoiceCheck = Console.ReadLine();
                    int.TryParse(playerChoiceCheck, out playerChoice);
                }

                if (playerChoice == 1)
                {
                    Console.Clear();
                }
                else if (playerChoice == 2)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("You open the medium sized metal toolbox. It is a stained red color and kind of rusty.");
                    Console.WriteLine("You find various different gardening tools. DJKhaled is known to love his flowers.");
                    Console.WriteLine("There is a dirty pair of gloves inside the toolbox. They have good grip.");
                    Console.WriteLine();
                    Console.WriteLine("1 - Pick up the trowel. ~~~");
                    Console.WriteLine("2 - Take the gloves. ~~~~~~");
                    playerChoiceCheck = Console.ReadLine();
                    int.TryParse(playerChoiceCheck, out playerChoice);

                    while (playerChoice != 1 && playerChoice != 2)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Invalid input. Try again.");
                        Console.WriteLine();
                        Console.WriteLine("You open the medium sized metal toolbox. It is a stained red color and kind of rusty.");
                        Console.WriteLine("You find various different gardening tools. DJKhaled is known to love his flowers.");
                        Console.WriteLine("There is a dirty pair of gloves inside the toolbox. They have good grip.");
                        Console.WriteLine();
                        Console.WriteLine("1 - Pick up the trowel. ~~~");
                        Console.WriteLine("2 - Take the gloves. ~~~~~~");
                        playerChoiceCheck = Console.ReadLine();
                        int.TryParse(playerChoiceCheck, out playerChoice);
                    }

                    if (playerChoice == 1)
                    {
                        Player.playerDamageX = 1;
                        Player.playerDamageY = 6; //new weapon
                        Console.WriteLine();
                        Console.WriteLine("You take the trowel and move on.");
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to continue.");
                        Console.ReadLine();
                    }
                    else if (playerChoice == 2)
                    {
                        player.Inventory = "GLOVES"; //giving item
                        Console.WriteLine();
                        Console.WriteLine("You take the gloves and move on.");
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to continue.");
                        Console.ReadLine();
                    }
                }

                //bathtub battle arc beings
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Walking into the bathroom you are surprised to see an overfilling bathtub; water leaking already over the top.");
                Console.WriteLine("You wade over through the knee-high pool to DJKhaled by the basin.");
                Console.WriteLine("DJKhaled: Money is the key to success.");
                Console.WriteLine("DJKhaled: Witout money, you can't pay fo ur water.");
                Console.WriteLine();
                Console.WriteLine("'This is ridiculous!', you say out loud.");
                Console.WriteLine();
                Console.WriteLine("1 - Turn off the tap. Leaving it on would be insane! ~~~~~~~~~~~~~~~~"); 
                Console.WriteLine("2 - Ignore the bathtub. The sooner you wash your face the better. ~~~");
                playerChoiceCheck = Console.ReadLine();
                int.TryParse(playerChoiceCheck, out playerChoice);

                while (playerChoice != 1 && playerChoice != 2)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Try again.");
                    Console.WriteLine();
                    Console.WriteLine("'This is ridiculous!', you say out loud.");
                    Console.WriteLine();
                    Console.WriteLine("1 - Turn off the tap. Leaving it on would be insane! ~~~~~~~~~~~~~~~~");
                    Console.WriteLine("2 - Ignore the bathtub. The sooner you wash your face the better. ~~~");
                    playerChoiceCheck = Console.ReadLine();
                    int.TryParse(playerChoiceCheck, out playerChoice);
                }

                if (playerChoice == 1 )
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("You turn off the tap. 'What a waste of water' you think to yourself.");
                    Console.WriteLine("Barely having time to turn around you hear an inhumane sound.");

                }
                else if (playerChoice == 2 && player.Inventory != "GLOVES")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("You close your eyes and wash your face. Without noticing, the water level continues to rise.");
                    Console.WriteLine("You're completely submerged in a matter of seconds! You start to panic and think what you could possibly do.");
                    Console.WriteLine("You remember about the open tap. You take one last breath before the water closes the gap above your head.");
                    Console.WriteLine("You dive down to the bathtub. The last chance you have is to turn off the tap!");
                    Console.WriteLine("You try and grab onto it but the water makes it slippery, you can't get a good hold.");
                    Console.WriteLine("Your efforts go to waste as your vision begins to fade.");
                    Console.WriteLine("The last thing you hear is DJKhaled saying something about the importance of washing your face.");
                    Console.WriteLine("'How can he talk underwater?' is the last thought that goes through your head.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                    YOU ARE DEAD.                                                    ");
                    Console.WriteLine("Press ENTER to close the game."); // wrong option. Player dies
                    Console.ReadLine();
                    endGame = false;
                } else if (playerChoice == 2 && player.Inventory == "GLOVES")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("You close your eyes and wash your face. Without noticing, the water level continues to rise.");
                    Console.WriteLine("You're completely submerged in a matter of seconds! You start to panic and think what you could possibly do.");
                    Console.WriteLine("You remember about the open tap. You take one last breath before the water closes the gap above your head.");
                    Console.WriteLine("You dive down to the bathtub. The last chance you have is to turn off the tap!");
                    Console.WriteLine();
                    Console.WriteLine("You grasp firmly on the tap and turn it shut. You frantically swipe at the plug and the water starts to gush down the drain.");
                    Console.WriteLine("As the water recedes and you plant your feet on the ground, you barely have time to breath before you hear an inhumane sound.");
                }

                Console.WriteLine("You jump away from the bathtub as a jet of water splashes at your feet.");
                Console.WriteLine("Water Beast: You dare turn off my source of power!?! I will swallow you alive!");
                Console.WriteLine("The water from the tub solidifies and grows into a 6ft tall monster!");
                Console.WriteLine();
                Console.WriteLine("1 - Open the door. You need more space! ~~~~~~~~");
                Console.WriteLine("2 - Ready your weapon, it's time to fight! ~~~~~");
                playerChoiceCheck = Console.ReadLine();
                int.TryParse(playerChoiceCheck, out playerChoice);

                while (playerChoice != 1 && playerChoice != 2)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Try again.");
                    Console.WriteLine();
                    Console.WriteLine("The water from the tub solidifies and grows into a 6ft tall monster!");
                    Console.WriteLine();
                    Console.WriteLine("1 - Open the door. You need more space! ~~~~~~~~");
                    Console.WriteLine("2 - Ready your weapon, it's time to fight! ~~~~~");
                    playerChoiceCheck = Console.ReadLine();
                    int.TryParse(playerChoiceCheck, out playerChoice);
                }

                if (playerChoice == 1)
                {
                    Console.Clear();
                }
                else if (playerChoice == 2)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Your jabs hit nothing as the water beast twists into impossible shapes");
                    Console.WriteLine("He strikes! Having little room to dodge, you get hit straight in the chest.");
                    Console.WriteLine("You fall back and he hits you once more. Not having time to react, you get pummelled into the ground.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                    YOU ARE DEAD.                                                    ");
                    Console.WriteLine("Press ENTER to close the game.");
                    Console.ReadLine();
                    endGame = false; //you died. exit main game loop
                }

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You burst through the door and run back to the entrance area.");
                Console.WriteLine("The water monster foolishly follows after you, leaving wet puddles trailing behind it.");



                while (player.playerHealth > 0 && WaterBeast.enemyHealth > 0) //battle system, keep loop running while both fighters alive
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("You attack for {0} damage.", player.weaponDMG()); //call forward RNG for player
                    Console.WriteLine("WaterBeast attacks for {0} damage.", WaterBeast.enemyDMG());//call forward RNG for enemy
                    Console.WriteLine();
                    if (player.weaponDMG() > 6) //some custom stuff for crits
                    {
                        Console.WriteLine("Critical strike!!");
                    }
                    else if (WaterBeast.enemyDMG() > 5)
                    {
                        Console.WriteLine("Splash! The monster crits!");
                    }
                    else if (WaterBeast.enemyDMG() > 5 && player.weaponDMG() > 6)
                    {
                        Console.WriteLine("Critical strike!!");
                        Console.WriteLine("Splash! The monster crits!");
                    }
                    WaterBeast.enemyHealth = WaterBeast.enemyHealth - player.weaponDMG(); // damage calculation, hp remaining
                    player.playerHealth = player.playerHealth - WaterBeast.enemyDMG();
                    Console.WriteLine("You have {0} hp left.", player.playerHealth); //show player how much health remains
                    Console.WriteLine("The water beast has {0} hp left.", WaterBeast.enemyHealth);
                    Console.WriteLine();

                    if (player.playerHealth > 0 && WaterBeast.enemyHealth > 0) //if fighters still alive, fight again!
                    {
                        Console.WriteLine("Press ENTER to attack again!");
                        Console.ReadLine();
                    }

                }

                if (player.playerHealth < 1)//if player lost fight, show this
                {
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("The water beast is able to surround you from all sides with water.");
                    Console.WriteLine("Unknowingly to you, the water beast was constantly draining more water from the bathroom sink and gaining power.");
                    Console.WriteLine("His tides grow ever taller, coming down on you like a waterfall.");
                    Console.WriteLine("You see the last piece of air leave your body in the form of bubbles in front of you...");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                    YOU ARE DEAD.                                                    ");
                    Console.WriteLine("Press ENTER to close the game.");
                    Console.ReadLine();
                    endGame = false;//you died. exit main game loop

                }
                else if (WaterBeast.enemyHealth < 1)//enemy died, continue with story
                {
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Although the monster had the upper hand, you've tricked him into a larger area.");
                    Console.WriteLine("Darting this way and that, you're able to dodge all of his attacks.");
                    Console.WriteLine("Sunlight gleaming in from the windows, the beast toasts from the effect.");
                    Console.WriteLine("All that is left in the room is you and the steam rising slowly from the ground, where the beast once lay.");
                    Console.WriteLine();
                    Console.WriteLine("~~Water Beast's swag seeps out of it and is drawn to you. Your street cred increases by 5.~~");
                    player.playerLevel = player.playerLevel + 5; //add onto players level
                    player.playerScore = player.playerScore + WaterBeast.scoreGive();
                    Console.WriteLine("Reputation = {0}", player.playerLevel);//show player level
                    Console.WriteLine("Score = {0}", player.playerScore);
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();
                }

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("The steam has the effect of a sauna, and you feel better than ever.");
                Player.hpGainX = 3; Player.hpGainY = 10; //same line because I find it better. Giving values to the healthGain method
                player.playerHealth += player.healthGain(); //health gain. max hp can climb
                Console.WriteLine("Health gain = {0}", player.healthGain());
                Console.WriteLine("Health = {0}", player.playerHealth);
                Console.WriteLine("Press ENTER to continue."); //continue
                Console.ReadLine();

                Console.WriteLine("DJKhaled: {0}, you smart. You loyal. I keep people like you around.", player.playerName);
                Console.WriteLine("Khaled had come back into the room, wearing a life vest");
                Console.WriteLine("'A little late to be wearing that, I've just defeated that thing!', you yell.");
                Console.WriteLine("'Where were you! I could have used some help!'");
                Console.WriteLine();
                Console.WriteLine("DJKhaled: The key to success is to always be looking fly.");
                Console.WriteLine("He has a point you know...");
                Console.WriteLine();
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine();

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("DJKhaled takes you outside and you both jump onto his jet ski.");
                Console.WriteLine("He takes out his phone and opens up SnapChat.");
                Console.WriteLine("DJKhaled: Back at it again!!! This time with my homie {0}.", player.playerName);
                Console.WriteLine();
                Console.WriteLine("You both ride off into the sunset, your victory lap being the ocean to play with.");
                Console.WriteLine("The only annoying part of it all is the water from the waves splashing onto your face....");
                Console.WriteLine();
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine();

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("All of a sudden you're jolted awake by the sound of yourself choking.");
                Console.WriteLine("You vaguely see yourself pushing your pet pug off your chest and take a look around.");
                Console.WriteLine("You recognise your bedroom and deduce that it was all a dream. You look into the mirror.");
                Console.WriteLine("'EEEEWWWWW, DID YOU JUST PEE ON ME???'.");
                Console.WriteLine();
                Console.WriteLine("What a dirty, dirty dog.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                                    END GAME.                                                               ");
                Console.WriteLine("                                THANKS FOR PLAYING.                                                         ");
                Console.WriteLine("                                                                                                            ");
                Console.WriteLine("                                                                                                            ");
                Console.WriteLine("                                FINAL HEALTH ===== {0}                               ", player.playerHealth  );
                Console.WriteLine("                                FINAL SCORE ===== {0}                                   ", player.playerScore);
                Console.WriteLine("                                FINAL LEVEL ===== {0}                                   ", player.playerLevel);
                Console.WriteLine("                                                                                                            ");
                Console.WriteLine("                                                                                                            ");
                Console.WriteLine("                                                                                                            ");
                Console.WriteLine("                                 PRESS ENTER TO EXIT                                                        ");
                Console.ReadLine();
                endGame = false;
            }

            Console.Read();
        }
    }
}