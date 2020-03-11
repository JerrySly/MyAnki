using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SelfAnki
{
    [Serializable]
    public class Thems
    {
 
        public List<Them> thems { get; set; } 
        public Thems()
        {
            thems = new List<Them>();
        }
    }
    [Serializable]
    public class Them
    {
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string name { get; set; }

        public List<Card> cards;

        public Them(string name)
        {
            this.name = name;
            this.cards = new List<Card>();
        }
        public Them()
        {

        } 
    }
}
