using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movilim_yesodot
{
    class dealer
    {
        private string name;
        private deck gd=new deck("dealer");

        public dealer() { }
        public dealer(string name,deck gd)
        {
            //card[] de = new card[52];
            this.name = name;
            this.gd = new deck(name);
            
        }
        public int numOfCards()
        {//counts the num of cards in the deck
            int i, count = 0;
            for (i = 0; i <= 51; i++)
            { if (this.gd.hand[i].Name != "E") count++; }
            return count;
        }
        public card giveCard(string nameOfPlayer)
        {// the dealer gives the nameOfPlayer a card 
            int place = this.numOfCards(); 
            card c = this.gd.hand[place-1];
            this.gd.hand[place-1] = new card("E", 0, "E");
            return c;
        }


        public void shuffle()
        {
            deck d = new deck("dealer");
            int i, y, x; card  tempc;
            Random rnd = new Random();
            for (i = 0; i <= 1000; i++)
            {
                x = rnd.Next(52); y = rnd.Next(52);
                tempc = gd.hand[x]; gd.hand[x] = gd.hand[y]; gd.hand[y] = tempc;
            }
        }
        public override string ToString()
        {

            return this.gd.ToString();
        }

    }
}