using UnityEngine;
using System;
 
public class movement_test_8 : MonoBehaviour
{
    [Header("gridsize depend on level design")]
    public float gridSize = 5.0f;
    [Header("to increase and dicrease speed ")]
    public float moveSpeed = 5.0f;
    [Header("forword or backword movement +1 or -1")]
    public int dirct_forward_backword = 1;
    [Space(1)]
    [Header("the dircation of plyer")]

    public string dirct = "forword" ;
    private bool keygetleft = true ; 
    private bool keygetright = true ; 
     private Vector3 pos;
    private Transform tr;
 
 

    [Header("Movement Keys")]
    public KeyCode leftKey = KeyCode.LeftArrow;
    public KeyCode rightKey = KeyCode.RightArrow;
 
    void Start()
    {
        pos = transform.position;
        tr = transform;
    }
 
    void Update()
    {
        bool canMove = (tr.position == pos);

                     if(Input.GetKeyDown(rightKey) && keygetright) 
                     {
                         keygetright = false ;
                          dirct = "right" ; 
                        keygetleft = false ;
                     }


                      if(Input.GetKeyDown(leftKey) && keygetleft) 
                     {
                       keygetleft = false ;
                       dirct = "left" ; 
                       keygetright = false ;

                     }


        if(canMove)
        {
          
             if(dirct == "left" )
            {
                transform.Rotate(0, -90, 0);
                dirct = "forword" ;
            }

          
              if(dirct == "right" )
            {
                transform.Rotate(0, 90, 0);
                dirct = "forword" ;
            }


            keygetleft = true ; 
            keygetright =true ;
            pos += transform.TransformDirection(Vector3.forward) * gridSize*dirct_forward_backword;
        }

        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * moveSpeed);

    }
}
 
