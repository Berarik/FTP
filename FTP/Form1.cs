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
using System.Net;
namespace FTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void B_Click(object sender, EventArgs e)
        {
            FtpWebRequest ftp;
            ftp = (FtpWebRequest)WebRequest.Create(new Uri("ftp://localhost/Учеба/3 курс/СиТ/FTP/FTP/Form1.cs"));
            ftp.Credentials = new NetworkCredential("user", "user");
            ftp.Method = WebRequestMethods.Ftp.DownloadFile;//.PrintWorkingDirectory;
            FtpWebResponse response = (FtpWebResponse)ftp.GetResponse();
            Stream streamftp = response.GetResponseStream();
            StreamReader streamreaderftp = new StreamReader(streamftp);
            TB1.Text = streamreaderftp.ReadToEnd();
            TB2.Text = response.StatusDescription;
            streamftp.Close();
            //ftp.Method = WebRequestMethods.Ftp.DownloadFile;
            //response = (FtpWebResponse)ftp.GetResponse();
            //streamftp = response.GetResponseStream();
            //streamreaderftp = new StreamReader(streamftp);
            //TB1.Text += streamreaderftp.ReadToEnd();
            //TB2.Text += response.StatusDescription;

        }

        private void B2_Click(object sender, EventArgs e)//передача
        {
            string filename = "dno";            
            FileInfo fileInf = new FileInfo(filename);
            FtpWebRequest ftp;
            ftp = (FtpWebRequest)WebRequest.Create(new Uri("ftp://localhost/"+filename));
            ftp.Credentials = new NetworkCredential("user", "user");
            ftp.Method = WebRequestMethods.Ftp.UploadFile;//.PrintWorkingDirectory;
            ftp.UseBinary = true;
            ftp.ContentLength = fileInf.Length;
            FileStream filestream = fileInf.OpenRead();
            FtpWebResponse response = (FtpWebResponse)ftp.GetResponse();
            Stream streamftp = response.GetResponseStream();
            StreamReader streamreaderftp = new StreamReader(streamftp);
            TB1.Text = streamreaderftp.ReadToEnd();
            TB2.Text = "file"+filestream.ToString()+"\n";
            TB2.Text += response.StatusDescription;
            streamftp.Close();
            filestream.Close();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            FtpWebRequest ftp;
            ftp = (FtpWebRequest)WebRequest.Create(new Uri("ftp://localhost/Учеба/3 курс/"));
            ftp.Credentials = new NetworkCredential("user", "user");
            ftp.Method = WebRequestMethods.Ftp.ListDirectory;//.PrintWorkingDirectory;
            FtpWebResponse response = (FtpWebResponse)ftp.GetResponse();
            Stream streamftp = response.GetResponseStream();
            StreamReader streamreaderftp = new StreamReader(streamftp);
            TB1.Text = streamreaderftp.ReadToEnd();
            TB2.Text = response.StatusDescription;
        }

        //private void B4_Click(object sender, EventArgs e)
        //{
        //    FtpWebRequest ftp;
        //    ftp = (FtpWebRequest)WebRequest.Create(new Uri("ftp://localhost/Учеба/3 курс/СиТ/FTP/FTP/Form1.cs"));
        //    ftp.Credentials = new NetworkCredential("user", "user");
        //    ftp.Method = WebRequestMethods.Ftp.DownloadFile;//.PrintWorkingDirectory;
        //    FtpWebResponse response = (FtpWebResponse)ftp.GetResponse();
        //    Stream streamftp = response.GetResponseStream();
        //    StreamReader streamreaderftp = new StreamReader(streamftp);
        //    TB1.Text += streamreaderftp.ReadToEnd();
        //    TB2.Text += response.StatusDescription;
        //}
    }
}
