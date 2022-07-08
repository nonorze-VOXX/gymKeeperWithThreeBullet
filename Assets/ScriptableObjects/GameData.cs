using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/GameDataScriptableObject", order = 1)]
public class GameData : ScriptableObject
{

    public float screenSizeY;
    public float screenSizeX;
    public int numberOfBullet;
    public bullet[] bulletList = new bullet[100];
}