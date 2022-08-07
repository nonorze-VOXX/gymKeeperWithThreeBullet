using System.Collections;
using UnityEngine;

//public class bullet : MonoBehaviour

public class BulletManager : MonoBehaviour
{
    [SerializeField]
    private GameObject normalBullet;
    public GameData data;
    public Quaternion q;
    public GameObject BulletContainer;

    // Start is called before the first frame update
    void Start()
    {
        data.Normal.NextFireTime=0f;
        data.bulletList.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>data.Normal.NextFireTime){
            data.Normal.NextFireTime += data.Normal.ShootRate;
            CreateNormal(Random.Range(-data.screenSizeX,data.screenSizeX),15,normalBullet);
        }
    }
    
    public void CreateNormal(float x, float y,GameObject Bullet)
    { 
        GameObject newBullet = Instantiate(
            Bullet, 
            BulletContainer.transform.position + new Vector3(x,y,0),
            BulletContainer.transform.rotation,
            BulletContainer.transform);
        data.bulletList.Add(newBullet);
        //data.bulletList[data.numberOfBullet++] = clone;
    }
}
