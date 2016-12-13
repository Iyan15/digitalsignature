using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Numerics;
using System.Threading;

namespace RSA
{
    public partial class Form1 : Form
    {
        BigInteger p = 20113, q = 113017, m, n, en = 5, d = 909191117;
        BigInteger big = new BigInteger();
        LoadingEncrypt load = new LoadingEncrypt();
        Int64[] primes;

        byte[] cikan;

        List<string> binary = new List<string>();
        List<string> block = new List<string>();

        Thread proses;
        Thread loading;
        Thread decryptThread;
  
        public Form1()
        {
            InitializeComponent();
            n = p * q;
            m = (p - 1) * (q - 1);
            
            proses = new Thread(new ThreadStart(encrypt));
            loading = new Thread(new ThreadStart(loads));
            decryptThread = new Thread(new ThreadStart(decrypt));

            primes = new Int64[]
	        {
                43627, 52361, 62851, 75431, 90523, 108631, 130363, 156437, 187751, 225307
	        };

            generateKey();
        }

        void primeRandom()
        {
            Random random = new Random();
            int i;
            i = random.Next(0, primes.Length);
            p = primes[i];
            i = random.Next(0, primes.Length);
            q = primes[i];

            while (q <= p)
            {
                i = random.Next(0, primes.Length);
                p = primes[i];
                i = random.Next(0, primes.Length);
                q = primes[i];
            }

            p_txt.Text = p.ToString();
            q_txt.Text = q.ToString();

            n = p * q;
            m = (p - 1) * (q - 1);

            N_txt.Text = n.ToString();
            M_txt.Text = m.ToString();
        }
        BigInteger pangkat(BigInteger x, BigInteger y)
        {
            BigInteger i = 1, temp = x;

            for (i = 2; i <= y; i++ )
            {
                x = x * temp;
            }

            return x;

        }
        BigInteger fpb(BigInteger x, BigInteger range)
        {
            BigInteger nilai = 0;
            bool cek = false;

            do
            {
                nilai = x % range;
                if (nilai == 1 || nilai == 0)
                {
                    cek = true;
                }
                else
                {
                    x = range;
                    range = nilai;
                }
            } while (cek != true);

            return nilai;
        }
        void publicKey()
        {
            int counter = 1;
            bool cek = false;
            while (cek != true)
            {
                counter++;
                if (fpb(counter, m) == 1)
                {
                    cek = true;
                }
            }

            en = counter;
            e_txt.Text = en.ToString();

            d = privateKey(m, en);
            d_txt.Text = d.ToString();
        }
        BigInteger privateKey(BigInteger a, BigInteger b)
        {
            BigInteger x = 0;
            BigInteger lastx = 1;
            BigInteger y = 1;
            BigInteger lasty = 0;
            BigInteger temp, quotient;


            while (b != 0)
            {
                temp = b;
                quotient = a / b;
                b = a % b;
                a = temp;
                temp = x;
                x = lastx - quotient * x;
                lastx = temp;
                temp = y;
                y = lasty - quotient * y;
                lasty = temp;

            }


            return lasty; // lasty, a;
        }
        private void encrypt_btn_Click(object sender, EventArgs e)
        {
            //encrypt();
            proses.Start();
            loading.Start();
        }
        public void encrypt()
        {
            chiper_encrypt_rtb.Clear();
            ascii_rtb.Clear();
            string plain = "tes";//plain_encrypt_rtb.Text;
            byte[] ascii = cikan;//Encoding.ASCII.GetBytes(plain);
            binary = new List<string>();
            block = new List<string>();

            for (int i = 0; i < ascii.Length; i++)
            {
                ascii_rtb.Text += ascii[i].ToString() + " ";

                int caesar = (ascii[i] + 3) % 255;
                if (caesar == 256)
                    caesar = 1;
                else if (caesar == 257)
                    caesar = 2;
                else if (caesar == 258)
                    caesar = 3;

                if (Convert.ToString(caesar, 2).Length == 1)
                    binary.Add("0000000" + Convert.ToString(caesar, 2));
                else if (Convert.ToString(caesar, 2).Length == 2)
                    binary.Add("000000" + Convert.ToString(caesar, 2));
                else if (Convert.ToString(caesar, 2).Length == 3)
                    binary.Add("00000" + Convert.ToString(caesar, 2));
                else if (Convert.ToString(caesar, 2).Length == 4)
                    binary.Add("0000" + Convert.ToString(caesar, 2));
                else if (Convert.ToString(caesar, 2).Length == 5)
                    binary.Add("000" + Convert.ToString(caesar, 2));
                else if (Convert.ToString(caesar, 2).Length == 6)
                    binary.Add("00" + Convert.ToString(caesar, 2));
                else if (Convert.ToString(caesar, 2).Length == 7)
                    binary.Add("0" + Convert.ToString(caesar, 2));
                else
                    binary.Add(Convert.ToString(caesar, 2));
            }
            for (int i = 0; i < binary.Count; i += 4)
            {
                string bin = string.Empty;
                //chiper_encrypt_rtb.Text += binary[i] + " ";
                if (i + 3 < binary.Count)
                {
                    bin = binary[i] + binary[i + 1] + binary[i + 2] + binary[i + 3];
                }
                else if (i + 2 < binary.Count)
                {
                    bin = binary[i] + binary[i + 1] + binary[i + 2];
                    for (int j = 0; j < 32 - (binary[i].Length + binary[i + 1].Length + binary[i + 2].Length); j++)
                    {
                        bin = "0" + bin;
                    }
                }
                else if (i + 1 < binary.Count)
                {
                    bin = binary[i] + binary[i + 1];
                    for (int j = 0; j < 32 - (binary[i].Length + binary[i + 1].Length); j++)
                    {
                        bin = "0" + bin;
                    }
                }
                else
                {
                    bin = binary[i];
                    for (int j = 0; j < 32 - binary[i].Length; j++)
                    {
                        bin = "0" + bin;
                    }
                }

                block.Add(bin);
            }

            for (int i = 0; i < block.Count; i++)
            {
                //chiper_encrypt_rtb.Text += block[i] + " ";
                BigInteger value = Convert.ToInt64(block[i], 2);
                big = pangkatDekrip(value, en, n);
                chiper_encrypt_rtb.Text += BigInteger.Parse(big.ToString()).ToString("X") + "O";
            }

            proses = new Thread(new ThreadStart(encrypt));
            loading = new Thread(new ThreadStart(loads));

            load.Close();
        }
        private void decrypt_btn_Click(object sender, EventArgs e)
        {
            //decrypt();
            decryptThread.Start();
            loading.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cikan = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
            }
        }

