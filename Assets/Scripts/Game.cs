using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

[System.Serializable]
public class Game{
	public static Game current;
	public string playername;
	public int no_of_tanks;
	public string initialTankFormation;
	public int no_of_damaged_tanks;
	public int no_of_redraws;
	public int no_of_enemy_tanks;
	public int no_of_tree_collisions;
	public int no_of_house_collisions;
	public int no_of_water_collisions;
	public bool objectiveCompleted;
}
