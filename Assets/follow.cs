using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

    [SerializeField] //for explicity sake
    public GameObject position_camera; //assign this in the editor or find it in the start function.
    public GameObject player;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    //private void Start(){
    //    
    //}

    void LateUpdate()
    {
        this.transform.position = Vector3.SmoothDamp(this.transform.position, position_camera.transform.position, ref velocity, smoothTime);
        //change the last value to the time you want to complete the movement.
         transform.LookAt(player.transform);
    }
}
