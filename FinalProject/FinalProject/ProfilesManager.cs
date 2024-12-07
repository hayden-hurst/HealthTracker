using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class ProfileManager
    {
        private string profilesDirectory;

        // Constructor: Initializes the profiles directory
        public ProfileManager(string directory)
        {
            profilesDirectory = directory;

            // Ensure the directory exists
            if (!Directory.Exists(profilesDirectory))
            {
                Directory.CreateDirectory(profilesDirectory);
            }
        }

        // Create a new profile with a random ID
        public string CreateProfile(string name, double weight, double height)
        {
            string id = GenerateRandomID();
            string fileName = Path.Combine(profilesDirectory, id + ".txt");

            // Write profile data to file
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("ID: " + id);
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Weight: " + weight);
                writer.WriteLine("Height: " + height);
            }

            return id; // Return the generated ID of the new profile
        }

        // Edit an existing profile
        public bool EditProfile(string id, string name, double weight, double height)
        {
            string fileName = Path.Combine(profilesDirectory, id + ".txt");

            // Check if profile exists
            if (!File.Exists(fileName))
            {
                return false; // Profile not found
            }

            // Rewrite the profile data
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("ID: " + id);
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Weight: " + weight);
                writer.WriteLine("Height: " + height);
            }

            return true; // Profile edited successfully
        }

        // Delete a profile by ID
        public bool DeleteProfile(string id)
        {
            string fileName = Path.Combine(profilesDirectory, id + ".txt");

            // Check if profile exists
            if (!File.Exists(fileName))
            {
                return false; // Profile not found
            }

            // Delete the profile file
            File.Delete(fileName);

            return true; // Profile deleted successfully
        }

        // Get a profile by ID
        public Dictionary<string, string> GetProfile(string id)
        {
            string fileName = Path.Combine(profilesDirectory, id + ".txt");

            // Check if the profile exists
            if (!File.Exists(fileName))
            {
                return null; // Profile not found
            }

            // Read the profile data from file
            var profileData = new Dictionary<string, string>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(new string[] { ": " }, StringSplitOptions.None);
                    if (parts.Length == 2)
                    {
                        profileData[parts[0]] = parts[1];
                    }
                }
            }

            return profileData; // Return the profile data
        }

        // Generate a random ID (GUID)
        private string GenerateRandomID()
        {
            return Guid.NewGuid().ToString();
        }

        // Get all profile IDs
        public List<string> GetAllProfileIDs()
        {
            List<string> profileIDs = new List<string>();

            // Get all files with ".txt" extension in the profiles directory
            foreach (string file in Directory.GetFiles(profilesDirectory, "*.txt"))
            {
                string id = Path.GetFileNameWithoutExtension(file);
                profileIDs.Add(id);
            }

            return profileIDs;
        }
    }

}
}
