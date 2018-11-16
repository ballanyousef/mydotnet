using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movilim_yesodot
{
    public class deck
    {
        public card[] hand = new card[52];
        private string owner;
        public deck() {  }
        public deck(string name)
        {
            this.owner = name;
            //card[] hand = new card[52];
            if (this.owner == "dealer")
            {
                for (int i = 0; i <= 9; i++)
                {
                    this.hand[i] = new card(" " + (i+1), i + 1, "clubs");
                }
                this.hand[10] = new card("J", 10, "clubs");
                this.hand[11] = new card("K", 10, "clubs");
                this.hand[12] = new card("Q", 10, "clubs");
                for (int i = 13; i <=22; i++)
                {
                    hand[i] = new card(" " + (i - 12), i - 12, "diamonds");
                }
                this.hand[23] = new card("J", 10, "diamonds");
                this.hand[24] = new card("K", 10, "diamonds");
                this.hand[25] = new card("Q", 10, "diamonds");
                for (int i = 26; i < 36; i++)
                {
                    this.hand[i] = new card(" " + (i - 25), i - 25, "hearts");
                }
                this.hand[36] = new card("J", 10, "hearts");
                this.hand[37] = new card("K", 10, "hearts");
                this.hand[38] = new card("Q", 10, "hearts");
                for (int i = 39; i < 49; i++)
                {
                    this.hand[i] = new card(" " + (i - 38), i - 38, "spades");
                }
                hand[49] = new card("J", 10, "spades");
                hand[50] = new card("K", 10, "spades");
                hand[51] = new card("Q", 10, "spades");

            }
            else 
            {
                for (int i = 0; i <= 51; i++) this.hand[i] = new card("E", 0, "E");
            }
        }
        public override string ToString()
        {
            string st = "";
            for (int i = 0; i < 52; i++)
                st = st + this.hand[i].ToString();
                return this.owner+"\n"+st;
            

        }
    }
}
