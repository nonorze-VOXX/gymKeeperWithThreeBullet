using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BulletData", menuName = "ScriptableObjects/BulletData", order = 1)]
public class BulletData : ScriptableObject
{
    public float Speed;
    public float ShootRate;
    public float NextFireTime;
    public float ExistTime;
}
