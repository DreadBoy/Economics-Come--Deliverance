using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
     }

    // Update is called once per frame
    void Update()
    {

    }

    public static void lowerDemand()
    {
        GameState.state.demandDelta = -500;
    }

    public static void higherDemand()
    {
        GameState.state.demandDelta = 100;
    }


    public static void applyNewDay()
    {
        GameState.state.supply += GameState.state.supplyDelta;
        GameState.state.supplyDelta = 0;
        GameState.state.demand += GameState.state.demandDelta;
        GameState.state.demandDelta = 0;

		GameState.state.demand += 10;

		if (GameState.state.supply < GameState.state.demand)
			GameState.state.demand = GameState.state.supply;
		GameState.state._premozenje += GameManager.profit ();

		GameState.state.daysLeft--;
    }

	public static int profit(){
		return GameState.state.supply * -80 + GameState.state.demand * GameState.state._cena; 
	}

    public static void saveProgress()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/Progress.vz");
        bf.Serialize(file, GameState.export());
        file.Close();
    }

    public static void loadProgress()
    {
        if (File.Exists(Application.persistentDataPath + "/Progress.vz"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/Progress.vz", FileMode.Open);
            GameState.import((GameState.State)bf.Deserialize(file));
            file.Close();
        }
    }
}
