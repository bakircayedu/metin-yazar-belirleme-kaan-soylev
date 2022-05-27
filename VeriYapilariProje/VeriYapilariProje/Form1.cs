using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VeriYapilariProje
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string text = "";

        StackLinkedList Sentences = new StackLinkedList();
        StackLinkedList WordsStack = new StackLinkedList();
        Heap heap = new Heap(100);
        public bool isRead, toStack = false;
        object[] heapWord;
        string[] kelimeler;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Dosyası |*.txt";
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = file.FileName;
                var fileStream = file.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    text = reader.ReadToEnd();
                    text = text.ToLower();
                    isRead = true;
                    MessageBox.Show("File uploaded");
                }
            }
            else
            {
                MessageBox.Show("!!! Couldn't access to the file !!!");
            }

        }

        private void btnStackOku_Click(object sender, EventArgs e)
        {
           
                
                int kelimeSayisi = 0;
                int cumleNumarasi = 0;
                int toplamkelimeSayisi = 0;
                string[] cumleler = text.Split('\n');
                
                for (int i = 0; i < cumleler.Length; i++)
                {
                    cumleNumarasi++;
                    kelimeler = cumleler[i].Split(' ');
                    kelimeSayisi = kelimeler.Length;
                    KelimeStackEkle(WordsStack, WordModifier(kelimeler));
                    rtxtbxResult.Text += (i + 1) + ". Cümledeki kelime sayısı: " + kelimeSayisi + "\r\n";
                    Sentences.Push(cumleler[i]);
                    toplamkelimeSayisi += kelimeSayisi;
                }
                rtxtbxResult.Text += "Toplam Kelime Sayısı: " + toplamkelimeSayisi + "\r\n" +
                    "Toplam Cümle Sayısı : " + Sentences.count
                    + "\r\n" + "Ortalama Kelime Sayısı: " + toplamkelimeSayisi / Sentences.count;
              
       

        }


        public string[] WordModifier(string[] kelimeler)
        {


            for (int i = 0; i < kelimeler.Length; i++)
            {
                for (int j = 0; j < kelimeler[i].Length; j++)
                {
                    if (Char.IsPunctuation(kelimeler[i], j))
                    {
                        kelimeler[i] =( kelimeler[i].Substring(0, j));
                        kelimeler[i].ToLower();
                        break;
                    }
                }

            }

            return kelimeler;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp="";


             for (int i = 0; i < WordsStack.count; i++)
             {
                  temp= WordsStack.Pop().ToString();
                heap.Insert(temp);

             }
            rtxtbxResultwords.Text = heap.Disp();            
        }

        private void txtHashBTN_Click(object sender, EventArgs e)
        {

           //todo

          

        }

        public void KelimeStackEkle(StackLinkedList linkedList, string[] kelimeler)
        {
            

                for (int i = 0; i < kelimeler.Length; i++)
                {
                    WordModifier(kelimeler);
                    WordsStack.Push(kelimeler[i]);
                }

            //listleme
            
            for (int i = 0; i < kelimeler.Length; i++)
            {
                Node temp=new Node(kelimeler[i]);

                rtxtbxResultwords.Text += temp.Data.ToString() +"\n";
            }

                

            }
      
          
        }
    }
