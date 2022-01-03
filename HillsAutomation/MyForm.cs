using HillsAutomation.config;
using HillsAutomation.valueObject;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace HillsAutomation
{

    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        // Get some values of init
        private DatabaseConfig ReadInitialConfig()
        {
            try
            {
                StreamReader sr = new StreamReader("settings.ini");

                String jsonStr = sr.ReadToEnd();
                DatabaseConfig config = JsonConvert.DeserializeObject<DatabaseConfig>(jsonStr);

                //MessageBox.Show(config.database);

                return config;
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            } 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_height.Text)) { return; };
            if (String.IsNullOrEmpty(tb_width.Text)) { return; };
            if (String.IsNullOrEmpty(tb_serial.Text)) { return; };
            if (String.IsNullOrEmpty(tb_writePath.Text)) { return; };

            lb_loading.Visible = true;
            InsertQrCode();
        }

        // Getting QRCode from Hills API
        private QRCodeObject[] FeedQRCodes(int qtd)
        {
            String url = "http://200.229.206.31:8081/api/GetQrCodeAvliable/" + "hills" + "/" + qtd;

            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                WebClient webClient = new WebClient();

                webClient.Headers.Add("content-type", "application/json");
                string responseBody = Encoding.ASCII.GetString(webClient.DownloadData(url));
                QRCodeObject[] qr = JsonConvert.DeserializeObject<QRCodeObject[]>(responseBody);

                return qr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Connection MySql
        private void InsertMySql(QRCodeObject qrObject)
        {
            //define o dataset
            DataSet mDataSet = new DataSet();

            var ret =  ReadInitialConfig();
            String connectionString = " Persist Security Info=False;server=" + ret.host +
                ";port=" + ret.port +
                ";database=" + ret.database +
                ";userid = " + ret.user +
                ";pwd = " + ret.password;

            //define string de conexao e cria a conexao
            MySqlConnection mConn = new MySqlConnection(connectionString);

          try
            {
                //abre a conexao
                mConn.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());

            }



            //verificva se a conexão esta aberta
            if (mConn.State == ConnectionState.Open)
            {
                String guid = Guid.NewGuid().ToString();

                String query = "INSERT INTO " + ret.database +
                    ".serial (`ID`, `SERIAL`, `STATUS`, `BASE64`, `LINHA`) VALUES ('" + guid + 
                    "', '" + qrObject.Serial +
                    "', '0', '" + qrObject.QrCodeBase + "', '1')";

                MySqlCommand myCommand = new MySqlCommand(query, mConn);
                myCommand.ExecuteNonQuery();
                //atribui a resultado a propriedade DataSource do DataGrid

                mConn.Close();
            }
        }

        // Generate QRCode
        public Bitmap GerarQRCode(int width, int height, int margin, byte[] bin)
        {
            try
            {
                var bw = new ZXing.BarcodeWriter();
                
                var options = new ZXing.QrCode.QrCodeEncodingOptions
                {
                    CharacterSet = "ISO-8859-15",
                    DisableECI = true,
                    Width = width,
                    Height = height,
                    Margin = margin
                };
                bw.Options = options;
                bw.Format = ZXing.BarcodeFormat.QR_CODE;

                var content = System.Text.Encoding.GetEncoding("ISO-8859-15").GetString(bin);
                var resultado = new Bitmap(bw.Write(content));
                
                return resultado;
            }
            catch
            {
                throw;
            }
        }

        // Main logic
        private void InsertQrCode()
        {
            QRCodeObject[] qrObject = FeedQRCodes(Convert.ToInt32(tb_serial.Text));

            foreach (QRCodeObject qr in qrObject)
            {
                InsertMySql(qr);
                byte[] decodedQr = Convert.FromBase64String(qr.QrCodeBase);
                Bitmap ret = GerarQRCode(Convert.ToInt16(tb_width.Text), Convert.ToInt16(tb_height.Text),
                      0, decodedQr);

                ret.Save(tb_writePath.Text + "/" + qr.Serial + ".bmp", ImageFormat.Bmp);

                pb_qrcode.Image = ret;
            }
            lb_loading.Visible = false;
        }
        
        // Getting path
        private void tb_writePath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    tb_writePath.Text = fbd.SelectedPath;
                }
            }
        }

    }
}
