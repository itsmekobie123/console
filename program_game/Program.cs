using System;

	class Program
	{
		public static int score=0;
		public static int life=3;
		public static int count=0;
		public static void Main()
		{
			Menu();
			Action();
			GameOver();
			
		}
		public static void Menu()
		{
			int choose;
			Console.Clear();
			Console.WriteLine("Welcome Guest!");
			Console.WriteLine("Select Genre: ");
			Console.WriteLine("1. Action");
			Console.WriteLine("2. Anime");
			Console.WriteLine("3. Horror");
			Console.WriteLine("4. Romance");
			Console.WriteLine("5. Musical");
			Console.WriteLine("6. Comedy");
			Console.WriteLine("7. Random");
			Console.WriteLine("8. Exit");
			Console.Write("Select Your Choice: ");
			choose = Convert.ToInt32(Console.ReadLine());
			if (choose == 1)
			{
				Console.Clear();
				Console.WriteLine("Action Genre Category");
				Console.WriteLine("Press Enter to Play..\n\n\n\n");
				Console.WriteLine("Note: Please be specific to your answers.");
				Console.ReadLine();
				Action();
			}
			else if(choose == 2)
			{
				Console.Clear();
				Console.WriteLine("Anime Genre Category");
				Console.WriteLine("Press Enter to Play..\n\n\n\n");
				Console.WriteLine("Note: Please be specific to your answers.");
				Console.ReadLine();
				Anime();
			}
			else if(choose == 3)
			{
				Console.Clear();
				Console.WriteLine("Horror Genre Category");
				Console.WriteLine("Press Enter to Play..\n\n\n\n");
				Console.WriteLine("Note: Please be specific to your answers.");
				Console.ReadLine();
				Horror();
			}
			else if(choose == 4)
			{
				Console.Clear();
				Console.WriteLine("Romance Genre Category");
				Console.WriteLine("Press Enter to Play..\n\n\n\n");
				Console.WriteLine("Note: Please be specific to your answers.");
				Console.ReadLine();
				Romance();
			}
			else if(choose == 5)
			{
				Console.Clear();
				Console.WriteLine("Musical Genre Category");
				Console.WriteLine("Press Enter to Play..\n\n\n\n");
				Console.WriteLine("Note: Please be specific to your answers.");
				Console.ReadLine();
				Musical();
			}
			else if(choose == 6)
			{
				Console.Clear();
				Console.WriteLine("Comedy Genre Category");
				Console.WriteLine("Press Enter to Play..\n\n\n\n");
				Console.WriteLine("Note: Please be specific to your answers.");
				Console.ReadLine();
				Comedy();
			}
			else if(choose == 7)
			{
				Console.Clear();
				Console.WriteLine("Random Genre Category");
				Console.WriteLine("Press Enter to Play..\n\n\n\n");
				Console.WriteLine("Note: Please be specific to your answers.");
				Console.ReadLine();
			}
			else if(choose == 8)
			{
				Console.Clear();
				Console.WriteLine("Exiting Program..\n");
				Console.WriteLine("Press Enter to Exit");
				Console.ReadLine();
				Environment.Exit(0);
			}
			else 
			{
				Environment.Exit(0);
			}
		}
		public static void Action()
		{
			string ans;
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("1.The heroes are fighting a powerful being to stop him from collecting some magical stones that can destroy half the universe.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Avengers: Infinity War" || ans == "avengers: infinity war" || ans == "Infinity War" || ans == "infinity war")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("2.A rich billionare from Gotham City that fights crime and serves justice.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Batman" || ans == "batman")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("3. An ex special forces that turned into mutant by a rouge experement which gives him the ability to heal.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Deadpool" || ans == "deadpool")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("4. A time traveling machine that has a mission to kill a certain person.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Terminator" || ans == "terminator")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("5. He comes from the planet Krypton as he was sent to Earth by his parents to save him from the destruction of their planet.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Superman" || ans == "superman")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.WriteLine("Congratulations You Finished the Action Genre!");
			Console.Write("Your Total Score is " +score+"\n");
			Console.Write("Press Enter to Continue..");
			Console.ReadLine();
			Menu();
			if (life <= 0)
			{
				GameOver();
			}
			else 
			{
				Action();
			}
		}
		public static void Anime()
		{
			string ans;
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("1.The story of Saitama, a hero that does it just for fun & can defeat his enemies with a single punch.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Avengers: One Punch Man" || ans == "one punch man")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("2.The story of a kid who is the son of the 4th Hokage Minato Uzumaki who dreams to be a hokage himself in the future");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Naruto" || ans == "naruto" || ans == "Naruto Shipudden" || ans == "Naruto Shipudden")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("3.  This is a story about a pirate named Monkey D. Luffy who wants to be the King of the Pirates someday.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "One Piece" || ans == "one piece")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("4. Tokyo is haunted by mysterious ghouls who are devouring humans. People are gripped by the fear of these ghouls whose identities are masked " +
			                  "in mystery. An ordinary college student named Kaneki encounters Rize, a girl who is an avid reader like he is, at the café he frequents. " +
			                  "Little does Kaneki realize that his fate will change overnight.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Tokyo Ghoul" || ans == "tokyo ghoul")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("5. Hinata Shouyou, a short middle school student, gained a sudden love of volleyball after watching a national championship match on TV. " +
			                  "Determined to become like the championship's star player, a short boy nicknamed 'the small giant', Shouyou joined his school's volleyball club");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Haikyuu" || ans == "haikyuu")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.WriteLine("Congratulations You Finished the Anime Genre!");
			Console.Write("Your Total Score is " +score+"\n");
			Console.Write("Press Enter to Continue..");
			Console.ReadLine();
			Menu();
			if (life <= 0)
			{
				GameOver();
			}
			else 
			{
				Anime();
			}
		}
		public static void Horror()
		{
			string ans;
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("1.Tree immediately wakes up in the same way she had previously – in Carter's bed – and is unnerved to find the " +
			                  "previous day's events repeating themselves");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Happy Death Day" || ans == "happy death day")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("2.In 1952 Romania, two Roman Catholic nuns living at the Saint Cartha's monastery are attacked by an unseen " +
			                  "force when they enter a tunnel to retrieve an ancient Christian relic");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "The Nun" || ans == "The nun" || ans == "the nun")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("3.Matias keeps getting messages for Norah from someone named Erica. He gets on a Skype video call with his " +
			                  "friends - tech wiz Damon, conspiracy theorist and YouTube-personality AJ, DJ Lexx, and couple Serena and Nari" +
"			                  - and becomes frustrated with the computer constantly restarting.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Unfriended" || ans == "unfriended" || ans == "Unfriended Dark Web" || ans == "unfriended dark web")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("4. Bill, still haunted by Georgie's disappearance and the resulting neglect from his grief-stricken parents, " +
			                  "discovers that his brother's body may have washed up in a marshy wasteland called the Barrens.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "IT" || ans == "it")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("5. As the train departs, a convulsing young woman boards the train with a bite wound on her leg. She soon turns " +
			                  "into a zombie and attacks a train attendant, who then turns into a zombie.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Train to Busan" || ans == "Train To Busan" || ans == "train to busan")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.WriteLine("Congratulations You Finished the Horror Genre!");
			Console.Write("Your Total Score is " +score+"\n");
			Console.Write("Press Enter to Continue..");
			Console.ReadLine();
			Menu();
			if (life <= 0)
			{
				GameOver();
			}
			else 
			{
				Horror();
			}
		}
		public static void Romance()
		{
			string ans;
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("1.Katie Price lives with a life-threatening sensitivity to sunlight caused by the rare genetic condition, " +
			                  "xeroderma pigmentosum. During the day, she is housebound, having only her father, Jack and her best friend, " +
			                  "Morgan, to keep her company. Katie comes out of the house every night, when the sun is not present.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Midnight Sun" || ans == "midnight sun")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("2.One night while hanging out with her little sister, Kitty, Lara Jean falls asleep on the couch, allowing " +
			                  "Kitty to sneak into Lara Jean's room and find her collection of letter");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "To All the Boys I've Loved Before" || ans == "to all the boys i've loved before")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("3.Joko finds himself in the service of online media mogul SASHA (Kris Aquino). " +
			                  "The catch: he must pretend to be gay and must compete with his crush, ZOE.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "I Love You Hater" || ans == "i love you hater")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("4. The story begins two years after the break up between Pia and Nix Cabangon and they were invited in the " +
			                  "party made by the married couple Reyna and Tops.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Exes Baggage" || ans == "exes baggage")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("5. A young couple dream of growing old together as they deal with the struggles of being in a long-term relationship.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "The Hows Of Us" || ans == "The Hows of Us" || ans == "the hows of us")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.WriteLine("Congratulations You Finished the Horror Genre!");
			Console.Write("Your Total Score is " +score+"\n");
			Console.Write("Press Enter to Continue..");
			Console.ReadLine();
			Menu();
			if (life <= 0)
			{
				GameOver();
			}
			else 
			{
				Romance();
			}
		}
		public static void Musical()
		{
			string ans;
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("1.Thirsty for innovation and hungry for success, the son of a tailor will manage to open a wax museum but will " +
			                  "soon shift focus to the unique and peculiar, introducing extraordinary, never-seen-before live acts on the" +
"			                  circus stage.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "The Greatest Showman" || ans == "the greatest showman")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("2. The only way to heal the island is to" +
"			                  persuade Maui to return Te Fiti's heart, so Moana sets off on an epic journey across the Pacific");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Moana" || ans == "moana")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("3.Her mounting emotions trigger the magic, accidentally setting off an eternal winter that she can't stop. " +
			                  "She fears she's becoming a monster and that no one, not even her sister, can help her. ");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Frozen" || ans == "frozen")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("4. One day, the bandit Flynn Ryder scales the tower and is taken captive by Rapunzel. Rapunzel strikes a deal " +
			                  "with the charming thief to act as her guide to travel to the place where the floating lights come from that " +
			                  "she has seen every year on her birthday.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Tangled" || ans == "tangled")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("5. A young prince, imprisoned in the form of a beast, can be freed only by true love. What may be his only " +
			                  "opportunity arrives when he meets Belle, the only human girl to ever visit the castle since it was enchanted.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Beauty And The Beast" || ans == "Beauty and the Beast" || ans == "beauty and the beast")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.WriteLine("Congratulations You Finished the Musical Genre!");
			Console.Write("Your Total Score is " +score+"\n");
			Console.Write("Press Enter to Continue..");
			Console.ReadLine();
			Menu();
			if (life <= 0)
			{
				GameOver();
			}
			else 
			{
				Musical();
			}
		}
		public static void Comedy()
		{
			string ans;
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("1.Kevin prompts Oz, Finch, Jim, and Kevin to pledge to no longer be virgins by their high school graduation.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "American Pie" || ans == "American pie" || ans == "american pie")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("2.Beca reluctantly auditions by performing 'Cups (When I'm Gone)', and joins the Bellas.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Pitch Perfect" || ans == "pitch perfect")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("3.One night, they get on the topic of sex and relationships. They come to the conclusion that sex " +
			                  "should not come with so many emotional attachments.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Friends with Benefits" || ans == "friends with benefits ")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("4. While fighting with and feeding on a human scavenger party, R meets Julie and feels an urge to protect her.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Warm Bodies" || ans == "warm bodies ")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.Write("Score:"+score+"\t\t\t\t\tLife:"+life+"\n\n");
			Console.WriteLine("5.Kelly and Mac are settling down in a quiet neighborhood with their newborn child, until the frat brothers " +
			                  "move into the house next door.");
			Console.Write("Answer: ");
			ans = Console.ReadLine();
			if (ans == "Neighbors" || ans == "neighbors")
			{
				Console.WriteLine("Your Answer is Correct!");
				Console.ReadLine();
				score+=5;
				count++;
			}
			else
			{
				Console.WriteLine("Your Answer is Wrong!");
				Console.ReadLine();
				life--;
			}
			Console.Clear();
			Console.WriteLine("Congratulations You Finished the Musical Genre!");
			Console.Write("Your Total Score is " +score+"\n");
			Console.Write("Press Enter to Continue..");
			Console.ReadLine();
			Menu();
			if (life <= 0)
			{
				GameOver();
			}
			else 
			{
				Comedy();
			}
		}
		public static void GameOver()
		{	
			int overchoose;
			Console.Clear();
			Console.WriteLine("Game Over!");
			Console.WriteLine("1. Main Menu");
			Console.WriteLine("2. Exit");
			overchoose = Convert.ToInt32(Console.ReadLine());
			if (overchoose == 1)
			{
				Console.Clear();
				Menu();
			}
			else if (overchoose == 2)
			{
				Environment.Exit(0);
			}
		}
	}