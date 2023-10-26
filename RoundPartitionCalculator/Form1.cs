namespace RoundPartitionCalculator
{
    public partial class Form1 : Form
    {
        private double tbValue = 0;
        private double gbValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void linkSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkSource.LinkVisited = true;

            System.Diagnostics.Process.Start("https://community.spiceworks.com/how_to/52967-create-perfect-round-number-hard-drive-partitions");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTbValue_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                bool canParse = double.TryParse(txtTbValue.Text, out double value);
                if (canParse)
                {
                    double mbValue = value * 1000000;
                    double mibValue = mbValue * 1.048576;
                    double overheadValue = mibValue + 4096;

                    this.tbValue = overheadValue;


                    txtTbConvertToMb.Text = _formatNumber(mbValue);
                    txtTbConvertToMib.Text = _formatNumber(mibValue);
                    txtTbOverhead.Text = _formatNumber(overheadValue);

                    btnCopyTb.Enabled = true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                txtTbConvertToMb.Text = string.Empty;
                txtTbConvertToMib.Text = string.Empty;
                txtTbOverhead.Text = string.Empty;
                btnCopyTb.Enabled = false;

                lblError.Text = ex.Message;

                this.tbValue = 0;
            }
        }




        private string _formatNumber(double number)
        {
            //string code = "#,##0.00";
            string code = "#,##0";
            number = Math.Round(number, 0);

            return number.ToString(code, System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        }

        private void btnCopyTb_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbValue.ToString());
        }

        private void btnCopyGb_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.gbValue.ToString());
        }

        private void txtGbValue_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                bool canParse = double.TryParse(txtGbValue.Text, out double value);
                if (canParse)
                {
                    double mbValue = value * 1000;
                    double mibValue = mbValue * 1.024;
                    double overheadValue = mibValue + 1024;

                    this.gbValue = overheadValue;


                    txtGbConvertToMb.Text = _formatNumber(mbValue);
                    txtGbConvertToMib.Text = _formatNumber(mibValue);
                    txtGbOverhead.Text = _formatNumber(overheadValue);

                    btnCopyGb.Enabled = true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                txtGbConvertToMb.Text = string.Empty;
                txtGbConvertToMib.Text = string.Empty;
                txtGbOverhead.Text = string.Empty;
                btnCopyGb.Enabled = false;

                lblError.Text = ex.Message;

                this.gbValue = 0;
            }

        }
    }
}