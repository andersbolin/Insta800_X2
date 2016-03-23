using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// Created by Anders Bolin AB2633 datum: 2013-06-02 email: anders@bolin.nu 
/// Eget Project i Programmering i .NET: Fortsättningskurs
/// </summary>

namespace InstaX2000
{
    public partial class Form1 : Form
    {
        
        //Variable Declarations
        public int pickedVagn;
        /// <summary>
        /// Default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            initGUI();
        }
        /// <summary>
        /// Initiates the GUI and sets the listeners to event's
        /// </summary>
        public void initGUI()
        {
            cmbStation.Items.AddRange(Enum.GetNames(typeof(InstaControlLibrary.Stations)));
            cmbPlats.Items.AddRange(Enum.GetNames(typeof(InstaControlLibrary.Plats)));
            lstVagn.Items.AddRange(Enum.GetNames(typeof(InstaControlLibrary.WagonType)));
            txtBoxDate.Text = DateTime.Today.ToString("d");
            InstaControlLibrary.Manager.TestResults += OnResultControl;
            InstaControlLibrary.Manager.ControlFinished += OnControlFinished;
            btnSkapaKontroll.Enabled = true;
        }
        /// <summary>
        /// Resets the GUI to blank
        /// </summary>
        public void resetGUI()
        {
            txtBoxTrainNumber.Text = "";
            cmbStation.SelectedItem = null;
            cmbPlats.SelectedItem = null;
            txtBoxPerson.Text = "";
            txtBoxDate.Text = DateTime.Today.ToString("d");
            lstVagn.Items.Clear();
            lstVagn.Items.AddRange(Enum.GetNames(typeof(InstaControlLibrary.WagonType)));
            InstaControlLibrary.Manager.resetGUI();
            btnSkapaKontroll.Enabled = true;
            rdbVagn1.Enabled = true;
            rdbVagn2.Enabled = true;
            rdbVagn3.Enabled = true;
            rdbVagn4.Enabled = true;
            rdbVagn5.Enabled = true;
        }  
        /// <summary>
        /// Sets the variables pickedVagn depening on wich radiobutton the user has checked
        /// </summary>
        /// <returns></returns>
        private int selectedVagn()
        {
            if (rdbVagn1.Checked)
            {
                pickedVagn = 1;
            }
            else if (rdbVagn2.Checked)
            {
                pickedVagn = 2;
            }
            else if (rdbVagn3.Checked)
            {
                pickedVagn = 3;
            }
            else if (rdbVagn4.Checked)
            {
                pickedVagn = 4;
            }
            else if (rdbVagn5.Checked)
            {
                pickedVagn = 5;
            }
            else
            {
                pickedVagn = -1;
            }
            return pickedVagn;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                lstVagn.Items.Clear();
                lstVagn.Items.AddRange(Enum.GetNames(typeof(InstaControlLibrary.WagonType)));  
            }
        }
        /// <summary>
        /// As user clicks create control this method decides what user has asked for 
        /// and presents it on screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            bool check = checkInput1();

            if (check)
            {
                string vagn = lstVagn.SelectedItem.ToString();
                switch (vagn)
                {
                    case "UA2":
                        createUA2Control();
                        break;
                    case "UB2":
                        createUB2Control();
                        break;
                    case "UB2X":
                        createUB2XControl();
                        break;
                    case "URB2":
                        createURB2Control();
                        break;
                }

                int nr = selectedVagn();
                if (nr == 1)
                {
                    rdbVagn1.Enabled = false;
                    rdbVagn1.Checked = false;
                }
                if (nr == 2)
                {
                    rdbVagn2.Enabled = false;
                    rdbVagn2.Checked = false;
                }
                if (nr == 3)
                {
                    rdbVagn3.Enabled = false;
                    rdbVagn3.Checked = false;
                }
                if (nr == 4)
                {
                    rdbVagn4.Enabled = false;
                    rdbVagn4.Checked = false;
                }
                if (nr == 5)
                {
                    rdbVagn5.Enabled = false;
                    rdbVagn5.Checked = false;
                }
            }

        }
        /// <summary>
        /// Creates a UBX2 control window with randow chair numbers to preform the control at.
        /// </summary>
        /// </summary>
        private void createUB2XControl()
        {
            String trainnr = txtBoxTrainNumber.Text;
            int wagonnumber = selectedVagn();
            Random random = new Random();
            int first = random.Next(1, 16);
            int second = random.Next(16, 30);
            int third = random.Next(30, 43);
            int fourth = random.Next(0, 3);
            int extra = random.Next(0, 2);
            UB2X top = new UB2X(first, second, third, fourth, wagonnumber, first, second, third, trainnr);
            top.Show();
        }
        /// <summary>
        /// Creates a URB2 control window with randow chair numbers to preform the control at.
        /// </summary>
        /// </summary>
        private void createURB2Control()
        {
            String trainnr = txtBoxTrainNumber.Text;
            int wagonnumber = selectedVagn();
            Random random = new Random();
            int first = random.Next(1, 10);
            int second = random.Next(10, 20);
            int third = random.Next(20, 28);
            int fourth = random.Next(0, 3);
            int resturant = random.Next(0, 3);
            URB2 bistro = new URB2(first, second, third, fourth, wagonnumber, first, second, third, trainnr);
            bistro.Show();
        }
        /// <summary>
        /// Creates a UB2 control window with randow chair numbers to preform the control at.
        /// </summary>
        /// </summary>
        private void createUB2Control()
        {
            String trainnr = txtBoxTrainNumber.Text;
            int wagonnumber = selectedVagn();
            Random random = new Random();
            int first = random.Next(1, 25);
            int second = random.Next(25, 49);
            int third = random.Next(49, 73);
            int fourth = random.Next(0, 3);
            UB2 nwindow = new UB2(first, second, third, fourth, wagonnumber, first, second, third, trainnr);
            nwindow.Show();
        }
        /// <summary>
        /// Creates a UA2 control window with randow chair numbers to preform the control at.
        /// </summary>
        private void createUA2Control()
        {
            String trainnr = txtBoxTrainNumber.Text;
            int wagonnumber = selectedVagn();
            Random random = new Random();
            int first = random.Next(1, 20);
            int second = random.Next(20, 40);
            int third = random.Next(40, 53);
            int fourth = random.Next(0, 3);
            UA2 nwindow = new UA2(first, second, third, fourth, wagonnumber, first, second, third, trainnr);
            nwindow.Show();
        }
        /// <summary>
        /// Updates the list in the main window.
        /// </summary>
        public void UpdateLists()
        {

            int items = InstaControlLibrary.Manager.getPostsInList();
            lstVagn.Items.Clear();
            lstBoxKontroller.Items.Clear();
            for (int x = 0; x < items; x++)
            {
                Object animal = InstaControlLibrary.Manager.GetMainList(x);
                string result = "";
                var animalObj = animal as InstaControlLibrary.ITrain;
                if (animalObj != null)
                {
                    result = animalObj.getWagonSpecificResults();
                }
                lstBoxKontroller.Items.Add(result);
            }

        }
        /// <summary>
        /// Updates the list wich wagons as the user saves the controll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnResultControl(object sender, InstaControlLibrary.TestResultArgs e)
        {
            UpdateLists();            
        }
        /// <summary>
        /// If the control is finshed the Skapa kontroll button is locked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnControlFinished(object sender, EventArgs e)
        {
            btnSkapaKontroll.Enabled = false;
        }
        /// <summary>
        /// Checks the user input and lets user know if it did not work properly and set focus to area 
        /// where there is an issue.
        /// </summary>
        /// <returns></returns>
        private bool checkInput1()
        {

            bool numbertest = UtilitiesLibrary.InputCheck.CheckTrainNumber(txtBoxTrainNumber.Text);
            if (!numbertest)
            {
                MessageBox.Show("Ett tågnummer måste sättas.");
                txtBoxTrainNumber.Focus();
                return false;
            }
            bool stationtest = UtilitiesLibrary.InputCheck.CheckStation(cmbStation.SelectedItem);
            if (!stationtest)
            {
                MessageBox.Show("En station måste väljas.");
                cmbStation.Focus();
                return false;
            }
            bool platstest = UtilitiesLibrary.InputCheck.CheckStation(cmbPlats.SelectedItem);
            if (!platstest)
            {
                MessageBox.Show("en plats måste väljas.");
                cmbPlats.Focus();
                return false;
            }
            bool person = UtilitiesLibrary.InputCheck.checkPerson(txtBoxPerson.Text);
            if (!person)
            {
                MessageBox.Show("Testet utförare måste sättas.");
                txtBoxPerson.Focus();
                return false;
            }
            bool vagnsnummer = UtilitiesLibrary.InputCheck.checkVagnsnummer(selectedVagn());
            if (!vagnsnummer)
            {
                MessageBox.Show("Vagnsnummret måste väljas.");                
                return false;
            }
            bool vagntyp = UtilitiesLibrary.InputCheck.checkVagnTyp(lstVagn.SelectedIndex);
            if (!vagntyp)
            {
                MessageBox.Show("Vagnstyp måste väljas.");
                lstVagn.Focus();
                return false;
            }
            return true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure \nyou want to Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Shows connected wagon depeding on wich wagon number in the trainset is picked as a 1class wagon 
        /// has to be in the end of the train(Design feature, they are pointy in one end as they are placed either in
        /// the end of the train or the front)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstaControlLibrary.Manager.lstClear();
            lstBoxKontroller.Items.Clear();
            resetGUI();
        }

        private void rdbVagn1_CheckedChanged(object sender, EventArgs e)
        {
            lstVagn.Items.Clear();
            lstVagn.Items.AddRange(Enum.GetNames(typeof(InstaControlLibrary.Vagn1)));
        }

        private void rdbVagn2_CheckedChanged(object sender, EventArgs e)
        {
            lstVagn.Items.Clear();
            lstVagn.Items.AddRange(Enum.GetNames(typeof(InstaControlLibrary.Vagn2)));
        }

        private void rdbVagn3_CheckedChanged(object sender, EventArgs e)
        {
            lstVagn.Items.Clear();
            lstVagn.Items.AddRange(Enum.GetNames(typeof(InstaControlLibrary.Vagn3)));
        }

        private void rdbVagn4_CheckedChanged(object sender, EventArgs e)
        {
            lstVagn.Items.Clear();
            lstVagn.Items.AddRange(Enum.GetNames(typeof(InstaControlLibrary.Vagn4)));
        }

        private void rdbVagn5_CheckedChanged(object sender, EventArgs e)
        {
            lstVagn.Items.Clear();
            lstVagn.Items.AddRange(Enum.GetNames(typeof(InstaControlLibrary.Vagn5)));
        }
        /// <summary>
        /// Saves the train object array into an binary dat file and stores it at user assigned place on the HDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String strFileName = "";

            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save Trainlist";
            save.Filter = ".dat Files (*.dat)|*.dat";

            if (save.ShowDialog() == DialogResult.OK)
            {
                strFileName = save.FileName;
            }

            if (strFileName == String.Empty)
            {
                return;
            }
            try
            {
                InstaControlLibrary.Manager.createserializefile(strFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ouccured: " + ex.Message);
            }
        }
        /// <summary>
        /// Opens a binary saved object array file from HDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String strFileName = "";
            OpenFileDialog result = new OpenFileDialog();
            result.Title = "Open TrainFile";
            result.Filter = ".dat Files (*.dat)|*.dat";

            if (result.ShowDialog() == DialogResult.OK) // Test result.
            {
                strFileName = result.FileName;
            }
            if (strFileName == String.Empty)
            {
                return;
            }
            try
            {
                InstaControlLibrary.Manager.loadseriallist(strFileName);                
                UpdateLists();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: " + ex.Message);
            }          
        }
        /// <summary>
        /// Saves all the train objects in the list to the DataBase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool test = true;
            try
            {
                InstaControlLibrary.Manager.creatTrainListDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ouccured: " + ex.Message);
                test = false;
            }
            finally
            {
                if (test)
                {
                    MessageBox.Show("The list has been stored in the database.");
                }
                else
                {
                    MessageBox.Show("The list has NOT been stored in the database.");
                }
            }
        }
        /// <summary>
        /// Loads the database into the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int objects = InstaControlLibrary.Manager.getPostsInList();
            if (objects != 0)
            {
                DialogResult result1 = MessageBox.Show("This will delete the train currently in\n" +
                "the list, Are you sure about this?",
                "Very Important Question",
                MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    InstaControlLibrary.Manager.lstClear();
                    try
                    {
                        InstaControlLibrary.Manager.readTrainDB();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error ouccured: " + ex.ToString());
                    }
                    finally
                    {                      
                        UpdateLists();
                    }
                }
            }
            else
            {
                try
                {
                    InstaControlLibrary.Manager.readTrainDB();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error ouccured: " + ex.ToString());
                }
                finally
                {
                    UpdateLists();
                }
            }
        }
    }
}
