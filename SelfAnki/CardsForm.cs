using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
namespace SelfAnki
{
    public partial class CardsForm : Form
    {

        public List<Card> cards;
        public Them them;
        public List<Card> forRepeat;
        public CardsForm(Them them,int sep)
        {
            InitializeComponent();
            this.them = them;
            this.cards = Desirialize().cards;
            this.forRepeat = new List<Card>();
            if (cards!=null)
            foreach(Card card in cards)
            {
                    card.daysToRepeat -= sep;
                    if (card.daysToRepeat < 0) card.daysToRepeat = 0;
                if(card.daysToRepeat==0)
                    {
                        forRepeat.Add(card);
                    }
                ListViewItem LVI = new ListViewItem(card.Name);
                LVI.Tag = card;
                cards_list.Items.Add(LVI);
                cards_list.Refresh();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            bool exist = false;
       foreach(Card card in cards)
            {
                if (card.Name == name_card.Text && name_card.Text.Length > 0)
                    exist = true;
            }
            if (name_card.Text.Length > 0 && question_card.Text.Length > 0 && answer_card.Text.Length > 0 && !exist)
            {
                Card card = new Card(name_card.Text, question_card.Text, answer_card.Text);
                ListViewItem LVI = new ListViewItem(card.Name);
                LVI.Tag = card;
                cards_list.Items.Add(LVI);
                this.cards.Add(card);
                this.forRepeat.Add(card);
                cards_list.Refresh();
            }
            else
            {
                if (exist) MessageBox.Show("Card with this name already exist");
                else
                {
                    if (name_card.Text.Length <= 0) MessageBox.Show("Enter name for card");
                    else
                    {

                        if (question_card.Text.Length <= 0) MessageBox.Show("Enter question");
                        else
                        {
                            if (answer_card.Text.Length <= 0) MessageBox.Show("Enter answer for this card");
                        }
                    }
                }
            }
            Refresh_Click(sender, e);


        }

        private void cards_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cards_list.SelectedIndices.Count == 1)
            {
                Card item = (Card)cards_list.SelectedItems[0].Tag;
                            name_card.Text = item.Name;
                            answer_card.Text = item.answer;
                            question_card.Text = item.question;
                            days_card.Text = item.daysToRepeat.ToString();
                if (item.howGoodLearn == 1) mark_card.Text = "Bad";
                if (item.howGoodLearn == 2) mark_card.Text = "Good";
                if (item.howGoodLearn == 3) mark_card.Text = "Very Good";
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Cards cards = new Cards(this.them);
            foreach(ListViewItem LVI in cards_list.Items)
            {
                cards.cards.Add((Card)LVI.Tag);
            }
            XmlSerializer xml = new XmlSerializer(typeof(Cards));
            using (FileStream fs=new FileStream("Cards_" + them.name + ".xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, cards);
            }
        }
        private Cards Desirialize()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Cards));
            using (FileStream fs = new FileStream("Cards_" + this.them.name + ".xml", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0 && fs != null)
                    return (Cards)xml.Deserialize(fs);
                else return new Cards(them); 
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (cards_list.SelectedIndices.Count == 1)
            {
                Card item = (Card)cards_list.SelectedItems[0].Tag;
                File.Delete("Cards_" + this.them.name + ".xml");
                cards_list.Items.Remove(cards_list.SelectedItems[0]);
                cards.Remove(item);
                forRepeat.Remove(item);
            }
            Refresh_Click(sender,  e);
        }
        // Ошибка в поиске карт которые нужно повторять и сохраниение результатов карты.
        private void Repeat_Click(object sender, EventArgs e)
        {
          if(forRepeat.Count>0)
            {
                RepeatForm repeatForm = new RepeatForm(ref forRepeat, ref cards);
                repeatForm.Show();
            }
            else
            {
                MessageBox.Show("You don't have cards for repeating");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cards_list.SelectedIndices.Count == 1)
            {
                bool exist = false;
                foreach (Card card in cards)
                {
                    if (card.Name == name_card.Text && name_card.Text.Length > 0)
                        exist = true;
                }
                if (!exist)
                {
                    Card item = new Card();
                    foreach (Card card in cards)
                    {
                        if (card.Name == cards_list.SelectedItems[0].Text)
                        {
                            card.Name = name_card.Text;
                            card.answer = answer_card.Text;
                            card.question = question_card.Text;
                            item = card;
                        }
                    }
                    cards_list.Items.Remove(cards_list.SelectedItems[0]);
                    ListViewItem LVI = new ListViewItem(item.Name);
                    LVI.Tag = item;
                    cards_list.Items.Add(LVI);
                    cards_list.Refresh();
                }
                else MessageBox.Show("Card with this name already exist");
            }
            else
            {
                MessageBox.Show("Pls select item on list for changing");
            }
            Refresh_Click(sender, e);
        }

        private void CardsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Refresh_Click(sender, e);
        }
    }
}
