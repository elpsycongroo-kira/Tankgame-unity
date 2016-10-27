using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FinalScene : MonoBehaviour {

    public Text Playername;
    public Text TanksNum;
    public Text EnemyTanks;
    public Text DamagedTanks;
    public Text Redraws;
    public Text InitialFormation;
    public Text TreeCollisions;
    public Text HouseCollisions;
    public Text WaterCollisions;
    public Text Objective;

	// Use this for initialization
	void Start () {
        Savedata.Load();
        Game.current = new Game();
		Game.current.playername = PlayerPrefs.GetString("playername");
        Game.current.no_of_tanks = 3;
		Game.current.no_of_enemy_tanks = PlayerPrefs.GetInt("enemycount");
        Game.current.no_of_damaged_tanks = 1;
		Game.current.no_of_house_collisions = PlayerPrefs.GetInt("housecollision");
		Game.current.no_of_tree_collisions = PlayerPrefs.GetInt("treecollision");
		Game.current.no_of_water_collisions = PlayerPrefs.GetInt("watercollision");
        Game.current.objectiveCompleted = false;
		Game.current.initialTankFormation = PlayerPrefs.GetString("initialformation");
		Game.current.no_of_redraws =  PlayerPrefs.GetInt("no_of_redraws");
        Playername.text = Game.current.playername;
        TanksNum.text = Game.current.no_of_tanks.ToString();
        EnemyTanks.text = Game.current.no_of_enemy_tanks.ToString();
        DamagedTanks.text = Game.current.no_of_damaged_tanks.ToString();
        Redraws.text = Game.current.no_of_redraws.ToString();
        InitialFormation.text = Game.current.initialTankFormation;
        TreeCollisions.text = Game.current.no_of_tree_collisions.ToString();
        HouseCollisions.text = Game.current.no_of_house_collisions.ToString();
        WaterCollisions.text = Game.current.no_of_water_collisions.ToString();
        Objective.text = Game.current.objectiveCompleted.ToString();
        Savedata.Save();
	}

    public void showPathTaken() {
        
    }

    public void csvFile() {
        ExportCSV temp = new ExportCSV();
        temp.Save();
        Debug.Log("csv file generated");
    }

    public void restartGame() {
        Application.LoadLevel(0);
    }

    public void quitGame() {
        Application.Quit();
    }
}
