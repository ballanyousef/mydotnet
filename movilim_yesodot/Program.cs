using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movilim_yesodot
{
    class Program
    {
        static char yesOrNo(char ans)
            //הפונקציה מקבלת תו
            //הפונקציה היא מסננת קלט המחזירה קלט תקין 
        {
            char c=ans;
            while (!(c.Equals('y')) && !(c.Equals('n')))
            {
                
                Console.WriteLine("type 'y' or 'n'");
                c = char.Parse(Console.ReadLine());
            }
            return c;
        }// end of yesOrNo
        static void Main(string[] args)
        {
            int pl = 0; int com = 0; card c,cc;
            Console.WriteLine("IF U WANT TO START A GAME TYPE 's' IF NOT TYPE 'end'");
            string newgame = Console.ReadLine();
            //loop for a new game 
            while (newgame == "s")
            {
                player p = new player("player");

                player comp = new player("computer");
                deck dealerdeck = new deck("dealer");
                dealer deal = new dealer("dealer", dealerdeck);
                deal.shuffle();//מערבבים את החפיסה
                
                c=p.getCard(deal);//שחקן מקבל קלף
                Console.WriteLine("A card for the player           {0}", c.ToString());
                cc=comp.getCard(deal);
                Console.WriteLine("A card for the computer           {0}", cc.ToString());
                // מחשב מקבל קלף
                int numofcardsp = p.numOfCards();
                int numofcardsc = comp.numOfCards();
                int sump = c.Value;
                int sumc = cc.Value;
                Console.WriteLine("Your total score=  {0}", sump);
                c=p.getCard(deal);
                // שחקן מקבל עוד  קלף
                Console.WriteLine("Another card for the player           {0}", c.ToString());
                cc=comp.getCard(deal);//מחשב מקבל עוד קלף
                Console.WriteLine("Another card for the computer           {0}", cc.ToString());
                numofcardsp = p.numOfCards();
                Console.WriteLine("Your total score=  {0}", sump);
                Console.WriteLine("The computer  total score=  {0}", sumc);
                numofcardsc = comp.numOfCards();
                sump = sump +c.Value; ;
                sumc =sumc+ cc.Value;
                char ch;
                bool flag = true;
                //הצגת סכום כולל של שחקן
                
                

                while ((sumc < 21) && (sump < 21)&&flag)
                {
                    Console.WriteLine("The computer total score =  {0}", sumc);
                    Console.WriteLine("HI player , your total score =  {0}", sump);
                    Console.WriteLine("Do you want a card ?type 'y' or 'n'");
                    
                    ch = char.Parse(Console.ReadLine());
                    //מסננת קלט
                    ch = yesOrNo(ch);
                    if (ch == 'y')
                    {
                        c = p.getCard(deal);
                        Console.WriteLine("You have got the card                  {0} ", c.ToString());
                        numofcardsp = p.numOfCards();
                        int cardvaluep = c.Value;
                        if ((21 - sump >= 11) && (cardvaluep == 1)) cardvaluep = 11;
                        sump = sump + cardvaluep;
                    }
                                        
                    
                    if ((21 - sumc > 21 - sump) || (ch=='n'))
                    {
                        cc=comp.getCard(deal);
                        Console.WriteLine("The computer have got the card               {0} ",cc.ToString());
                        Console.WriteLine("The computer score = {0}", sumc);
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        numofcardsc = comp.numOfCards();
                        int cardvaluec = cc.Value;
                        if ((21 - sumc >= 11) && (cardvaluec == 1)) cardvaluec = 11;
                        sumc = sumc + cardvaluec;
                    }

                    if (pl == sump && com == sumc) flag = false; 

                }
                Console.WriteLine("Result  for player = {0}", sump);
                Console.WriteLine("Result  for compter = {0}", sumc);
                if ((sump > 21) && (sumc > 21)) Console.WriteLine("The winner is computer");
                if ((sump <= 21) && (sumc > 21)) Console.WriteLine("The winner is player");
                if ((sump > 21) && (sumc <= 21)) Console.WriteLine("The winner is computer");
                if ((sump <= 21) && (sumc <= 21))
                {
                    if (sump < sumc)
                        Console.WriteLine("The winner is computer");
                    if (sump > sumc) Console.WriteLine("The winner is player");
                    if (sump == sumc) Console.WriteLine("Tiko");
                }
                Console.WriteLine("IF U WANT TO START A GAME TYPE 's' IF NOT TYPE 'end'");
                newgame = Console.ReadLine();  pl = 0;  com = 0;

            } 
            Console.ReadLine();
            
            Console.Write(" ");
        }
    }
}
