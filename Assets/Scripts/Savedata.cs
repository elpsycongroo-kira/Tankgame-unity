using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class Savedata{

	public static List<Game> savedGames = new List<Game>();

	public static void Save(){
		Savedata.savedGames.Add(Game.current);  //add the current game to the list of games
		BinaryFormatter bf = new BinaryFormatter();
		//Application.persistentDataPath is a string, so if you wanted you can put that into debug.log if you want to know where save games are located
		FileStream file = File.Create (Application.persistentDataPath + "/savedGames.gd"); 
		bf.Serialize(file, Savedata.savedGames); //serialize the game data and write in the file
		file.Close();
	}

	public static void Load() {
		if(File.Exists(Application.persistentDataPath + "/savedGames.gd")) {
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
			Savedata.savedGames = (List<Game>)bf.Deserialize(file); //store data from the file in the list
			file.Close();
		}
	}
}
