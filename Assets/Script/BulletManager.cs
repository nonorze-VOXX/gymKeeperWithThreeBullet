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
        for(int i=0;i<10 ; i++){
            CreateNormal(i,15,normalBullet);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    public void CreateNormal(int x, int y,bullet Bullet)
    {
        bullet clone = Instantiate(
            Bullet, 
            BulletContainer.transform.position + new Vector3(x,y,0),
            BulletContainer.transform.rotation,
            BulletContainer.transform);
        //data.bulletList[data.numberOfBullet++] = clone;
        Debug.Log(BulletContainer.transform.position);
    }
}
