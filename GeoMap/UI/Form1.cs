using GeoMap.Enums;
using GeoMap.Models;
using GeoMap.Repository.IReposiotry;
using GeoMap.Services;
using GeoMap.Utility.Validators;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoMap
{
    public partial class Form1 : Form
    {
        private readonly IFeatureService _service;
        private int selectedId = -1;

        public Form1(IFeatureService service)
        {
            InitializeComponent();
            _service = service;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                TypeBox.DataSource = Enum.GetValues(typeof(GEOType));
                var data = await _service.GetAllAsync();
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells["Id"].Value);

                NameBox.Text = row.Cells["Name"].Value.ToString();
                DesciptionBox.Text = row.Cells["Description"].Value?.ToString();
                ColorBox.Text = row.Cells["Color"].Value?.ToString();
                GeometryBox.Text = row.Cells["Geometry"].Value?.ToString();

                TypeBox.SelectedItem =(GEOType)Enum.Parse(typeof(GEOType), row.Cells["Type"].Value.ToString());
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            NameBox.Text = "";
            DesciptionBox.Text = "";
            ColorBox.Text = "";
            TypeBox.SelectedItem = GEOType.Point;
            GeometryBox.Text = "";
        }

        private void ColorBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var feature = GetFeatureFromForm();

                await _service.AddAsync(feature);

                MessageBox.Show("Saved Successfully");

                await LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    
        private async void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedId == -1)
                {
                    MessageBox.Show("Select record first");
                    return;
                }

                var feature = GetFeatureFromForm();
                await _service.UpdateAsync(feature);

               

                MessageBox.Show("Updated Successfully");

                await LoadData();

                ClearForm();
                selectedId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

         private async void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedId == -1)
                {
                    MessageBox.Show("Please select a record first");
                    return;
                }

                var confirm = MessageBox.Show(
                    "Are you sure you want to delete?",
                    "Confirm",
                    MessageBoxButtons.YesNo
                );

                if (confirm != DialogResult.Yes)
                    return;

                await _service.DeleteAsync(selectedId);

                MessageBox.Show("Deleted Successfully");

                dataGridView1.DataSource = await _service.GetAllAsync();

                ClearForm();
                selectedId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GeometryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DesciptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private Feature GetFeatureFromForm()
        {
            return new Feature
            {
                Id = selectedId,
                Name = NameBox.Text.Trim(),
                Description = DesciptionBox.Text.Trim(),
                Type = (GEOType)TypeBox.SelectedItem,
                Color = ColorBox.Text.Trim(),
                Geometry = GeometryBox.Text.Trim()
            };
        }
        private async Task LoadData()
        {
            dataGridView1.DataSource = await _service.GetAllAsync();
        }


    }
}
