using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using StudioForge;

namespace TMF_Simplifier
{
    public partial class compview : Form
    {
        
        public compview()
        {
            InitializeComponent();
        }
        

        private void compview_Load(object sender, EventArgs e)
        {
        }

        public void LoadComps(string name)
        {
            string[] Downloads = Directory.GetFiles(name);
            listView.Items.Clear();
            foreach (string item in Downloads)
            {
                if (item.EndsWith(".com"))
                {
                    string[] row = { item.Replace($"{name}\\","").Replace(".com",""), item.Replace($"{name}\\", "") };
                    var listViewItem = new ListViewItem(row);
                    listView.Items.Add(listViewItem);
                }

            }
        }
    }
}
