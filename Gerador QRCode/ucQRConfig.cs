using Entities.Configurations;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gerador_QRCode
{
    public partial class ucQRConfig : UserControl
    {
        public ucQRConfig()
        {
            InitializeComponent();
        }

        private void ucQRConfig_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;
               //Tamanho
               cmbTamanho.Items.Clear();
               for (int i = 0; i < 10; i++)
                   cmbTamanho.Items.Add(string.Format("{0}X{0}", i*100));

             //charset-source
             cmbCharsetSource.Items.Clear();
             cmbCharsetSource.Items.Add("ISO 88859-1");
             cmbCharsetSource.Items.Add("UTF-8");

             //charset-target
             cmbCharsetTarget.Items.Clear();
             cmbCharsetTarget.Items.Add("ISO 88859-1");
             cmbCharsetTarget.Items.Add("UTF-8");

             //ECC
             cmbEcc.Items.Clear();
             cmbEcc.Items.Add("L");
             cmbEcc.Items.Add("M");
             cmbEcc.Items.Add("Q");
             cmbEcc.Items.Add("H");

             //Cor
             cmbCor.Items.Clear();
             cmbCor.Items.Add(Color.Black);
             cmbCor.Items.Add(Color.Red);
            cmbCorFundo.Items.Add(Color.White);
            cmbCor.Items.Add(Color.Blue);
             cmbCor.Items.Add(Color.Green);

             //Cor de fundo
             cmbCorFundo.Items.Clear();
            cmbCorFundo.Items.Add(Color.White);
            cmbCorFundo.Items.Add(Color.Black);
             cmbCorFundo.Items.Add(Color.Red);
             cmbCorFundo.Items.Add(Color.Blue);
             cmbCorFundo.Items.Add(Color.Green);

             //Margem
             cmbMargem.Items.Clear();
             for (int i = 0; i < 50; i++)
                 cmbMargem.Items.Add(i);

             //Qzone
             cmbQzone.Items.Clear();
             for (int i = 0; i < 50; i++)
                 cmbQzone.Items.Add(i);

            //Formato
             cmbFormato.Items.Clear();
            cmbFormato.Items.Add("png");
            cmbFormato.Items.Add("gif");
            cmbFormato.Items.Add("jpeg");
            cmbFormato.Items.Add("jpg");

            SetDefaultOptions();

        }

        public void SetDefaultOptions()
        {
            cmbTamanho.SelectedIndex = 1;
            cmbCharsetSource.SelectedIndex = 1;
            cmbCharsetTarget.SelectedIndex = 1;
            cmbEcc.SelectedIndex = 0;
            cmbCor.SelectedIndex = 0;
            cmbCorFundo.SelectedIndex = 0;
            cmbMargem.SelectedIndex = 1;
            cmbQzone.SelectedIndex = 0;
            cmbFormato.SelectedIndex = 0;
        }

        public QRConfig GetConfig()
        {
            var config = new QRConfig();

            config.Tamnho = cmbTamanho.SelectedItem.ToString();
            config.CharsetSource = cmbCharsetSource.SelectedItem.ToString();
            config.CharsetTarget = cmbCharsetTarget.SelectedItem.ToString();
            config.ECC = cmbEcc.SelectedItem.ToString()[0];
            config.Cor = cmbCor.SelectedItem.ToString();
            config.CorFundo = cmbCorFundo.SelectedItem.ToString();
            config.Margem = Convert.ToInt32(cmbMargem.SelectedItem.ToString());
            config.Qzone = Convert.ToInt32(cmbQzone.SelectedItem.ToString());
            config.Formato = cmbFormato.SelectedItem.ToString();
            return config;
        } 
    }
}
