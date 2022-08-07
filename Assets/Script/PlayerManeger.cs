using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManeger : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    public float detectLenth = 0.1f;
    public VHander jsMovement ;
    private float xMin, xMax, yMin,yMax;
    public float startX = 0f,StartY = 0f;
    private Vector3 direction;

    BoxCollider2D mCollider;
    RectTransform rt;

    public GameObject player;
    public GameData data;



    public void initPlayer(){
        player.transform.position = new Vector3(startX,StartY,0);
    }
    // Start is called before the first frame update
    void Start()
    {
        data.muscleLevel = 0f;
        data.muscleRate = 0f;
        data.muscleTrainSpeed = 50f;
        data.Normal.ShootRate = 1f;
        initPlayer();
        xMax = data.screenSizeX;//Screen.width;
        xMin = data.screenSizeX*-1;
        yMax = data.screenSizeY;//Screen.height;
        yMin = data.screenSizeY*-1;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey("space")){
            data.muscleRate += Time.deltaTime*data.muscleTrainSpeed;
            if(data.muscleRate>=100f){
                data.muscleLevel+=1;
                if(data.Normal.ShootRate>=0.32){
                    data.Normal.ShootRate*=0.9f;
                }
                data.muscleRate = 0f;
            }
        }else{
            if((Input.GetKey("d")||Input.GetKey("right"))&&player.transform.position.x<xMax){
                player.transform.position = new Vector3(
                    player.transform.position.x+moveSpeed,
                    player.transform.position.y,
                    0);
            }

            if((Input.GetKey("w")||Input.GetKey("up"))&&player.transform.position.y<yMax){
                player.transform.position = new Vector3(
                    player.transform.position.x,
                    player.transform.position.y+moveSpeed,
                    0);
            }
            if((Input.GetKey("a")||Input.GetKey("left"))&&player.transform.position.x>xMin){
                player.transform.position = new Vector3(
                    player.transform.position.x-moveSpeed,
                    player.transform.position.y,
                    0);
            }

            if((Input.GetKey("s")||Input.GetKey("down"))&&player.transform.position.y>yMin){
                player.transform.position = new Vector3(
                    player.transform.position.x,
                    player.transform.position.y-moveSpeed,
                    0);
            }

        }
    }
}
