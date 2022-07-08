using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VHander : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    public Image jsContainer;
    public Image joyStick;
    public Vector3 InputDirection;

    public void newGame(){
        Debug.Log("new");
        InputDirection=Vector3.zero;
        transform.GetChild(0).position = transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("st");
        jsContainer = GetComponent<Image>();
        joyStick = transform.GetChild(0).GetComponent<Image>();
        newGame();
    }

    public void OnDrag(PointerEventData ped ){
        Debug.Log("ONdrog");
        Vector2 position = Vector2.zero;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            jsContainer.rectTransform,
            ped.position,
            ped.pressEventCamera,
            out position
        );
        position.x = (position.x/jsContainer.rectTransform.sizeDelta.x);
        position.y = (position.y/jsContainer.rectTransform.sizeDelta.y);

        float x = (jsContainer.rectTransform.pivot.x == 1f) ? position.x*2 +1 : position.x *2;
        float y = (jsContainer.rectTransform.pivot.y == 1f) ? position.y*2 +1 : position.y *2;

        InputDirection = new Vector3 (x,y,0);
        InputDirection = (InputDirection.magnitude > 1) ? InputDirection.normalized : InputDirection;

        joyStick.rectTransform.anchoredPosition = new Vector3 (InputDirection.x * (jsContainer.rectTransform.sizeDelta.x/3)
            ,InputDirection.y * (jsContainer.rectTransform.sizeDelta.y/3));
    }
    // Update is called once per frame
    public void OnPointerDown (PointerEventData ped){
        OnDrag(ped);
        Debug.Log("ONdrog");
    }
    public void OnPointerUp(PointerEventData ped){
        Debug.Log("ONdrog");
        InputDirection = Vector3.zero;
        joyStick.rectTransform.anchoredPosition = Vector3.zero;
    }
    void Update(){
    }
}