        public BigInteger pangkatDekrip(BigInteger a, BigInteger n, BigInteger m)
        {
            if (n == 0)
            {
                return 1;
            }
            else 
            {
                if (n % 2 != 0)
                    return pangkat(pangkatDekrip(a, n / 2, m), 2) * a % m;
                else
                    return pangkat(pangkatDekrip(a, n / 2, m), 2) % m;
            }
        }
        public void decrypt()
        {
            plain_decrypt_rtb.Clear();
            binary = new List<string>();
            block = new List<string>();
            List<string> cesar = new List<string>();
            int c = 0;

            for (int i = 0; i < chiper_encrypt_rtb.Text.Length; i++)
            {
                if (c != 0 && chiper_encrypt_rtb.Text.Substring(i, 1) == "O")
                {
                    string asd = (BigInteger.Parse(chiper_encrypt_rtb.Text.Substring(i - c, c), System.Globalization.NumberStyles.HexNumber)).ToString();
                    //big = BigInteger.Parse(chiper_encrypt_rtb.Text.Substring(i - c, c));
                    //int dek = (int)((pangkat((BigInteger)int.Parse(asd), (BigInteger)d)) % n);
                    BigInteger dek = pangkatDekrip(BigInteger.Parse(asd), d, n);
                    string bin = Convert.ToString((Int64)dek, 2);
                    string temp = bin;

                    //plain_decrypt_rtb.Text += dek.ToString() + " ";
                    if (bin.Length < 32)
                    {
                        for (int j = 0; j < 32 - bin.Length; j++)
                        {
                            temp = "0" + temp;
                        }
                    }

                    block.Add(temp);
                    //plain_decrypt_rtb.Text += temp + " ";
                    c = 0;
                }
                else
                {
                    c++;
                }
            }

            for (int i = 0; i < block.Count; i++)
            {
                //plain_decrypt_rtb.Text += block[i] + " ";
                if (block[i].Substring(0, 24) == "000000000000000000000000")
                {
                    binary.Add(block[i].Substring(24, 8));
                }
                else if (block[i].Substring(0, 16) == "0000000000000000")
                {
                    binary.Add(block[i].Substring(16, 8));
                    binary.Add(block[i].Substring(24, 8));
                }
                else if (block[i].Substring(0, 8) == "00000000")
                {
                    binary.Add(block[i].Substring(8, 8));
                    binary.Add(block[i].Substring(16, 8));
                    binary.Add(block[i].Substring(24, 8));
                }
                else
                {
                    binary.Add(block[i].Substring(0, 8));
                    binary.Add(block[i].Substring(8, 8));
                    binary.Add(block[i].Substring(16, 8));
                    binary.Add(block[i].Substring(24, 8));
                }
            }

            for (int i = 0; i < binary.Count; i++)
            {
                //plain_decrypt_rtb.Text += binary[i] + " ";
                cesar.Add(Convert.ToInt32(binary[i], 2).ToString());
                Int64 caesar = (Int64.Parse(cesar[i]) - 3) % 255;
                if (caesar == -2)
                    caesar = 253;
                else if (caesar == -1)
                    caesar = 254;
                else if (caesar == 0)
                    caesar = 255;
                plain_decrypt_rtb.Text += Convert.ToChar(caesar);
            }

            decryptThread = new Thread(new ThreadStart(decrypt));
            loading = new Thread(new ThreadStart(loads));

            load.Close();
        }
        private void generate_Click(object sender, EventArgs e)
        {
            generateKey();
        }
        public void loads()
        {
            load = new LoadingEncrypt();
            load.ShowDialog(this);
        }
        public void generateKey()
        {
            primeRandom();
            publicKey();

            if (d < 0)
            {
                while (d < 0)
                {
                    primeRandom();
                    publicKey();
                }
            }

            public_txt.Text = en.ToString() + ", " + m.ToString();
            private_txt.Text = d.ToString() + ", " + m.ToString();
        }
    }
}
