using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task182.Model;
using Task182.Repository;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Task182
{
    public partial class Converter : Form
    {
        ValCurs data = CentralBankAPI.getData();

        public Converter()
        {
            InitializeComponent();

            cm_from.DataSource =  data.Valute.ToList();
            cm_from.DisplayMember = "FullName";
            cm_from.ValueMember = "ID";

            cm_into.DataSource = data.Valute.ToList();
            cm_into.DisplayMember = "FullName";
            cm_into.ValueMember = "ID";
        }


        private void Btn_convert_Click(object sender, EventArgs e)
        {
            var from = (from i in data.Valute where i.ID == cm_from.SelectedValue.ToString() select i).FirstOrDefault();
            var into = (from i in data.Valute where i.ID == cm_into.SelectedValue.ToString() select i).FirstOrDefault();

            var result = Math.Round(nm_summ.Value/ from.Nominal * decimal.Parse(from.Value)/ decimal.Parse(into.Value) * into.Nominal,2);

            lbl_result.Text = result.ToString();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
