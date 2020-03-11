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
    public partial class MainMenu : Form
    {
        public DateTime DateTime { get; set; } = DateTime.Now;
        public Thems myThems;
    
        public MainMenu()
        {
            InitializeComponent();
            myThems = Desirialize();
            if(myThems!=null)
            foreach(Them them in myThems.thems)
            {
                ListViewItem LVI = new ListViewItem(them.name);
                LVI.Tag = them;
                listOfThems.Items.Add(LVI);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (new_name.Text.Length > 0)
            {
                Them them = new Them(new_name.Text);
                ListViewItem LVI = new ListViewItem(them.name);
                LVI.Tag = them;
                listOfThems.Items.Add(LVI);
                new_name.Clear();
             File.Create("Cards_" + LVI.Text + ".xml").Close();


            }
            Save_Click(sender, e);
        }

        private void listOfThems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOfThems.SelectedIndices.Count == 1)
                    rename_box.Text=listOfThems.SelectedItems[0].Text;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (listOfThems.SelectedIndices.Count == 1) 
                {

                File.Delete("Cards_" + listOfThems.SelectedItems[0].Text + ".xml");
                File.Delete("Thems.xml");
                listOfThems.SelectedItems[0].Remove();

            }
            Save_Click(sender, e);
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            if (listOfThems.SelectedIndices.Count == 1 && rename_box.Text.Length>0)
            {
                listOfThems.SelectedItems[0].Text = rename_box.Text;
                listOfThems.SelectedItems[0].Tag = new Them(rename_box.Text);
                listOfThems.Refresh();
                File.Delete("Thems.xml");
            }
            Save_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Them them = (Them)listOfThems.SelectedItems[0].Tag;
            int separate = 0;
            if (listOfThems.SelectedIndices.Count == 1)
            {
                if(!(them.DateTime.Equals(this.DateTime)))
                    {
                    if (this.DateTime.Month < them.DateTime.Month)
                        separate = 0;
                    else
                        separate = this.DateTime.Day - them.DateTime.Day;
                }
                CardsForm cardsForm = new CardsForm(them,separate);
                ((Them)listOfThems.SelectedItems[0].Tag).DateTime = DateTime.Now;
                cardsForm.Show();
            }
        }
        private void Serialixation()
        {
            Thems thems = new Thems();
            foreach (ListViewItem item in listOfThems.Items)
            {
                if(item.Tag!=null)
                {
                    thems.thems.Add((Them)item.Tag);
                }
            }
            XmlSerializer xml = new XmlSerializer(typeof(Thems));
            using (FileStream fs=new FileStream("Thems.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs,thems);
            }

        }
        private Thems Desirialize()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Thems));
            using (FileStream fs = new FileStream("Thems.xml", FileMode.OpenOrCreate))
            {
                if (fs.Length>0 && fs!=null)
                    return (Thems)xml.Deserialize(fs);
                else return null;
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            Serialixation();
        }
    }
}
