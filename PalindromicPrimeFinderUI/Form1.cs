using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using PalindromicPrimeFinderLogic;

namespace PalindromicPrimeFinderUI
{
  public partial class FormFinder : Form
  {
    public FormFinder()
    {
      InitializeComponent();

      List<string> numberSystems = new List<string>();
      numberSystems.Add("Decimal");
      numberSystems.Add("Binary");

      cb_NumberSystem.DataSource = numberSystems.Select(p => new {Key = p, Value = p}).ToList();
      cb_NumberSystem.DisplayMember = "Key";
      cb_NumberSystem.ValueMember = "Value";
      cb_NumberSystem.SelectedValue = numberSystems[0];
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void bt_Find_Click(object sender, EventArgs e)
    {
      if (tb_FromValue.Text != "" && tb_ToValue.Text != "")
      {
        int lowerRange = Convert.ToInt32(tb_FromValue.Text);
        int upperRange = Convert.ToInt32(tb_ToValue.Text);

        if (lowerRange > upperRange)
          MessageBox.Show("To value should be greater than From value.");

        else
        {
          PalindromicPrimeFinderHelper helper = new PalindromicPrimeFinderHelper();
          Finder finder = new Finder(cb_NumberSystem.SelectedValue.ToString(), lowerRange,
            upperRange, helper);
          var outPutList = finder.GetPalindromicPrime();

          var stringsArray = outPutList.Select(i => i.ToString()).ToArray();
          var values = string.Join(",", stringsArray);

          rtb_Output.Text = values;
        }
      }
      else
        MessageBox.Show("The range fields From and To must have a integer value");
    }

    private void form_Finder_Load(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      int fromValue = 0;
      try
      {
        if (tb_FromValue.Text != "")
          fromValue = Convert.ToInt32(tb_FromValue.Text);
      }
      catch (Exception exception)
      {
        MessageBox.Show("Please enter a valid integer value.");
      }

      if (fromValue < 0)
      {
        MessageBox.Show("The value should be greater than 0");
      }

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
      int toValue = 0;
      try
      {
        if (tb_ToValue.Text != "")
          toValue = Convert.ToInt32(tb_ToValue.Text);
      }
      catch (Exception exception)
      {
        MessageBox.Show("Please enter a valid integer value.");
      }

      if (toValue < 0)
      {
        MessageBox.Show("The value should be greater than 0.");
      }
    }
  }
}
