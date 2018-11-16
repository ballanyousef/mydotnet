using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movilim_yesodot
{
    class player
    {
        private string name;
        public deck deckinhand = new deck("");//the deck in the hand of the player
        public player(string name)
        {//constructor of a player that takes playername and sets the deck to be empty
            this.deckinhand = new deck(name);
            this.name = name;
            
            for (int i = 0; i <= 51; i++) 
            {
                this.deckinhand.hand[i] = new card("E", 0, "E");
                
            }
        }
        public int numOfCards()
        {//returns the num of cards in the hand of the player
            int i, count = 0;
            for (i = 0; i <= 51; i++)
            { if (this.deckinhand.hand[i].Name != "E") count++; }
            return count;
        }
        public card getCard(dealer deal)
        {//the player gets a card from the dealer
            int place = this.numOfCards();
            card c = deal.giveCard(this.name);
            this.deckinhand.hand[place] = c;
            return c;
               
        }
        public override string ToString()
        {
            return  this.deckinhand.ToString();
        }


    }
}
