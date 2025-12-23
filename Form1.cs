using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using OgrenciNotFormUygulamasi.Models;
using System.Text.Json;


namespace OgrenciNotFormUygulamasi
{
    public partial class Form1 : Form
    {


        string filePath = "students.json";

        private void label3_Click(object sender, EventArgs e)
        {
            // Boş – sadece hatayı çözmek için
        }

        // Öğrenci listesi (COLLECTION)
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            LoadFromJson();
            RefreshGrid();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }


        // -------------------------------
        // ÖĞRENCİ EKLE + NOT EKLE
        // -------------------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                string.IsNullOrWhiteSpace(txtScore.Text))
            {
                MessageBox.Show("Lütfen öğrenci adı ve not giriniz");
                return;
            }

            int score;
            if (!int.TryParse(txtScore.Text, out score) || score < 0 || score > 100)
            {
                MessageBox.Show("Not 0 ile 100 arasında olmalıdır");
                return;
            }

            Student newStudent = new Student
            {
                Name = txtStudentName.Text,
                Score = score
            };

            students.Add(newStudent);   // 👉 LİSTEYE EKLE
            RefreshGrid();              // 👉 TABLOYU GÜNCELLE

            txtStudentName.Clear();
            txtScore.Clear();
        }


        // -------------------------------
        // ÖĞRENCİ SİL
        // -------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            Student student = students.FirstOrDefault(s => s.Name == name);

            if (student != null)
            {
                students.Remove(student);
                SaveToJson();
                RefreshGrid();
            }
        }

        // -------------------------------
        // DATAGRIDVIEW GÜNCELLEME (LINQ)
        // -------------------------------
        void RefreshGrid()
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = students
                .OrderByDescending(s => s.Average)
                .Select(s => new
                {
                    Öğrenci = s.Name,
                    Ortalama = s.Average,
                    Durum = s.Status
                })
                .ToList();
        }

        // -------------------------------
        // JSON'A KAYDETME (FILE)
        // -------------------------------
        void SaveToJson()
        {
            string json = JsonSerializer.Serialize(students, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText("students.json", json);
        }

        // -------------------------------
        // JSON'DAN OKUMA
        // -------------------------------
        void LoadFromJson()
        {
            if (!File.Exists("students.json")) return;

            string json = File.ReadAllText("students.json");
            students = JsonSerializer.Deserialize<List<Student>>(json);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        }

    }




