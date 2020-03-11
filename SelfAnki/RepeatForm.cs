using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfAnki
{
    public partial class RepeatForm : Form
    {
        public  List<Card> cardsForRepeat;
        public static int numberOfElement=0;
        public List<Card> allCards;
        public RepeatForm( ref List<Card> cards, ref List<Card> all)
        {
            InitializeComponent();
            this.cardsForRepeat = cards;
            this.allCards = all;
            Bad.Visible = false;
            Good.Visible = false;
            VeryGood.Visible = false;
            label1.Text = cards[numberOfElement].Name;
            Quest.Text = cards[numberOfElement].question;
        }

        private void ShowAns_Click(object sender, EventArgs e)
        {
            ShowAns.Visible = false;
            Bad.Visible = true;
            Good.Visible = true;
            VeryGood.Visible = true;
            Answer.Text = cardsForRepeat[numberOfElement].answer;

        }

        private void Bad_Click(object sender, EventArgs e)
        {
            Bad.Visible = false;
            Good.Visible = false;
            VeryGood.Visible = false;
            cardsForRepeat[numberOfElement].daysToRepeat = 0;
            cardsForRepeat[numberOfElement].howGoodLearn = 1;
            if (cardsForRepeat.Count - 1 > numberOfElement)
            {
                numberOfElement++;
                label1.Text = cardsForRepeat[numberOfElement].Name;
                Quest.Text = cardsForRepeat[numberOfElement].question;
                ShowAns.Visible = true;

            }
            else
            {
                numberOfElement = 0;
                foreach(Card cardX in allCards)
                    foreach(Card cardY in cardsForRepeat)
                    {
                        if(cardX.Name.Equals(cardY.Name))
                        {
                            cardX.howGoodLearn = 1;
                            cardX.daysToRepeat = 0;
                        }
                    }
                this.Close();
            }
        }

        private void VeryGood_Click(object sender, EventArgs e)
        {
            Bad.Visible = false;
            Good.Visible = false;
            VeryGood.Visible = false;
            cardsForRepeat[numberOfElement].daysToRepeat = 3;
            cardsForRepeat[numberOfElement].howGoodLearn = 3;
            if (cardsForRepeat.Count - 1 > numberOfElement)
            {
                numberOfElement++;
                label1.Text = cardsForRepeat[numberOfElement].Name;
                Quest.Text = cardsForRepeat[numberOfElement].question;
                ShowAns.Visible = true;
            }
            else
            {
                numberOfElement = 0;
                foreach (Card cardX in allCards)
                    foreach (Card cardY in cardsForRepeat)
                    {
                        if (cardX.Name.Equals(cardY.Name))
                        {
                            cardX.howGoodLearn = 3;
                            cardX.daysToRepeat = 3;
                            
                        }
                    }

                this.Close();

            }
        }

        private void Good_Click(object sender, EventArgs e)
        {
            Bad.Visible = false;
            Good.Visible = false;
            VeryGood.Visible = false;
            cardsForRepeat[numberOfElement].daysToRepeat = 1;
            cardsForRepeat[numberOfElement].howGoodLearn = 2;
            if (cardsForRepeat.Count - 1 > numberOfElement)
            {
                numberOfElement++;
                label1.Text = cardsForRepeat[numberOfElement].Name;
                Quest.Text = cardsForRepeat[numberOfElement].question;
                ShowAns.Visible = true;
            }
            else
            {
                numberOfElement = 0;
                foreach (Card cardX in allCards)
                    foreach (Card cardY in cardsForRepeat)
                    {
                        if (cardX.Name.Equals(cardY.Name))
                        {
                            cardX.howGoodLearn = 2;
                            cardX.daysToRepeat = 1;
                        }
                    }
                this.Close();

            }
        }

        private void RepeatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            for(int i=cardsForRepeat.Count-1; i>=0;i--)
            {
                if (cardsForRepeat[i].daysToRepeat > 0)
                    cardsForRepeat.Remove(cardsForRepeat[i]);
            }
       
        }
    }
}
