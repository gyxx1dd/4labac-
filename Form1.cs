using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3labac_
{
    public partial class Form1 : Form
    {
        private Wolf wolf;

        public Form1()
        {
            InitializeComponent();
            wolf = new Wolf(30, 3, 50, "Grey Wolf", "Forests of North America");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Wolf Information:\n\n" +
                            $"Weight: {wolf.Weight} kg\n" +
                            $"Age: {wolf.Age} years\n" +
                            $"Daily Maintenance Cost: {wolf.DailyMaintenanceCost}$\n" +
                            $"Breed: {wolf.Breed}\n" +
                            $"Natural Habitat: {wolf.NaturalHabitat}",
                            "Wolf Info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
