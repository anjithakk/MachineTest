using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MachineTest
{

    public partial class frmPics : Form
    {

        public frmPics()
        {
            InitializeComponent();

            System.Net.WebRequest req1 = System.Net.WebRequest.Create("https://picsum.photos/seed/picsum/200/300.jpg");
            System.Net.WebResponse resp1 = req1.GetResponse();
            System.IO.Stream respstream1 = resp1.GetResponseStream();
            Bitmap bitmap1 = new Bitmap(respstream1);
            pnlimg.BackgroundImage = bitmap1;

            pnlimg.BackgroundImageLayout = ImageLayout.Stretch;

            Timer tm = new Timer();
            tm.Interval = 3000;
            tm.Tick += new EventHandler(ChangeImages);
            tm.Start();

        }
        private void ChangeImages(object sender, EventArgs e)
        {
            List<Bitmap> b = new List<Bitmap>();

            System.Net.WebRequest req2 = System.Net.WebRequest.Create("https://picsum.photos/200/300/?blur.jpg");
            System.Net.WebResponse resp2 = req2.GetResponse();
            System.IO.Stream respstream2 = resp2.GetResponseStream();
            Bitmap bitmap2 = new Bitmap(respstream2);

            System.Net.WebRequest req3 = System.Net.WebRequest.Create("https://picsum.photos/id/237/200/300.jpg");
            System.Net.WebResponse resp3 = req3.GetResponse();
            System.IO.Stream respstream3 = resp3.GetResponseStream();
            Bitmap bitmap3 = new Bitmap(respstream3);

            System.Net.WebRequest req4 = System.Net.WebRequest.Create("https://picsum.photos/seed/picsum/200/300.jpg");
            System.Net.WebResponse resp4 = req4.GetResponse();
            System.IO.Stream respstream4 = resp4.GetResponseStream();
            Bitmap bitmap4 = new Bitmap(respstream4);

            System.Net.WebRequest req5 = System.Net.WebRequest.Create("https://picsum.photos/200/300.jpg");
            System.Net.WebResponse resp5 = req5.GetResponse();
            System.IO.Stream respstream5 = resp5.GetResponseStream();
            Bitmap bitmap5 = new Bitmap(respstream5);

            System.Net.WebRequest req6 = System.Net.WebRequest.Create("https://picsum.photos/200/300?grayscale.jpg");
            System.Net.WebResponse resp6 = req6.GetResponse();
            System.IO.Stream respstream6 = resp6.GetResponseStream();
            Bitmap bitmap6 = new Bitmap(respstream6);


            b.Add(bitmap2);
            b.Add(bitmap3);
            b.Add(bitmap4);
            b.Add(bitmap5);
            b.Add(bitmap6);

            int index = DateTime.Now.Second % b.Count;
            pnlimg.BackgroundImage = b[index];

            pnlimg.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}

