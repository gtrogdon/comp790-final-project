using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameState
{
    //Timing Elements
    public static long timer = 30 * 60;
    public static float timePassed = 0;

    //Scene Transition
    private static int scenesGiven = 0;
    private static List<string> scenes = new List<string>();

    static GameState(){
        scenes.Add("MazeScene/Maze");
        scenes.Add("MazeScene/Maze2");
        scenes.Add("Andrew Scenes/CielingPuzzle");
        scenes.Add("Andrew Scenes/CypherRoom");
    }

    public static string getNextScene()
    {
        if (scenesGiven >= 3) return "GameOverScenes/GameClear";

        int index = Mathf.FloorToInt(timePassed) % scenes.Count; 
        string retval = scenes[index];
        scenes.RemoveAt(index);

        scenesGiven++;

        return retval;
    }

    public static long getClock()
    {
        return Mathf.FloorToInt(timer - timePassed);
    }

    public static long decrementClock(float time)
    {
        timePassed += time;
        return Mathf.FloorToInt(timer - timePassed); ;
    }

}
