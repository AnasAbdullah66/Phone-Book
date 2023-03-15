using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PhoneBook.Contact;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace PhoneBook
{
    /// <summary>
    /// Interaction logic for ContactDetails.xaml
    /// </summary>
    public partial class ContactDetails : Window
    {
        public string filename = @"Contact.json";
        public FileInfo TempImageFile { get; set; }
        public BitmapImage DefaultImage => new BitmapImage(new Uri(GetImagePath() + "default.png"));

        public ContactDetails()
        {
            InitializeComponent();

            string[] gender = new string[] { "Male", "Female" };
            this.cmbGender.ItemsSource = gender;

            string[] relation = new string[] { "Parents", "Brother","Sister","Cousin", "Coleigue","Friend" };
            this.cmbRelation.ItemsSource = relation;

            var path = Path.GetDirectoryName(GetImagePath());
            if (!File.Exists(filename))
            {
                File.CreateText(filename).Close();
            }
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            FormPic.Source = DefaultImage;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            ContactInfo ci = new ContactInfo()
            {
                Name = txtName.Text,
                ContactNumber = int.Parse(txtContact.Text),
                Gender = cmbGender.SelectedItem.ToString(),
                Email=txtEmail.Text,
                DateOfBirth= (DateTime)datePicker.SelectedDate,
                Relationship=cmbRelation.SelectedItem.ToString(),
                Address=txtAddress.Text,
                Picture= (TempImageFile != null) ? $"{int.Parse(txtContact.Text) + TempImageFile.Extension}" : "default.png",
            };
            string filedata = File.ReadAllText(filename);
            if (IsValidJson(filedata))
            {
                var data = JObject.Parse(filedata);
                var contactJson = data.GetValue("Contact").ToString();
                var contactList = JsonConvert.DeserializeObject<List<ContactInfo>>(contactJson);
                contactList.Add(ci);
                JArray contactArray = JArray.FromObject(contactList);
                data["Contact"] = contactArray;
                var newJsonResult = JsonConvert.SerializeObject(data, Formatting.Indented);

                if (TempImageFile != null)
                {
                    TempImageFile.CopyTo(GetImagePath() + ci.Picture);
                    TempImageFile = null;
                    FormPic.Source = DefaultImage;
                }
                File.WriteAllText(filename, newJsonResult);
            }
            if (!IsValidJson(filedata))
            {
                var con = new { Contact = new ContactInfo[] { ci } };  //create json format with parent[Employees]
                string newJsonResult = JsonConvert.SerializeObject(con, Formatting.Indented);   //serialize json format
                if (TempImageFile != null)
                {
                    TempImageFile.CopyTo(GetImagePath() + ci.Picture);
                    TempImageFile = null;
                    FormPic.Source = DefaultImage;
                }
                File.WriteAllText(filename, newJsonResult);
            }
            AllClear();
        }

        private bool IsValidJson(string data) 
        {

            try
            {
                var temp = JObject.Parse(data); 
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public string GetImagePath()
        {
            var currentAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            string assemblyDirectory = Path.GetDirectoryName(currentAssembly.Location);  
            string ImagePath = Path.GetFullPath(Path.Combine(assemblyDirectory, @"..\..\Img\"));

            return ImagePath;
        }

        private void btnUploadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png;";
            fd.Title = "Select an Image";
            if (fd.ShowDialog().Value == true)
            {
                FormPic.Source = new BitmapImage(new Uri(fd.FileName));
                TempImageFile = new FileInfo(fd.FileName);
            }
        }
        public void AllClear()
        {
            txtName.Clear();
            txtContact.Clear();
            cmbGender.SelectedIndex = -1;
            txtEmail.Clear();
            cmbRelation.SelectedIndex = -1;
            txtAddress.Clear();
            datePicker.SelectedDate =null;
            FormPic.Source = default;

        }
    }
}
