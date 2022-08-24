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
        for(int i=0;i<10;i++){
            CreateNormal(normalBullet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>data.Normal.NextFireTime){
            data.Normal.NextFireTime += data.Normal.ShootRate;
            if(data.bulletList.Count==0){
                CreateNormal(normalBullet);
            }
            FireNormal(Random.Range(-data.screenSizeX,data.screenSizeX),15);
        }
    }
    
    public void FireNormal(float x, float y){
        GameObject newBullet = data.bulletList.Dequeue();
        newBullet.transform.position = new Vector3(x,y,0);
        newBullet.SetActive(true);

    }
    public void CreateNormal(GameObject Bullet)
    { 
        GameObject newBullet = Instantiate(
            Bullet, 
            BulletContainer.transform.position,
            BulletContainer.transform.rotation,
            BulletContainer.transform);
        newBullet.SetActive(false);
        data.bulletList.Enqueue(newBullet);
        //data.bulletList[data.numberOfBullet++] = clone;
    }
}
