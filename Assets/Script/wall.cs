using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class wall : MonoBehaviour
{
    public GameData data;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision){
        data.bulletList.Remove(collision.gameObject);
        Destroy(collision.gameObject);
        print("col");
    }
}
