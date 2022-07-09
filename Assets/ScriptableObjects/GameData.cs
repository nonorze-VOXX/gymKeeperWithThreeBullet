using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/GameDataScriptableObject", order = 1)]
public class GameData : ScriptableObject
{

    public float screenSizeY;
    public float screenSizeX;
    public int numberOfBullet;
    public float normalBulletSpeed;
    public List<bullet> bulletList = new List<bullet>();
}