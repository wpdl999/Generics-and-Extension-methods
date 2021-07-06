using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Q1
{
    public partial class Form1 : Form 
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            String Idbox = IDtextBox.Text;
            String Firstname = FNtextBox.Text;
            String LastName = LNtextBox.Text;
            ShowlistBox.Items.Add(Idbox+"\t"+Firstname+"\t"+LastName);

            IDtextBox.Text = string.Empty;
            FNtextBox.Text = string.Empty;
            LNtextBox.Text = string.Empty;
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if (IntegerradioButton.Checked == true)
            {
                string[] snumbers = IAtextBox.Text.Split(' ');
                

                int[] numbers = Array.ConvertAll(snumbers, s => int.Parse(s));
                int searchkey = Convert.ToInt32(SKtextBox.Text);
                int resultindex = Search(numbers, searchkey);
                ResulttextBox.Text = resultindex.ToString();
            }

            if (StudentradioButton.Checked == true)
            {
                List<string> all = new List<string>();
                List<string> studentid = new List<string>();
                List<int> numid = new List<int>();

                
                foreach (string s in ShowlistBox.Items)
                {
                    all.Add(s);
                    studentid.Add(s.Split('\t').First());
                }

                numid = studentid.ConvertAll(int.Parse);
                int searchkey = Convert.ToInt32(SKtextBox.Text);
                int[] finalid=numid.ToArray();
                int resultindex;
                
                resultindex = Search(finalid, searchkey);
                ResulttextBox.Text = all[resultindex].ToString();              
            }
        }

        static int Search<T> (T[] dataArray, T searchKey) where T : IComparable<T>
        {
            for (int i = 0; i < dataArray.Length; i++)
            {
                if(dataArray[i].CompareTo(searchKey) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
