using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/GameDataScriptableObject", order = 1)]
public class GameData : ScriptableObject
{

    public float screenSizeY;
    public float screenSizeX;
    public int numberOfBullet;
    public float normalBulletSpeed;
    public float normalBulletShootRate;
    public float normalBulletNextFireTime;
    public float normalBulletExistTime;
    public float muscleRate;
    public float muscleLevel;
    public float muscleTrainSpeed;
    public int HP;
    public List<GameObject> bulletList = new List<GameObject>();
}