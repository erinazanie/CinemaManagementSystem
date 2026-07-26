using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CinemaManagementLibrary
{
    public class MovieRepository<T> where T : Movie
    {
        private string filePath;

        public MovieRepository(string filePath)
        {
            this.filePath = filePath;
        }

        // Save list of T (Movie or ComingSoonMovie) to JSON file
        public void SaveMovies(List<T> movies)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(movies, options);
            File.WriteAllText(filePath, jsonString);
        }

        // Load list of T (Movie or ComingSoonMovie) from JSON file
        public List<T> LoadMovies()
        {
            if (!File.Exists(filePath))
            {
                return new List<T>(); // Return empty list if file doesn't exist yet
            }

            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<T>>(jsonString) ?? new List<T>();
        }
    }
}