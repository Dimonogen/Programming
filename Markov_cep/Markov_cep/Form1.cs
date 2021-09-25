using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Markov_cep
{
    public partial class Form1 : Form
    {
        string text_input = "";//Исходные данные
        class pair//Пара из символа и количества его в тексте
        {
            public char c;
            public int count;
        }
        class pairstr
        {
            public string str;
            public int count;
        }
        class MyListchar//Массив следующих элементов
        {
            public int all_count;
            //public Dictionary<char, int> elements;
            public List<pair> elements;
        }
        class MyListStr//Массив следующих элементов
        {
            public int all_count;
            //public Dictionary<char, int> elements;
            public List<pairstr> elements;
        }
        Dictionary<string, MyListchar> DATA = new Dictionary<string, MyListchar>();
        Dictionary<string, MyListStr> DATA_S = new Dictionary<string, MyListStr>();

        int window_size = 8;
        int result_size = 512;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                string filepath = of.FileName;
                textBoxFileName.Text = filepath;         
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            string big_key = textBoxInto.Text;

            result_size = int.Parse(textBoxOutPutSize.Text);
            //int fi = big_key.IndexOf(' ',)

            //Predict
            if (radioButtonChar.Checked)
            {
                big_key = big_key.Substring(0, window_size - 1);
                textBoxOut.Text = Data_predict_char(big_key);
            }
            else if (radioButtonWords.Checked)
            {
                int fi = 0;
                for (int i = 0; i < window_size - 1; i++)
                {
                    fi = big_key.IndexOf(' ', fi + 1);
                }
                big_key = big_key.Substring(0, fi + 1);
                textBoxOut.Text = Data_predict_str(big_key);
            }

            
        }

        private void buttonRead_Click(object sender, EventArgs e) //READ
        {
            StreamReader sr = new StreamReader(textBoxFileName.Text);
            text_input = sr.ReadToEnd();
            sr.Close();

            window_size = int.Parse(textBoxWindow.Text);

            //ADD to dict data
            if (radioButtonChar.Checked)
            {
                Data_add_chars();
            }
            if (radioButtonWords.Checked)
            {
                Data_add_words();
            }
            //EndRead

        }

        void Data_add_chars()
        {
            DATA.Clear();
            for (int i = 0; i < text_input.Length - window_size; i++)
            {
                string window = text_input.Substring(i, window_size);
                string key = window.Substring(0, window_size - 1);
                char value = window[window_size - 1];

                if (DATA.ContainsKey(key))
                {
                    MyListchar ml = DATA[key];
                    ml.all_count += 1;
                    bool containKey = false;
                    int j = 0;

                    for (j = 0; j < ml.elements.Count; j++)
                    {
                        if (ml.elements[j].c == value)
                        {
                            containKey = true;
                            break;
                        }
                    }

                    if (containKey)
                    {
                        ml.elements[j].count++;
                    }
                    else
                    {
                        pair p = new pair();
                        p.c = value;
                        p.count = 1;
                        ml.elements.Add(p);
                    }
                }
                else
                {
                    MyListchar ml = new MyListchar();
                    ml.all_count = 1;
                    pair p = new pair();
                    p.c = value;
                    p.count = 1;
                    ml.elements = new List<pair>();
                    ml.elements.Add(p);
                    DATA.Add(key, ml);
                }
            }
        }

        void Data_add_words()
        {
            DATA_S.Clear();
            //text_input = text_input.Replace('\n', ' ');        
            text_input = text_input.Replace("\r\n", " ");
            text_input = text_input.Replace("  ", " ");

            int i = 0;
            int j = text_input.IndexOf(' ',1);

            for (int k = 0; k < window_size - 1; k++ )
            {
                j = text_input.IndexOf(' ', j+1);
            }

            while(j != -1)
            {
                string window = text_input.Substring(i, j-i+1);
                int kk = window.LastIndexOf(' ');
                kk = window.LastIndexOf(' ', kk-1)+1;
                string key = window.Substring(0, kk);                
                string value = window.Substring(kk);

                if (DATA_S.ContainsKey(key))
                {
                    MyListStr ml = DATA_S[key];
                    ml.all_count += 1;
                    bool containKey = false;
                    int p = 0;

                    for (p = 0; p < ml.elements.Count; p++)
                    {
                        if (ml.elements[p].str == value)
                        {
                            containKey = true;
                            break;
                        }
                    }

                    if (containKey)
                    {
                        ml.elements[p].count++;
                    }
                    else
                    {
                        pairstr pa = new pairstr();
                        pa.str = value;
                        pa.count = 1;
                        ml.elements.Add(pa);
                    }
                }
                else
                {
                    MyListStr ml = new MyListStr();
                    ml.all_count = 1;
                    pairstr p = new pairstr();
                    p.str = value;
                    p.count = 1;
                    ml.elements = new List<pairstr>();
                    ml.elements.Add(p);
                    DATA_S.Add(key, ml);
                }

                i = text_input.IndexOf(' ', i + 1)+1;
                j = text_input.IndexOf(' ', j + 1);
                if (i == j)
                {
                    break;
                }
            }
        }

        string Data_predict_char(string big_key)
        {
            string text_predict = big_key;
            Random rand = new Random();
            for (int i = 0; i < result_size - window_size; i++)
            {
                string k_key = text_predict.Substring(text_predict.Length - window_size + 1);
                char new_value = ' ';

                MyListchar ml = DATA[k_key];
                int r = rand.Next(0, ml.all_count);
                int j = 0;
                for (int k = 0; k < ml.elements.Count; k++)
                {
                    j += ml.elements[k].count;
                    if (j >= r)
                    {
                        new_value = ml.elements[k].c;
                        break;
                    }
                }

                text_predict = text_predict + new_value;
            }
            return text_predict;
        }

        string Data_predict_str(string big_key)
        {
            int kk = 0;
            string text_predict = big_key;
            Random rand = new Random();
            for (int i = 0; i < result_size - window_size; i++)
            {
                string k_key = text_predict.Substring(kk);
                string new_value = "";

                MyListStr ml = DATA_S[k_key];
                int r = rand.Next(0, ml.all_count);
                int j = 0;
                for (int k = 0; k < ml.elements.Count; k++)
                {
                    j += ml.elements[k].count;
                    if (j >= r)
                    {
                        new_value = ml.elements[k].str;
                        break;
                    }
                }

                text_predict = text_predict + new_value;
                kk = text_predict.IndexOf(' ', kk+1)+1;
            }
            return text_predict;
        }


    }
}
