using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeabizDemo
{
    public partial class Form1 : Form
    {
        IdeabizRequestHandler h = null;
        public Form1()
        {

            InitializeComponent();

            /*
            Construct the Ideabiz Request handler
            */
             h= new IdeabizRequestHandler();


            /*
            Read and set API credential to UI only for demo
            */
            txtCONSUMERSECRET.Text = h.IdabizAuth.CONSUMER_SECRET;
            txtCONSUMERKEY.Text = h.IdabizAuth.CONSUMER_KEY;
            txtREFRESHTOKEN.Text = h.IdabizAuth.REFRESH_TOKEN;
            txtACCESSTOKEN.Text = h.IdabizAuth.ACCESS_TOKEN;
            txtTOKENURL.Text = h.IdabizAuth.TOKEN_API;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
            Getting JSON body from JSON for demo. Then set the parameters. then convert it to JSON String
            For production, please create proper class and OBJECTS from those
            */

            String sms = "{\"outboundSMSMessageRequest\":{\"address\":[\"tel:+94777339033\"],\"senderAddress\":\"tel:7555\",\"outboundSMSTextMessage\":{\"message\":\"Test Message\"},\"clientCorrelator\":\"123456\",\"receiptRequest\":{\"notifyURL\":\"http://128.199.174.220:1080/sms/report\",\"callbackData\":\"some-data-useful-to-the-requester\"},\"senderName\":\"87770\"}}";
            dynamic data = JsonConvert.DeserializeObject<dynamic>(sms);
            data.outboundSMSMessageRequest.address[0] = "tel:+" + txtMSISDN.Text.Trim();
            data.outboundSMSMessageRequest.outboundSMSTextMessage.message = txtMessage.Text;
            sms = JsonConvert.SerializeObject(data);
            
            
            String url = "https://ideabiz.lk/apicall/smsmessaging/v2/outbound/" + txtMSISDN.Text.Trim() + "/requests";

            textBox1.Text += "Sending SMS : " + url +Environment.NewLine;
            textBox1.Text += sms + Environment.NewLine;

            try
            {
                /*
                Sending API call to URL with Body. Result can get from IdeabizResponse class
                */
                IdeabizResponse r = h.sendAPICall(url, IdeabizAPIAuth.REQUEST_METHOD.POST, sms, "application/json","application/json");
                textBox1.Text += "Status : " + r.Status + ", Code : " + r.StatusCode + Environment.NewLine;
                textBox1.Text += r.Body + Environment.NewLine;
            }
            catch (Exception ex)
            {
                textBox1.Text += "Error: " + ex.Message + Environment.NewLine;
            }
            textBox1.Text += "============================================" + Environment.NewLine;

        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            String url = "https://ideabiz.lk/apicall/location/v1/queries/location?address="+ txtMSISDN.Text.Trim() +"&requestedAccuracy=1000";
            textBox1.Text += "Sending SMS : " + url + Environment.NewLine;

            try
            {
                /*
                Sending API call to URL with Body. Result can get from IdeabizResponse class
                */
                IdeabizResponse r = h.sendAPICall(url, IdeabizAPIAuth.REQUEST_METHOD.GET, null, "application/x-www-form-urlencoded", "application/json");
                textBox1.Text += "Status : " + r.Status + ", Code : " + r.StatusCode + Environment.NewLine;
                textBox1.Text += r.Body + Environment.NewLine;
            }
            catch (Exception ex)
            {
                textBox1.Text += "Error: " + ex.Message + Environment.NewLine;
            }

            textBox1.Text += "============================================" + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            Read and set API credential to UI only for demo
           */
            txtCONSUMERSECRET.Text = h.IdabizAuth.CONSUMER_SECRET;
            txtCONSUMERKEY.Text = h.IdabizAuth.CONSUMER_KEY;
            txtREFRESHTOKEN.Text = h.IdabizAuth.REFRESH_TOKEN;
            txtACCESSTOKEN.Text = h.IdabizAuth.ACCESS_TOKEN;
            txtTOKENURL.Text = h.IdabizAuth.TOKEN_API;
            textBox1.Text += "Load settings..." + Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
             Save UI credential to App settings
           */
            h.IdabizAuth.CONSUMER_SECRET = txtCONSUMERSECRET.Text;
            h.IdabizAuth.CONSUMER_KEY = txtCONSUMERKEY.Text;
            h.IdabizAuth.REFRESH_TOKEN = txtREFRESHTOKEN.Text;
            h.IdabizAuth.ACCESS_TOKEN = txtACCESSTOKEN.Text;
            h.IdabizAuth.TOKEN_API = txtTOKENURL.Text;
            h.IdabizAuth.saveSettings();
            textBox1.Text +=  "Saved settings..." + Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
