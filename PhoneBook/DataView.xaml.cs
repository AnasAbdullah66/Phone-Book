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
    /// Interaction logic for DataView.xaml
    /// </summary>
    public partial class DataView : Window
    {
        public string filename = @"Contact.json";
        public FileInfo TempImageFile { get; set; }
        public BitmapImage DefaultImage => new BitmapImage(new Uri(GetImagePath() + "default.png"));
        public DataView()
        {
            InitializeComponent();
        }
        
        public void ShowData()
        {
            var json = File.ReadAllText(filename);

            if (!IsValidJson(json))
            {
                return;
            }

            var jsonObj = JObject.Parse(json);
            var contactJson = jsonObj.GetValue("Contact").ToString();
            var contactList = JsonConvert.DeserializeObject<List<ContactInfo>>(contactJson);
            contactList = contactList.OrderBy(x => x.Name).ToList();

            foreach (var item in contactList)
            {
                item.ImageSrc = ImageInstance(new Uri(GetImagePath() + item.Picture));

            }
            listContact.ItemsSource = contactList;
            listContact.Items.Refresh();

            GC.Collect();               
            GC.WaitForPendingFinalizers();
        }
        public ImageSource ImageInstance(Uri path)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = path;
            bitmap.CacheOption = BitmapCacheOption.OnLoad;
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.DecodePixelWidth = 300;
            bitmap.EndInit();
            bitmap.Freeze();
            return bitmap;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //update button
            
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            //list box edit button
            ContactDetails cd = new ContactDetails();
            cd.Show();
            this.Hide();
            cd.Owner = this;
            Button b = sender as Button;
            ContactInfo information = b.CommandParameter as ContactInfo;
            cd.txtName.Text = information.Name;
            cd.txtContact.Text = information.ContactNumber.ToString();
            cd.cmbGender.Text = information.Gender;
            cd.txtEmail.Text = information.Email;
            cd.datePicker.Text = information.DateOfBirth.ToShortDateString();
            cd.cmbRelation.Text = information.Relationship;
            cd.txtAddress.Text = information.Address;
            cd.FormPic.Source = information.ImageSrc;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //List box delete click
            var jsonD = File.ReadAllText(filename);
            var jsonObj = JObject.Parse(jsonD);
            var contactJson = jsonObj.GetValue("Contact").ToString();
            var contactList = JsonConvert.DeserializeObject<List<ContactInfo>>(contactJson);

            Button b = sender as Button;
            ContactInfo contactbtn = b.CommandParameter as ContactInfo;
            string conName = contactbtn.Name;

            MessageBoxResult result = MessageBox.Show($"Are you want to delete - {conName}", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes) //if press 'Yes' on delete confirmation
            {
                contactList.Remove(contactList.Find(x => x.Name == conName));   //Remove the employee from the list
                JArray contactArray = JArray.FromObject(contactList);       //Convert List<Employee> to JArray
                jsonObj["Contact"] = contactArray;                    //Add JArray to 'Employees' JProperty
                var newJsonResult = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);

                FileInfo thisFile = new FileInfo(GetImagePath() + contactbtn.Picture);
                if (thisFile.Name != "default.png") //Delete image (Not default image)
                {
                    thisFile.Delete();
                }

                File.WriteAllText(filename, newJsonResult);

                MessageBox.Show("Data Deleted Successfully !!", "Delete", MessageBoxButton.OK, MessageBoxImage.Question);
                //ShowData();
                //AllClear();
            }
            else
            {
                return;
            }
        }
        
    }
}
