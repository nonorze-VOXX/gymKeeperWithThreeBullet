using System.Collections;
using UnityEngine;

//public class bullet : MonoBehaviour

public class BulletManager : MonoBehaviour
{
    public bullet normalBullet;
    public GameData data;
    public Quaternion q;
    public GameObject BulletContainer;

    // Start is called before the first frame update
    void Start()
    {
        data.bulletList.Clear();
        for(int i=0;i<10 ; i++){
            CreateNormal(i,15,normalBullet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (bullet item in data.bulletList)
        {
            print(item.test);
            item.transform.position = new Vector3(
                item.transform.position.x,
                item.transform.position.y - data.normalBulletSpeed,
                0
            );
        }
    }
    
    public void CreateNormal(int x, int y,bullet Bullet)
    { 
        bullet newBullet = Instantiate(
            Bullet, 
            BulletContainer.transform.position + new Vector3(x,y,0),
            BulletContainer.transform.rotation,
            BulletContainer.transform);
        data.bulletList.Add(newBullet);
        //data.bulletList[data.numberOfBullet++] = clone;
        Debug.Log(BulletContainer.transform.position);
    }
}
