using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/GameDataScriptableObject", order = 1)]
public class GameData : ScriptableObject
{

    public float screenSizeY;
    public float screenSizeX;
    public BulletData Normal;
    public BulletData HighSpeed;
    public float muscleRate;
    public float muscleLevel;
    public float muscleTrainSpeed;
    public int HP;
    public List<GameObject> bulletList = new List<GameObject>();
}