using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Policy;
using System.Windows.Forms;

namespace SMTPtester
{
    public partial class Form1 : Form
    {
        private int counter = 0;

        public Form1()
        {
            InitializeComponent();
            
            txtName.Enabled = false;
            txtFilepath.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;

            SmtpClient client = new SmtpClient();

            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Host = server.Text;
            client.Port = int.Parse(port.Text);
            client.Credentials = new NetworkCredential(login.Text, password.Text);

            client.EnableSsl = isSSLEnabled.Checked;
            client.Timeout = 10 * 1000;

            MailMessage message = new MailMessage(this.sender.Text, receiver.Text);
            message.Subject = "SMTP test";
            message.Body = "Test " + counter + " at " + DateTime.Now;


            if (hasAttachment.Checked)
            {
                var attachment = loadAttachment(txtFilepath.Text,txtName.Text);
                message.Attachments.Add(attachment);
            }

            try
            {
                client.Send(message);
                consolebox.Text += counter + " sent success \n";
                button1.BackColor = Color.ForestGreen;
            }
            catch (Exception ex)
            {
                button1.BackColor = Color.Red;
                consolebox.Text += counter + "sent fail\n" + ex.Message + ":" + ex.InnerException;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            consolebox.Text = "";
        }

        private Attachment loadAttachment(string fileName, string name)
        {
            var attachement = new Attachment(fileName);
            attachement.Name = name;
            return attachement;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var enabled = hasAttachment.Checked;
            
            {
                txtName.Enabled = enabled;
                txtFilepath.Enabled = enabled;
            }
        }

        private void txtFilepath_TextChanged(object sender, EventArgs e)
        {
            var text = txtFilepath.Text;
            if (System.IO.File.Exists(text))
            {
                txtFilepath.BackColor = Color.Green;
            }
            else
            {
                txtFilepath.BackColor = Color.Orange;
            }
        }
    }

}