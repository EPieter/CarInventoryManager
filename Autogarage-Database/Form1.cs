using System.Text.RegularExpressions;

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

            foreach (string location in locations.loc) // adds existing locations in locations.txt to list
            {
                if (string.IsNullOrEmpty(location)) continue;
                else
                {
                    LocationsBox.Items.Add(location);
                    ExistingLocationsBox.Items.Add(location);
                }

            }


            List<Cars> editCars = new List<Cars>();
            using (StreamReader inputfile = new StreamReader(carPath()))
            {
                var lineCount = File.ReadLines(carPath()).Count();

                for (int i = 1; i < lineCount + 1; i++)
                {
                    if (i % 5 == 0)
                    {
                        int a = i - 1;

                        string carNameLine = File.ReadLines(carPath()).Skip(a - 4).Take(1).First();
                        string carDoorInt = File.ReadLines(carPath()).Skip(a - 2).Take(1).First().ToString();
                        string carColorVariant = File.ReadLines(carPath()).Skip(a - 3).Take(1).First();
                        string carPriceInt = File.ReadLines(carPath()).Skip(a - 1).Take(1).First().ToString();
                        editCars.Add(new Cars() { CarName = carNameLine, CarColor = carColorVariant, CarDoors = carDoorInt, CarPrice = carPriceInt });

                        //populates car list based on selected location

                    }
                    
                }
                carPreset_box.DataSource = editCars;
                carPreset_box.DisplayMember = "CarName";
            }
        }

        string locationPath()  // relative location.txt path
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\Data\locations.txt");
            string sFilePath = Path.GetFullPath(sFile);
            return sFilePath;
        }

        string carPath() // relative cars.txt path
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\Data\cars.txt");
            string sFilePath = Path.GetFullPath(sFile);
            return sFilePath;
        }
        public class locations  // global list of locations
        {
            public static List<string> loc = new List<string>();
        }
        public void InitLocList() // populates locations combobox
        {
            //Purge white lines
            File.WriteAllLines(locationPath(), File.ReadAllLines(locationPath()).Where(l => !string.IsNullOrWhiteSpace(l)));


            locations.loc.Clear();
            using (StreamReader reader = new StreamReader(locationPath()))
            {

                var line = reader.ReadLine();

                while (line != null)   //While there is line with text, add that line to list
                {

                    locations.loc.Add(line);
                    line = reader.ReadLine();
                }
                reader.Close();
            }
            
            LocationSelector.DataSource = locations.loc;
            LocationSelector.DisplayMember = "LocationName";
        }

        private void LocationSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Cars> cars = new List<Cars>();
            using (StreamReader inputfile = new StreamReader(carPath()))
            {
                var lineCount = File.ReadLines(carPath()).Count();

                for (int i = 1; i < lineCount + 1; i++)
                {
                    if (i % 5 == 0)  // grabs lines with location data
                    {
                        int a = i - 1;
                        string locationLine = File.ReadLines(carPath()).Skip(a).Take(1).First();
                        //DebugLabel.Text = locationLine; //test line
                        string SelectedLocation = LocationSelector.SelectedItem.ToString();
                        if (locationLine.Contains(SelectedLocation) == true) // reads lines relevant and relative to location data
                        {
                            string carNameLine = File.ReadLines(carPath()).Skip(a - 4).Take(1).First();
                            string carDoorInt = File.ReadLines(carPath()).Skip(a - 2).Take(1).First().ToString();
                            string carColorVariant = File.ReadLines(carPath()).Skip(a - 3).Take(1).First();
                            string carPriceInt = File.ReadLines(carPath()).Skip(a - 1).Take(1).First().ToString();
                            cars.Add(new Cars() { CarName = carNameLine, CarColor = carColorVariant, CarDoors = carDoorInt, CarPrice = carPriceInt });
                        }


                        // check if location matches with selected location ==> When it does ==> Add to list
                    }

                }
            }

            
            CarSelector.DataSource = cars;
            CarSelector.DisplayMember = "CarName"; // Adds cars to combobox

        }

        private void CarSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cars car1 = CarSelector.SelectedItem as Cars;
            SelectedCarLabel.Text = Convert.ToString(car1.CarName);
            SelectedCarDoorsLabel.Text = Convert.ToString(car1.CarDoors);  // Populates data labels of selected car
            SelectedCarColorLabel.Text = Convert.ToString(car1.CarColor);
            SelectedCarPriceLabel.Text = Convert.ToString(car1.CarPrice);
            string imageLoader = car1.CarName;
            string DefaultCars = car1.CarName;
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\Data\");
            string sFilePath = Path.GetFullPath(sFile);
            string imagePath = sFilePath + imageLoader + ".jpg";

            switch (DefaultCars)
            {
                case "Tesla Model S":
                    CarPictureBox.Image = Image.FromFile(@"..\..\..\data\Tesla Model S.jpg");  // dont look at this pls!
                    break;
                case "Tesla Model X":
                    CarPictureBox.Image = Image.FromFile(@"..\..\..\data\Tesla Model X.jpg");
                    break;
                case "Tesla Model 3":
                    CarPictureBox.Image = Image.FromFile(@"..\..\..\data\Tesla Model 3.jpg");
                    break;
                case "Tesla Model Y":
                    CarPictureBox.Image = Image.FromFile(@"..\..\..\data\Tesla Model Y.jpg");
                    break;
                default:
                    CarPictureBox.Image = null;
                    break;

            }
            

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
                ModifyPictureBox.Image = new Bitmap(open.FileName); //code for uploading and previewing a picture

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            BrandType_UpdateBox.Text = String.Empty;
            ColorBox.Text = String.Empty;
            DoorBox.Text = String.Empty;
            PriceBox.Text = String.Empty;
            for (int i = 0; i < LocationsBox.Items.Count; i++)  // Clears textboxes and checkboxes if populated
            {
                LocationsBox.SetItemChecked(i, false);
            }
        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            string LocationNewText = NewLocationBox.Text.ToString();

            using (StreamWriter sw = File.AppendText(locationPath()))
            {
                sw.WriteLine(LocationNewText);
            }
            locations.loc.Clear();
            using (StreamReader reader = new StreamReader(locationPath()))
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
                        line = reader.ReadLine(); // Add new locations to locations list 
                    }
                    reader.Close();
                    Application.Restart(); // Restart to refresh all comboboxes
                }

            }

            LocationSelector.DataSource = locations.loc;
            LocationSelector.DisplayMember = "LocationName";


        }

        private void DeleteLocationButton_Click(object sender, EventArgs e)
        {
            var linesMod = File.ReadAllLines(locationPath());
            string itemDelete = ExistingLocationsBox.SelectedItem.ToString();
            var newLines = linesMod.Select(line => Regex.Replace(line, itemDelete, string.Empty, RegexOptions.IgnoreCase));  // removes line of selected location
            File.WriteAllLines(locationPath(), newLines);
            Application.Restart();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCarName = carPreset_box.GetItemText(this.carPreset_box.SelectedItem).ToString();
            // Populates textboxes and checklist with information of car (from preset)
            int counter = 0;
            foreach (string line in System.IO.File.ReadLines(carPath()))
            {

                if (line.Contains(selectedCarName) == true)
                {
                    //string carDoorInt = File.ReadLines(carPath()).Skip(a - 2).Take(1).First().ToString();
                    ColorBox.Text = File.ReadLines(carPath()).Skip(counter + 1).Take(1).First();
                    DoorBox.Text = File.ReadLines(carPath()).Skip(counter + 2).Take(1).First();
                    PriceBox.Text = File.ReadLines(carPath()).Skip(counter + 3).Take(1).First();
                    string locationLine = File.ReadLines(carPath()).Skip(counter + 4).Take(1).First(); 
                    BrandType_UpdateBox.Text = selectedCarName;
                    int counter1 = 0;
                    for (int i = 0; i < LocationsBox.Items.Count; i++)
                    {
                        LocationsBox.SetItemChecked(i, false);
                    }
                    foreach (string location in System.IO.File.ReadLines(locationPath()))
                    {
                        if (locationLine.Contains(location) == true)
                        {

                            LocationsBox.SetItemChecked(counter1, true);

                        }
                        counter1++;
                    }
                    break;
                }
                counter++;
            }

            

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {

            string newBrand = BrandType_UpdateBox.Text;
            string newColor = ColorBox.Text;
            string newDoors = DoorBox.Text;
            string newPrice = PriceBox.Text;
            string newCarLocations = "";
            int checkCounter = 0;
            for (int i = 0; i < LocationsBox.Items.Count; i++)
            {
                if (LocationsBox.GetItemCheckState(checkCounter) == CheckState.Checked)
                {
                    newCarLocations = newCarLocations + LocationsBox.Items[checkCounter];  // create string from checked elements
                    //DebugLabel.Text = newCarLocations;
                }

                checkCounter++;
            }
          

            File.AppendAllText(carPath(), newBrand + Environment.NewLine);
            File.AppendAllText(carPath(), newColor + Environment.NewLine);
            File.AppendAllText(carPath(), newDoors + Environment.NewLine);
            File.AppendAllText(carPath(), newPrice + Environment.NewLine);
            File.AppendAllText(carPath(), newCarLocations + Environment.NewLine);
            // append all entered data to end of text file
            Application.Restart();

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            int matchedLine;
            int carLineCount = File.ReadAllLines(carPath()).Length;
            string newBrand = BrandType_UpdateBox.Text;
            for (int i = 0; i < carLineCount; i++)
            {
                string line = File.ReadLines(carPath()).Skip(i).Take(1).First();
                if (line == newBrand)           // Searches for string with matching name to entered brand. If found, it deletes the line 5 times so all data is removed
                {
                    matchedLine = i;
                    List<string> carList = File.ReadAllLines(carPath()).ToList();
                    string firstItem = carList[0];
                    carList.RemoveAt(matchedLine);
                    carList.RemoveAt(matchedLine);
                    carList.RemoveAt(matchedLine);
                    carList.RemoveAt(matchedLine);
                    carList.RemoveAt(matchedLine);
                    File.WriteAllLines(carPath(), carList.ToArray());
                    Application.Restart();
                }
            }
            Application.Restart();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            StreamWriter car = File.CreateText(carPath());  // Removes everything in database
            car.Flush();
            car.Close();
            StreamWriter loc = File.CreateText(locationPath());
            loc.Flush();
            loc.Close();
            Application.Restart();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();  // Restart application
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = "How to reset database to default";
            string message = "To reset database copy content from ./data/cars-default.txt to ./data/cars.txt. Do the same with locations.txt";
            MessageBox.Show(message, title);
        }

        private void AvgPrice_Click(object sender, EventArgs e)
        {

        }
    }
}



