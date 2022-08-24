using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPOint : MonoBehaviour
{
    public GameData data;
    // Start is called before the first frame update
    public void newGame(){
        this.gameObject.SetActive(true);
        data.HP=3;
    }
    void Start()
    {
        newGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision){
        data.HP -=1;
        collision.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
        data.bulletList.Enqueue(collision.gameObject);
    }
}
