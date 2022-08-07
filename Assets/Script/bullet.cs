using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameData data;
    public float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= data.Normal.ExistTime){
            delete();
        }
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y - data.Normal.Speed,
            0
        );
        
    }
    public void delete(){
        data.bulletList.Remove(this.gameObject);
        Destroy(this.gameObject);
    }
}
