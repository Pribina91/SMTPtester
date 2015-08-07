using System;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace SMTPtester
{
    public partial class Form1 : Form
    {
        private int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;

            SmtpClient client = new SmtpClient();

            client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            client.Host = this.server.Text;
            client.Port = int.Parse(this.port.Text);
            client.Credentials = new System.Net.NetworkCredential(this.login.Text, this.password.Text);

            client.EnableSsl = this.isSSLEnabled.Checked;
            client.Timeout = 5000;

            MailMessage message = new MailMessage(this.sender.Text, this.receiver.Text);
            message.Subject = "SMTP test";
            message.Body = "Test " + counter + " at " + DateTime.Now;

            try
            {
                client.Send(message);
                this.consolebox.Text += counter + " sent success \n";
                this.button1.BackColor = Color.ForestGreen;
            }
            catch (Exception ex)
            {
                this.button1.BackColor = Color.Red;
                this.consolebox.Text += counter + "sent fail\n" + ex.Message + ":" + ex.InnerException;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.consolebox.Text = "";
        }
    }
}