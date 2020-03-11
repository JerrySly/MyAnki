using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAnki

{
    [Serializable]
    public class Cards 
    {

        public List<Card> cards { get; set; }
        public Them them { get; set; }
        public Cards (Them them)
        {
            this.them = them;
            this.cards = new List<Card>();
        }
        public Cards()
        {
            this.cards = new List<Card>();
        }

    }
    [Serializable]
    public class Card {

        public string Name { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public int howGoodLearn { get; set; }//1- bad,2- good, 3- very good
        public int daysToRepeat { get; set; }

        public Card(string name,string que,string ans)
        {
            this.Name = name;
            this.answer = ans;
            this.question = que;
            this.howGoodLearn = 1;
            this.daysToRepeat = 0;
        }
        public void Refresh(int new_howGood)
        {
            this.howGoodLearn = new_howGood;
            if(new_howGood==1)
            {
                daysToRepeat = 1;
            }
            if(new_howGood==2)
            {
                daysToRepeat = 2;
            }
            if(new_howGood==3)
            {
                daysToRepeat = 3;
            }
        }
        public Card()
        {

        }

    }
}
