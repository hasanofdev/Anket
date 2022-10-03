

using Newtonsoft.Json;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Anket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            const string PhonePattern = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            Regex phone_regex = new Regex(PhonePattern);
            if (FileNameInput.Text.Length > 0)
                if (SurnameInput.Text.Length > 0)
                    if (NameInput.Text.Length > 0)
                        if (FatherNameInput.Text.Length > 0)
                            if (CountryInput.Text.Length > 0)
                                if (CityInput.Text.Length > 0)
                                    if (phone_regex.IsMatch(PhoneInput.Text))
                                    {
                                        User user = new User(NameInput.Text, SurnameInput.Text, FatherNameInput.Text, CountryInput.Text, CityInput.Text, PhoneInput.Text, BirthDateInput.Value);
                                        if (ManRButton.Checked)
                                            user.Gender = true;
                                        else if (WomanRButton.Checked)
                                            user.Gender = false;

                                        JsonSerializerOptions op = new JsonSerializerOptions();
                                        op.WriteIndented = true;

                                        var jsonString = System.Text.Json.JsonSerializer.Serialize(user);
                                        File.WriteAllText($"{FileNameInput.Text}.json", jsonString);
                                        MessageBox.Show($"{FileNameInput.Text}.json changed!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else MessageBox.Show("Phone Incorrect!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                else MessageBox.Show("City Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else MessageBox.Show("Country Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else MessageBox.Show("Father Name Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else MessageBox.Show("Name Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else MessageBox.Show("Surname Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else MessageBox.Show("File Name Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var stringData = File.ReadAllText($"{FileNameInput.Text}.json");
                User user = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(stringData);
                NameInput.Text = user.Name;
                SurnameInput.Text = user.Surname;
                FatherNameInput.Text = user.Father;
                CountryInput.Text = user.Country;
                CityInput.Text = user.City;
                PhoneInput.Text = user.Phone;
                BirthDateInput.Value = user.BirthDate;
                if (user.Gender)
                    ManRButton.Checked = true;
                else
                    WomanRButton.Checked = true;

            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}