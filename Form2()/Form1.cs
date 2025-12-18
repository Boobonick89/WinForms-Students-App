using System.ComponentModel;
using System.Text.Json;

namespace Form2__
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Student> _students = new BindingList<Student>();
        private readonly BindingSource _bs = new BindingSource();

        private readonly string _filePath = Path.Combine(Application.StartupPath, "students.json");


        public Form1()
        {
            InitializeComponent();
            _bs.DataSource = _students;
            lstStudents.DataSource = _bs;
            this.Load += Form1_Load;
            cmbSearch.Items.AddRange(new object[]
            {
                "Имя",
                "Группа",
                "Возраст"
            });

            cmbSearch.SelectedIndex = 0;

            cmbSearch.SelectedIndexChanged += (_, __) =>
            {
                txtSearch.Clear();
                _bs.DataSource = _students;
            };
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            LoadStudentsFromFile();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using var form2 = new Form2();

            if (form2.ShowDialog(this) == DialogResult.OK && form2.NewStudent != null)
            {
                _students.Add(form2.NewStudent);
                SaveStudentsToFile();
                ApplySearch();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveStudentsToFile();
            MessageBox.Show("Список студентов сохранен");
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem is not Student selected)
            {
                MessageBox.Show("Выберите студента для удаления");
                return;
            }

            var result = MessageBox.Show($"Удалить {selected.Name} {selected.Group} ?", "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _students.Remove(selected);
                SaveStudentsToFile();
                ApplySearch();
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ApplySearch();
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetSearch();
        }
        private void LoadStudentsFromFile()
        {
            try
            {
                if (!File.Exists(_filePath)) return;

                string json = File.ReadAllText(_filePath);

                var loaded = JsonSerializer.Deserialize<BindingList<Student>>(json);

                if (loaded is null) return;

                _students.Clear();

                foreach (var student in loaded)
                {
                    _students.Add(student);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке" + ex.Message);
            }
        }

        private void SaveStudentsToFile()
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string json = JsonSerializer.Serialize(_students, options);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении" + ex.Message);
            }
        }

        private void ApplySearch()
        {
            string value = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(value))
            {
                _bs.DataSource = _students;
                return;
            }

            if (cmbSearch.SelectedItem is not string mode)
            {
                _bs.DataSource = _students;
                return;
            }

            IEnumerable<Student> result = _students;

            switch (mode)
            {
                case "Имя":
                    result = _students.Where(s => s.Name.Contains(value, StringComparison.OrdinalIgnoreCase)); break;

                case "Группа":
                    result = _students.Where(s => s.Group.Contains(value, StringComparison.OrdinalIgnoreCase)); break;

                case "Возраст":
                    if (int.TryParse(value, out int age))
                    {
                        result = _students.Where(s => s.Age == age);
                    }
                    else
                    {
                        result = Enumerable.Empty<Student>();
                    }
                    break;
            }

            _bs.DataSource = result.ToList();
        }

        private void ResetSearch()
        {
            txtSearch.Clear();
            cmbSearch.SelectedIndex = 0;
            _bs.DataSource = _students;
        }
    }
}

        



