using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Autogarage_Database
//public string LocationPath = @"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\locations.txt";
{

    public partial class Form1 : Form
    {

        List<string> car = new List<string>();
        public Form1()
        {
            InitializeComponent();
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            carPreset_box.SelectedText = "--SELECT--";
            LocationSelector.SelectedText = "--SELECT--";
            CarSelector.SelectedText = "--SELECT--";
            ExistingLocationsBox.SelectedText = "--SELECT--";
            InitLocList();
            foreach (string location in locations.loc)
            {
                if (string.IsNullOrEmpty(location)) continue;
                else
                {
                    LocationsBox.Items.Add(location);
                    ExistingLocationsBox.Items.Add(location);
                }

            }


            List<Cars> editCars = new List<Cars>();
            using (StreamReader inputfile = new StreamReader(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\cars.txt"))
            {
                var lineCount = File.ReadLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\cars.txt").Count();

                for (int i = 1; i < lineCount + 1; i++)
                {
                    if (i % 5 == 0)
                    {
                        int a = i - 1;

                        string carNameLine = File.ReadLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\cars.txt").Skip(a - 4).Take(1).First();
                        string carDoorInt = File.ReadLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\cars.txt").Skip(a - 2).Take(1).First().ToString();
                        string carColorVariant = File.ReadLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\cars.txt").Skip(a - 3).Take(1).First();
                        string carPriceInt = File.ReadLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\cars.txt").Skip(a - 1).Take(1).First().ToString();
                        editCars.Add(new Cars() { CarName = carNameLine, CarColor = carColorVariant, CarDoors = carDoorInt, CarPrice = carPriceInt });



                        // check if location matches with selected location ==> When it does ==> Add to list
                    }

                }
                carPreset_box.DataSource = editCars;
                carPreset_box.DisplayMember = "CarName";
            }
        }
        public class locations
        {
            public static List<string> loc = new List<string>();
        }
        public void InitLocList()
        {
            //Purge white lines
            File.WriteAllLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\locations.txt", File.ReadAllLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\locations.txt").Where(l => !string.IsNullOrWhiteSpace(l)));


            locations.loc.Clear();
            using (StreamReader reader = new StreamReader(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\locations.txt"))
            {

                var line = reader.ReadLine();

                while (line != null)   //While line with text, add that line to list
                {

                    locations.loc.Add(line);
                    line = reader.ReadLine();
                }
                reader.Close();
            }
            //foreach (string line in File.ReadLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\locations.txt"))
            //{
            //     loc.Add(line);
            //    counter++;
            //}
            LocationSelector.DataSource = locations.loc;
            LocationSelector.DisplayMember = "LocationName";
        }

        private void LocationSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Cars> cars = new List<Cars>();
            using (StreamReader inputfile = new StreamReader(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\cars.txt"))
            {
                var lineCount = File.ReadLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\cars.txt").Count();

                for (int i = 1; i < lineCount + 1; i++)
                {
                    if (i % 5 == 0)
                    {
                        int a = i - 1;
                        string locationLine = File.ReadLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\cars.txt").Skip(a).Take(1).First();
                        //DebugLabel.Text = locationLine; //test line
                        string SelectedLocation = LocationSelector.SelectedItem.ToString();
                        if (locationLine.Contains(SelectedLocation) == true)
                        {
                            string carNameLine = File.ReadLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\cars.txt").Skip(a - 4).Take(1).First();
                            string carDoorInt = File.ReadLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\cars.txt").Skip(a - 2).Take(1).First().ToString();
                            string carColorVariant = File.ReadLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\cars.txt").Skip(a - 3).Take(1).First();
                            string carPriceInt = File.ReadLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\cars.txt").Skip(a - 1).Take(1).First().ToString();
                            cars.Add(new Cars() { CarName = carNameLine, CarColor = carColorVariant, CarDoors = carDoorInt, CarPrice = carPriceInt });
                        }


                        // check if location matches with selected location ==> When it does ==> Add to list
                    }

                }
            }

            //if (LocationSelector.Text == "Middelburg")
            //{
            //    cars.Add(new Cars() { CarName = "Tesla Model S" , CarColor = "Wit", CarDoors = 5, CarPrice = 75000});
            //    cars.Add(new Cars() { CarName = "Tesla Model Y", CarColor = "Zwart", CarDoors = 5, CarPrice = 60000});
            //    cars.Add(new Cars() { CarName = "Tesla Model 3", CarColor = "Blauw", CarDoors = 5, CarPrice = 40000});
            //    cars.Add(new Cars() { CarName = "Tesla Model X", CarColor = "Rood", CarDoors = 5, CarPrice = 90000});


            //}
            //else if (LocationSelector.Text == "Goes")
            //{
            //    cars.Add(new Cars() { CarName = "Tesla Model S", CarColor = "Wit", CarDoors = 5, CarPrice = 80000 });
            //    cars.Add(new Cars() { CarName = "Tesla Model Y", CarColor = "Zwart", CarDoors = 5, CarPrice = 65000 });
            //    cars.Add(new Cars() { CarName = "Tesla Model 3", CarColor = "Blauw", CarDoors = 5, CarPrice = 45000 });
            //    cars.Add(new Cars() { CarName = "Tesla Model X", CarColor = "Rood", CarDoors = 5, CarPrice = 95000 });

            //}
            //else if (LocationSelector.Text == "Terneuzen")
            //{
            //    cars.Add(new Cars() { CarName = "Tesla Model S", CarColor = "Wit", CarDoors = 5, CarPrice = 70000 });
            //    cars.Add(new Cars() { CarName = "Tesla Model Y", CarColor = "Zwart", CarDoors = 5, CarPrice = 55000 });
            //    cars.Add(new Cars() { CarName = "Tesla Model 3", CarColor = "Blauw", CarDoors = 5, CarPrice = 35000 });
            //    cars.Add(new Cars() { CarName = "Tesla Model X", CarColor = "Rood", CarDoors = 5, CarPrice = 85000 });
            //}
            CarSelector.DataSource = cars;
            CarSelector.DisplayMember = "CarName";

        }

        private void CarSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cars car1 = CarSelector.SelectedItem as Cars;
            SelectedCarLabel.Text = Convert.ToString(car1.CarName);
            SelectedCarDoorsLabel.Text = Convert.ToString(car1.CarDoors);
            SelectedCarColorLabel.Text = Convert.ToString(car1.CarColor);
            SelectedCarPriceLabel.Text = Convert.ToString(car1.CarPrice);
            string imageLoader = car1.CarName;
            string imagePath = "C:\\Users\\eikel\\source\\repos\\Autogarage-Database\\Autogarage-Database\\data\\" + imageLoader + ".jpg";
            CarPictureBox.Image = Image.FromFile(imagePath);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void UploadPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;) | *.jpg;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Text = open.FileName;
                ModifyPictureBox.Image = new Bitmap(open.FileName);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            string LocationNewText = NewLocationBox.Text.ToString();
            string locationFile = @"C:\\Users\\eikel\\source\\repos\\Autogarage-Database\\Autogarage-Database\\data\\locations.txt";
            using (StreamWriter sw = File.AppendText(locationFile))
            {
                sw.WriteLine(LocationNewText);
            }
            locations.loc.Clear();
            using (StreamReader reader = new StreamReader(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\locations.txt"))
            {
                var line = reader.ReadLine();

                if (string.IsNullOrEmpty(line))
                {
                    return;
                }
                else
                {
                    while (line != null)
                    {

                        locations.loc.Add(line);
                        line = reader.ReadLine();
                    }
                    reader.Close();
                    Application.Restart();
                }

            }
            //foreach (string line in File.ReadLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\locations.txt"))
            //{
            //     loc.Add(line);
            //    counter++;
            //}
            LocationSelector.DataSource = locations.loc;
            LocationSelector.DisplayMember = "LocationName";


        }

        private void DeleteLocationButton_Click(object sender, EventArgs e)
        {
            var linesMod = File.ReadAllLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\locations.txt");
            string itemDelete = ExistingLocationsBox.SelectedItem.ToString();
            var newLines = linesMod.Select(line => Regex.Replace(line, itemDelete, string.Empty, RegexOptions.IgnoreCase));
            File.WriteAllLines(@"C:\Users\eikel\source\repos\Autogarage-Database\Autogarage-Database\data\locations.txt", newLines);
            Application.Restart();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCarName = carPreset_box.GetItemText(this.carPreset_box.SelectedItem).ToString();
            //DebugLabel.Text = selectedCarName;
            BrandType_UpdateBox.Text = selectedCarName;

            
            //ColorBox;
            //DoorBox;
            //PriceBox;
            //LocationsBox;

        }
        }

    }

