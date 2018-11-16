using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movilim_yesodot
{
   public class card
    {
       private string name;
       private int val; 
       private string type;
       
       public card() { }
       public card(string name, int val, string type)
       {
           this.name = name;
           this.val = val;
           this.type = type;
       }
       public string Name
       {
           get { return this.name; }
           set { this.name = value; }
       }
       public int Value
       {
           get { return this.val; }
           set { this.val = value; }
       }
       public string Type
       {
           get { return this.type; }
           set { this.name = value; }
       }
       public override string ToString()
       {
           return "name="+this.name + "      " + "type="+this.type + "   value=" + this.val+"\n";
       }
    }//of card
}
