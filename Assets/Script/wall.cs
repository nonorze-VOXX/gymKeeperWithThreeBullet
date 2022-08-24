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
        
        data.bulletList.Enqueue(collision.gameObject);
        collision.gameObject.SetActive(false);
        print("col");
    }
}
