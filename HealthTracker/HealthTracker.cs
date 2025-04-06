using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        private ProfileManager profileManager;
        private Profile _currentProfile;
        public Form1()
        {
            InitializeComponent();
            profileManager = new ProfileManager("Profiles"); // Directory of profiles
            pnlNewProfile.Visible = false;
            pnlGoalManagement.Visible = false;
            pnlLogMetrics.Visible = false;
            lblSelectedProfileID.Visible = false;
            lblSelectedProfileName.Visible = false;
            lblSelectedProfileHeight.Visible = false;
            lblSelectedProfileDaysLeft.Visible = false;
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void healthMetricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentProfile == null)
            {
                MessageBox.Show("No profile is currently loaded. Please load a profile first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_currentProfile.TotalDays == 0)
            {
                MessageBox.Show("No goals are active. Please set goals first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblSelectedProfileDaysLeft.Text = (_currentProfile.TotalDays - _currentProfile.CurrentDay + 1).ToString() + " Days Left To Meet Goals.";
            lblHealthMetricDayCounter.Text = "Day: " + (_currentProfile.CurrentDay).ToString();
            pnlGoalManagement.Visible=false;
            pnlNewProfile.Visible=false;
            pnlLogMetrics.Visible=true;
        }

        private void newProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGoalManagement.Visible = false;
            pnlLogMetrics.Visible = false;
            pnlNewProfile.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnProfileSubmit_Click(object sender, EventArgs e)
        {
            string name = txtNewProfileName.Text;
            int height;

            // Validate the height input
            if (!int.TryParse(txtProfileHeight.Text, out height) || height <= 0)
            {
                MessageBox.Show("Please enter a valid height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new profile using the ProfileManager
            string newProfileId = profileManager.CreateProfile(name, height);

            // Notify the user
            MessageBox.Show($"Profile created successfully!\nID: {newProfileId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Hide the panel after creation
            pnlNewProfile.Visible = false;
        }

        private void btnCancelProfileCreation_Click(object sender, EventArgs e)
        {
            pnlNewProfile.Visible = false;
        }

        private void pnlNewProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void goalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentProfile == null)
            {
                MessageBox.Show("No profile is currently loaded. Please load a profile first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pnlNewProfile.Visible = false;
            pnlLogMetrics.Visible = false;
            pnlGoalManagement.Visible = true;
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentProfile == null)
            {
                MessageBox.Show("No profile is currently loaded. Please load a profile first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_currentProfile.TotalDays == 0)
            {
                MessageBox.Show("No goals are active. Please set goals first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_currentProfile.TotalDays - _currentProfile.CurrentDay >= 0)
            {
                MessageBox.Show("You haven't logged enough information, please finish.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generate the report
            var reportGenerator = new ReportGenerator(_currentProfile);
            string reportContent = reportGenerator.GenerateReport();

            // Display the report
            MessageBox.Show(reportContent, "Generated Report", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Save the report to a file
            string fileName = $"{_currentProfile.Name}_Report_{DateTime.Now:yyyyMMddHHmmss}.txt";
            string filePath = Path.Combine(profileManager.profilesDirectory, fileName);
            try
            {
                reportGenerator.SaveReportToFile(filePath, reportContent);
                MessageBox.Show($"Report saved to {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save the report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loadProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGoalManagement.Visible = false;
            pnlLogMetrics.Visible = false;
            pnlNewProfile.Visible = false;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = profileManager.profilesDirectory;
                openFileDialog.Filter = "JSON files (*.json)|*.json";
                openFileDialog.Title = "Select a Profile";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        string json = File.ReadAllText(filePath);
                        _currentProfile = JsonConvert.DeserializeObject<Profile>(json);

                        if (_currentProfile != null && !string.IsNullOrEmpty(_currentProfile.ID))
                        {
                            lblSelectedProfileID.Text = "ID: " + _currentProfile.ID;
                            lblSelectedProfileName.Text = "NAME: " + _currentProfile.Name;
                            lblSelectedProfileHeight.Text = "HEIGHT: " + _currentProfile.Height.ToString();
                            lblSelectedProfileID.Visible = true;
                            lblSelectedProfileName.Visible = true;
                            lblSelectedProfileHeight.Visible = true;
                            lblSelectedProfileNone.Visible = false;

                            lblSelectedProfileDaysLeft.Text = (_currentProfile.TotalDays - _currentProfile.CurrentDay + 1).ToString() + " Days Left To Meet Goals.";
                            lblHealthMetricDayCounter.Text = "Day: " + _currentProfile.CurrentDay.ToString();
                            lblSelectedProfileDaysLeft.Visible = false;
                            if (_currentProfile.TotalDays > 0)
                            {
                                lblSelectedProfileDaysLeft.Visible = true;
                                MessageBox.Show($"GOALS EXIST", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            MessageBox.Show($"Profile '{_currentProfile.Name}' loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("The selected profile file is invalid or incomplete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while loading the profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCloseGoalManagement_Click(object sender, EventArgs e)
        {
            pnlGoalManagement.Visible = false;
        }

        private void btnGoalSubmit_Click(object sender, EventArgs e)
        {
            if (_currentProfile == null)
            {
                MessageBox.Show("No profile is currently loaded. Please load a profile first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            // Validate and parse inputs
            if (!double.TryParse(txtCalorieGoal.Text, out double calorieGoal) || calorieGoal <= 0)
            {
                MessageBox.Show("Please enter a valid calorie goal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtWaterIntakeGoal.Text, out double waterIntakeGoal) || waterIntakeGoal <= 0)
            {
                MessageBox.Show("Please enter a valid water intake goal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtExerciseGoal.Text, out double exerciseGoal) || exerciseGoal <= 0)
            {
                MessageBox.Show("Please enter a valid exercise goal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtBodyWeightGoal.Text, out double bodyWeightGoal) || bodyWeightGoal <= 0)
            {
                MessageBox.Show("Please enter a valid body weight goal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtDaysGoal.Text, out int daysGoal) || bodyWeightGoal <= 0)
            {
                MessageBox.Show("Please enter a valid number of days.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the current profile
            _currentProfile.TargetCaloriesConsumed = calorieGoal;
            _currentProfile.TargetWaterIntake = waterIntakeGoal;
            _currentProfile.TargetTimeExercised = exerciseGoal;
            _currentProfile.TargetWeight = bodyWeightGoal;
            _currentProfile.TotalDays = daysGoal;
            _currentProfile.CurrentDay = 1;

            lblSelectedProfileDaysLeft.Text = (_currentProfile.TotalDays - _currentProfile.CurrentDay + 1).ToString() + " Days Left To Meet Goals.";
            lblSelectedProfileDaysLeft.Visible = true;
            _currentProfile.DailyMetrics = new List<DailyHealthMetric>();
            try
            {
                // Save the updated profile back to its JSON file
                string filePath = Path.Combine(profileManager.profilesDirectory, $"{_currentProfile.Name}#{_currentProfile.ID}.json");
                string updatedProfileJson = JsonConvert.SerializeObject(_currentProfile, Formatting.Indented);
                File.WriteAllText(filePath, updatedProfileJson);
                MessageBox.Show("Goals saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlGoalManagement.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the goals: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentProfile == null)
            {
                MessageBox.Show("No profile is currently loaded to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete the profile '{_currentProfile.Name}' (ID: {_currentProfile.ID})?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                bool deleted = profileManager.DeleteProfile(_currentProfile.ID, _currentProfile.Name);
                if (deleted)
                {
                    MessageBox.Show("Profile deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the UI and reset the current profile
                    _currentProfile = null;
                    lblSelectedProfileID.Visible = false;
                    lblSelectedProfileName.Visible = false;
                    lblSelectedProfileHeight.Visible = false;
                    lblSelectedProfileDaysLeft.Text="";
                    lblSelectedProfileNone.Visible = true;
                }
                else
                {
                    MessageBox.Show("Failed to delete the profile. The profile file may have been removed already.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSetHealthMetrics_Click(object sender, EventArgs e)
        {
            if ((_currentProfile.TotalDays - _currentProfile.CurrentDay) >= 0)
            {
                // Validate and parse inputs
                if (!double.TryParse(txtTodaysCalorieConsumption.Text, out double todaysCalories) || todaysCalories < 0 ||
                    !double.TryParse(txtTodaysWaterIntake.Text, out double todaysWater) || todaysWater < 0 ||
                    !double.TryParse(txtTodaysExercise.Text, out double todaysExercise) || todaysExercise < 0 ||
                    !double.TryParse(txtTodaysBodyWeight.Text, out double todaysWeight) || todaysWeight < 0)
                {
                    MessageBox.Show("Please enter valid metrics.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add the metrics for the current day
                var newMetric = new DailyHealthMetric
                {
                    Day = _currentProfile.CurrentDay,
                    CaloriesConsumed = todaysCalories,
                    WaterIntake = todaysWater,
                    TimeExercised = todaysExercise,
                    Weight = todaysWeight
                };

                _currentProfile.DailyMetrics.Add(newMetric);
                _currentProfile.CurrentDay++;

                // Save the updated profile
                string filePath = Path.Combine(profileManager.profilesDirectory, $"{_currentProfile.Name}#{_currentProfile.ID}.json");
                string updatedProfileJson = JsonConvert.SerializeObject(_currentProfile, Formatting.Indented);
                File.WriteAllText(filePath, updatedProfileJson);

                lblHealthMetricDayCounter.Text = "Day: " + (_currentProfile.CurrentDay).ToString();
                lblSelectedProfileDaysLeft.Text = (_currentProfile.TotalDays - _currentProfile.CurrentDay + 1).ToString() + " Days Left To Meet Goals.";
            }
            else
            {
                MessageBox.Show("No remaining days for logging metrics, you can now generate a report. If you " +
                    "don't wish to generate a report, please reset or update goals.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseHealthMetrics_Click(object sender, EventArgs e)
        {
            pnlLogMetrics.Visible = false;
        }
    }
}
