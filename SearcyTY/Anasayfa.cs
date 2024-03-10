using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace SearcyTY
{
    public partial class SearchTY : Form
    {
        public SearchTY()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void SearchTY_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "Bilgilendirme...", "Program çalışıyor.", ToolTipIcon.Info);
            }
        }
        Thread th;
        SqlConnection cn2 = new SqlConnection("Data Source=45.158.14.59;User ID=UserES;Initial Catalog=_EsepetDB;Password=*z9kazer;");
        SqlConnection cn = new SqlConnection("Data Source=45.158.14.59;User ID=UserES;Initial Catalog=_EsepetDB;Password=*z9kazer;");
        SqlCommand cmd = new SqlCommand();
        int Analys = 0;
        private void SearchTY_Load(object sender, EventArgs e)
        {
            this.Text = "SearchTY V:" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            PlaceLowerRight();

            TM_Progress.Start();
            Timer_Control.Start();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            try
            {

                Cef.GetGlobalCookieManager().DeleteCookies();
                th = new Thread(TYListedokum); th.Start();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message, "Program Erorr");
            }
            Timer_Control.Start();
        }

        private void PlaceLowerRight()
        {
            //Determine "rightmost" screen
            Screen rightmost = Screen.AllScreens[0];
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                    rightmost = screen;
            }

            this.Left = rightmost.WorkingArea.Right - this.Width;
            this.Top = rightmost.WorkingArea.Bottom - this.Height;
        }

        private void TYListedokum()
        {
            LB_ProductId.Items.Clear();
            LB_Products_links.Items.Clear();

            cn.Open();

            // Sorguyu çalıştırmak için bir SqlCommand oluşturuluyor
            SqlCommand cmd = new SqlCommand("SP_product_list_forSearch", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            // SP_product_list_forSearch saklı yordamının parametresi ekleniyor
            cmd.Parameters.AddWithValue("@NR_Id", TY_Magaza_Id.Text);

            // SqlDataReader ile verileri oku
            SqlDataReader dr = cmd.ExecuteReader();

            // Satır sayacı
            int str = 0;

            // SqlDataReader'da veri varsa
            while (dr.Read())
            {
                str++;

                // Verileri liste kutularına ekleyin
                LB_ProductId.Items.Add(dr[1].ToString());
                LB_Products_links.Items.Add(dr[2].ToString());
            }

            // SqlDataReader kapatılıyor
            dr.Close();

            // Veritabanı bağlantısı kapatılıyor
            cn.Close();

            Lbl_Total_Products.Text = str.ToString();
            TM_Progress.Stop();
            GB_Group.Visible = false;
            Lbl_Control.Text = "1";
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {

        }

        private void Timer_TM_Tick(object sender, EventArgs e)
        {
            say++;
            if (say == 3)
            {
                Task<String> taskHtml = CW.GetBrowser().MainFrame.GetSourceAsync();
                dokuman = taskHtml.Result;
                Timer_TM.Stop();
                Timer_TM.Interval = 1000;
                TrendyolDocument();
                Analys++;
                TotalSearch++;
                Lbl_total_Search.Text = TotalSearch.ToString();
            }
        }

        int TG1 = 1;
        int TotalSearch = 0;
        private void Timer_Git_Tick(object sender, EventArgs e)
        {
            TG1 = TG1 - 1;
            if (TG1 == 0)
            {
                if (Analys == LB_Products_links.Items.Count)
                {
                    Analys = 0;
                    string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    System.Diagnostics.Process.Start(path);
                    System.Environment.Exit(3);
                }
                Lbl_Control.Text = "0";
                Timer_Git.Stop();
                TG1 = 1;
                CW.LoadUrl("https://www.trendyol.com" + LB_Products_links.Items[Analys].ToString());
                CW.LoadingStateChanged += OnLoadingStateChanged;
                Timer_TM.Start();
                say = 0;
                Lbl_Searching.Text = LB_ProductId.Items[Analys].ToString() + "/" + Analys.ToString() + ". Ürün Analiz Ediliyor";
                CefSharpSettings.SubprocessExitIfParentProcessClosed = true;
                
            }
        }
        private void OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        {
            if (!args.IsLoading)
            {
                say = 0;
            }
        }

        int say = 0;
        string dokuman = "";
        private async void TrendyolDocument()
        {
            SqlCommand command2 = new SqlCommand("SP_Insert_productrivaldetails", cn2);
            command2.CommandType = CommandType.StoredProcedure;

            // SP_product_rivals_search saklı yordamını çağırmak için SqlCommand oluşturuluyor
            SqlCommand command = new SqlCommand("SP_Insert_product_search", cn2);
            command.CommandType = CommandType.StoredProcedure;
            var result=0;
            try
           {

                string webdokuman = dokuman;
                string S1S = S1.Text;
                int Basla = 0;

                String barcode = "";
                int b1 = webdokuman.IndexOf(Txt_SearchCode_barcode.Text, 0); 
                if (b1 > 0)
                {
                    int b2 = webdokuman.IndexOf(",", b1);
                    barcode = webdokuman.Substring(b1 + 11, b2 - (b1 + 12));

                }

                int productId = webdokuman.IndexOf(Txt_SearchCode1.Text, 0); 
                string yeniproductId = "";
                if (productId > 0)
                {
                    int b3 = webdokuman.IndexOf(",", productId + 5);
                    yeniproductId = webdokuman.Substring(productId + 8, b3 - (productId + 9));

                }
                else
                {
                    productId = webdokuman.IndexOf("data-seed-id=", 0); 
                    int b3 = webdokuman.IndexOf("data-content-id", productId + 5);
                    yeniproductId = webdokuman.Substring(productId + 14, b3 - (productId + 16));
                }

                int Id = 0;
                int saved = 0;
                string searchcode = "";
                DateTime T1 = DateTime.Now;
                searchcode = T1.Year.ToString() + T1.Month.ToString() + T1.Day.ToString() + T1.Hour.ToString() + T1.Minute.ToString() + T1.Millisecond.ToString();

            gel:
                Id = Id + 1;
                int deger1 = webdokuman.IndexOf(S1S, Basla);
                if (deger1 > Basla)
                {

                    int deger2 = webdokuman.IndexOf(S2.Text, deger1);
                    int deger3 = webdokuman.IndexOf("officialName", deger2);
                    string firmaadi = webdokuman.Substring(deger2 + 8, deger3 - (deger2 + 11));
                    string FirmaId = webdokuman.Substring(deger1 + 17, deger2 - (deger1 + 18));

                    int deger4 = webdokuman.IndexOf(S3.Text, deger3);
                    int deger5 = webdokuman.IndexOf("price", deger4);
                    string stok = webdokuman.Substring(deger4 + 12, deger5 - (deger4 + 14));

                    int deger6 = webdokuman.IndexOf("sellingPrice", deger5);
                    int deger7 = webdokuman.IndexOf("originalPrice", deger6);
                    string Fiyat = webdokuman.Substring(deger6 + 14, deger7 - (deger6 + 16));
                    command2.Parameters.Clear();
                    if (saved == 0)
                    {

                        command.CommandType = CommandType.StoredProcedure;

                        // Parametreler ekleniyor
                        command.Parameters.AddWithValue("@NBarcode", barcode);
                        command.Parameters.AddWithValue("@NProductId", yeniproductId);
                        command.Parameters.AddWithValue("@NSearchCode", searchcode.ToString());
                        command.Parameters.AddWithValue("@MP", "Trendyol");
                        command.Connection.Open();
                        result = command.ExecuteNonQuery();
                        command.Connection.Close();

                        saved = 1;
                    }

                    command2.CommandType = CommandType.StoredProcedure;

                    // Parametreler ekleniyor
                    command2.Parameters.AddWithValue("@NProductId", yeniproductId);
                    command2.Parameters.AddWithValue("@NR_Id", FirmaId);
                    command2.Parameters.AddWithValue("@NRival_Name", firmaadi);
                    command2.Parameters.AddWithValue("@NStock", Int32.Parse(stok));
                    command2.Parameters.AddWithValue("@NBuybox", Id);
                    command2.Parameters.AddWithValue("@NPrice", Fiyat);
                    command2.Parameters.AddWithValue("@NSearchCode", searchcode.ToString());

                    command2.Connection.Open();
                    result = command2.ExecuteNonQuery();
                    command2.Connection.Close();

                    Basla = deger7;
                    goto gel;
                }

                Lbl_Control.Text = "1";
            }
            catch (Exception e)
            {
                //""

                Lbl_Control.Text = "4";
                if (command2.Connection.State != ConnectionState.Open)
                {
                    command2.Connection.Close();
                }
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Close();
                }

                SqlCommand command3 = new SqlCommand("Insert Into ErrorLogs (ProductId,ErrorDetails) Values("+LB_ProductId.Items[Analys].ToString()+","+ e.Message.ToString() + ") ", cn);
                try
                {
                    // SP_UpdateProductBuybox saklı yordamını çağırmak için SqlCommand oluşturuluyor

                    command3.CommandType = CommandType.Text;

                    // Bağlantı açılıyor
                    command3.Connection.Open();

                    // Saklı yordam çalıştırılıyor
                    var result2 = command3.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    // Hata durumunda burası çalışacak
                }
                finally
                {
                    // Bağlantı kapatılıyor
                    
                }
            }


        }

        private void Lbl_Control_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Control_Tick(object sender, EventArgs e)
        {
            if (Lbl_Control.Text == "1")
            {
                Timer_Git.Start();
            }

            if (Lbl_Control.Text == "4")
            {
                Timer_Git.Start();
                Timer_TM.Interval = 30000;
            }
        }

        int PRogress = 0;
        private void TM_Progress_Tick(object sender, EventArgs e)
        {
            PRogress++;
            if (PRogress == 100)
            {
                PRogress = 0;
                progressBar1.Value = PRogress;
            }
            else
            {
                progressBar1.Value = PRogress;
            }
        }

    }
}
