using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CinemaManagementLibrary
{
	/// <summary>
	/// Provides methods to store and retrieve movie data from a JSON file.
	/// This generic repository supports Movie and derived classes such as ComingSoonMovie.
	/// </summary>
	/// <typeparam name="T">
	/// The movie type that inherits from the Movie class.
	/// </typeparam>
	public class MovieRepository<T> where T : Movie
	{
		// Stores the file path used for saving and loading movie data.
		private string filePath;


		/// <summary>
		/// Initializes a new instance of the MovieRepository class.
		/// </summary>
		/// <param name="filePath">
		/// The location of the JSON file used for storing movies.
		/// </param>
		public MovieRepository(string filePath)
		{
			this.filePath = filePath;
		}


		/// <summary>
		/// Saves a list of movies into a JSON file.
		/// </summary>
		/// <param name="movies">
		/// The list of movies to be saved.
		/// </param>
		public void SaveMovies(List<T> movies)
		{
			var options = new JsonSerializerOptions
			{
				WriteIndented = true
			};

			string jsonString = JsonSerializer.Serialize(movies, options);
			File.WriteAllText(filePath, jsonString);
		}


		/// <summary>
		/// Loads a list of movies from a JSON file.
		/// </summary>
		/// <returns>
		/// A list of movies loaded from the file.
		/// Returns an empty list if the file does not exist.
		/// </returns>
		public List<T> LoadMovies()
		{
			if (!File.Exists(filePath))
			{
				return new List<T>();
			}

			string jsonString = File.ReadAllText(filePath);

			return JsonSerializer.Deserialize<List<T>>(jsonString)
				   ?? new List<T>();
		}
	}
}