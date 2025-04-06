using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace FinalProject
{
    internal class ProfileManager
    {
        public string profilesDirectory;

        // Constructor: Initializes the profiles directory
        public ProfileManager(string directory)
        {
            profilesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, directory);

            // Ensure the directory exists
            if (!Directory.Exists(profilesDirectory))
            {
                Directory.CreateDirectory(profilesDirectory);
            }
        }

        // Create a new profile
        public string CreateProfile(string name, double height)
        {
            string id = GenerateRandomID();
            string filePath = Path.Combine(profilesDirectory, name + "#" + id + ".json");

            var profile = new Profile
            {
                ID = id,
                Name = name,
                Height = height,
                CurrentDay = 1,
                TotalDays = 0,
                TargetWeight = 0,
                TargetWaterIntake = 0,
                TargetCaloriesConsumed = 0,
                TargetTimeExercised = 0,
                DailyMetrics = new List<DailyHealthMetric>()
            };

            // Serialize profile to JSON and save to file using JsonConvert
            string json = JsonConvert.SerializeObject(profile);
            File.WriteAllText(filePath, json);

            return id; // Return the generated profile ID
        }

        // Edit an existing profile
        /*
        public bool EditProfile(string id, string name, double height)
        {
            string filePath = Path.Combine(profilesDirectory, id + ".json");

            // Check if profile exists
            if (!File.Exists(filePath))
            {
                return false; // Profile not found
            }

            var profile = new Profile
            {
                ID = id,
                Name = name,
                Height = height
            };

            // Serialize updated profile to JSON and save using JsonConvert
            string json = JsonConvert.SerializeObject(profile);
            File.WriteAllText(filePath, json);

            return true; // Profile edited successfully
        }
        */

        // Delete a profile by ID
        public bool DeleteProfile(string id, string name)
        {
            string filePath = Path.Combine(profilesDirectory, name + "#" + id + ".json");

            // Check if profile exists
            if (!File.Exists(filePath))
            {
                return false; // Profile not found
            }

            // Delete the profile file
            File.Delete(filePath);

            return true; // Profile deleted successfully
        }

        // Generate a random ID
        private string GenerateRandomID()
        {
            return Guid.NewGuid().ToString();
        }
    }

    // Profile class to represent profile data
    public class Profile
    {
        // Profile Information
        public string ID { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }

        // Health Goal
        public int CurrentDay { get; set; }
        public int TotalDays { get; set; }
        public double TargetWeight { get; set; }
        public double TargetWaterIntake { get; set; }
        public double TargetCaloriesConsumed { get; set; }
        public double TargetTimeExercised { get; set; }

        // List of daily health metrics
        public List<DailyHealthMetric> DailyMetrics { get; set; } = new List<DailyHealthMetric>();

        // Constructor to ensure DailyMetrics is initialized
        public Profile()
        {
            DailyMetrics = new List<DailyHealthMetric>();
        }

    }

    public class DailyHealthMetric
    {
        public int Day { get; set; } // CurrentDay
        public double Weight { get; set; }
        public double WaterIntake { get; set; }
        public double CaloriesConsumed { get; set; }
        public double TimeExercised { get; set; }
    }
}