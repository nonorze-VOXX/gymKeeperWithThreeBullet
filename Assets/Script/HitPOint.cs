using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPOint : MonoBehaviour
{
    public GameData data;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(true);
        data.HP=3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision){
        data.HP -=1;
        Destroy(collision.gameObject);
        this.gameObject.SetActive(false);
    }
}
