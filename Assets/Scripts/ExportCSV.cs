using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class ExportCSV {

	public void Save(){
		List<string[]> rowData = new List<string[]>();	
		string[] rowDataTemp = new string[10];
		rowDataTemp[0] = "Player Name";					///first line of the file
		rowDataTemp[1] = "No.of Tanks Used";
		rowDataTemp[2] = "Initial Tank Formation";
		rowDataTemp[3] = "No.of Damaged Tanks";
		rowDataTemp[4] = "No.of Redraws";
		rowDataTemp[5] = "No.of Enemy Tanks";
		rowDataTemp[6] = "No.of Tree collisions";
		rowDataTemp[7] = "No.of House collisions";
		rowDataTemp[8] = "No.of Water collisions";
		rowDataTemp[9] = "Objective Completed";
		rowData.Add(rowDataTemp);

		if (File.Exists (Application.persistentDataPath + "/savedGames.gd")) {	//Condition checks if the savedgames exist
			List<Game> savedGame = new List<Game>();
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
			savedGame = (List<Game>)bf.Deserialize(file);	//copies the list of objects of Game class in the savGame variable
			file.Close();
			for(int i = 0 ; i < savedGame.Count ; i++){
				string[] firstData = new string[10];
				firstData[0] = savedGame[i].playername;
				firstData[1] = savedGame[i].no_of_tanks.ToString();
				firstData[2] = savedGame[i].initialTankFormation;
				firstData[3] = savedGame[i].no_of_damaged_tanks.ToString();
				firstData[4] = savedGame[i].no_of_redraws.ToString();
				firstData[5] = savedGame[i].no_of_enemy_tanks.ToString();
				firstData[6] = savedGame[i].no_of_tree_collisions.ToString();
				firstData[7] = savedGame[i].no_of_house_collisions.ToString();
				firstData[8] = savedGame[i].no_of_water_collisions.ToString();
				firstData[9] = savedGame[i].objectiveCompleted.ToString();
				rowData.Add(firstData);
				firstData = new String[10];
				firstData[0] = "";
				firstData[1] = "";
				firstData[2] = "";
				firstData[3] = "";
				firstData[4] = "";
				firstData[5] = "";
				firstData[6] = "";
				firstData[7] = "";
				firstData[8] = "";
				firstData[9] = "";
				rowData.Add(firstData);
			}

			string[][] output = new string[rowData.Count][];
			//Debug.Log(rowData.Count.ToString());
			for(int i = 0; i < output.Length; i++)				// copy the data from list to 2D array 'output'
			{
				output[i] = rowData[i];
			}
			
			int length = output.GetLength(0);
			string delimiter = ",";
			
			StringBuilder sb = new StringBuilder();
			
			for (int index = 0; index < length; index++)
				sb.AppendLine(string.Join(delimiter, output[index]));			//generates the required file with coma and new line seperations
			
			
			string filePath = getPath();
			TextWriter f1 = new StreamWriter(filePath,false);
			f1.WriteLine(sb);
			f1.Close();
		}
	}

	private string getPath(){
		//Debug.Log(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments).ToString()+"Saved_data.csv");
		return Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents").ToString()+"/Tank_Game_Data.csv";
		//return Application.dataPath + "/Tank_data.csv";
		//returns the output path of the file in documents folder of the current PC 
	}
}
