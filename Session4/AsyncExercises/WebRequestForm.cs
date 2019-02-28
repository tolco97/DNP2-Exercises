using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace AsyncExercises
{
    public partial class WebRequestForm : Form
    {
        public WebRequestForm()
        {
            InitializeComponent();
        }

        private void synchButton_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create(new Uri("https://inseroats.com/"));
            var response = request.GetResponse();
            var reader = new StreamReader(response.GetResponseStream());
            webRequestTextBox.Text = reader.ReadToEnd();
            reader?.Dispose();
        }

        private void asyncCallbackButton_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create(new Uri("https://inseroats.com/"));
            request.BeginGetResponse(asyncResult =>
            {
                var response = request.EndGetResponse(asyncResult);
                var reader = new StreamReader(response.GetResponseStream());
                webRequestTextBox.Text = reader.ReadToEnd();
                reader.Dispose();
            }, null);
        }

        private async void asyncKeywordButton_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create(new Uri("https://inseroats.com/"));
            WebResponse response = await request.GetResponseAsync();
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                webRequestTextBox.Text = reader.ReadToEnd();
            }
        }
    }
}