using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameData data;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y - data.Normal.Speed,
            0
        );
        
    }
    public void delete(){
        this.gameObject.SetActive(false);
        data.bulletList.Enqueue(this.gameObject);
    }
}
