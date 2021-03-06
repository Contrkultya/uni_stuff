﻿using System;
using System.Windows.Forms;

namespace Publisher
{
    public partial class SubForm : Form
    {
        public SubForm()
        {
            InitializeComponent();
            fillPubsListBox();
        }

        public override string ToString()
        {
            return "Подписчек " + this.Tag;
        }

        public void fillPubsListBox()
        {
            this.pubsListBox.Items.Clear();
            foreach (Publication pub in Program.pubs)
            {
                pubsListBox.Items.Add(pub.ToString());
            }
        }

        public void getStuff(Publication pub)
        {
            textBox1.Text += Program.day + ": Получено: " + pub + Environment.NewLine;
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            foreach (Publication pub in Program.pubs)
            {
                if (pub.ToString() == pubsListBox.SelectedItem.ToString())
                {
                    pub.subscribe(this);
                }
            }
        }

        private void unsubBtn_Click(object sender, EventArgs e)
        {
            foreach (Publication pub in Program.pubs)
            {
                if (pub.ToString() == pubsListBox.SelectedItem.ToString())
                {
                    pub.unsubscribe(this);
                }
            }
        }
    }
}