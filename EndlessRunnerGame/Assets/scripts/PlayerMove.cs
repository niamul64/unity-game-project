using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playerSpeed;// How fast our player will be Moving
    private Rigidbody2D rd;//
    private Vector2 playerDirection;// process --> players input
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();//fatch rigid body to game object

    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical"); //wich key user is pressing , if the user is presing "up arrow key", then directionY=1,
                                                         // if "down arrow key", then directionY=-1,
        playerDirection = new Vector2(0, directionY).normalized; // 0 -> not moving in x axis, directionY is the input, 1/-1
                                                                 // normilized is used to make the movement consistant
                                                                 //now update form FixedUpdate() finction




    }

    void FixedUpdate() //called ones per physics frame 
    {
        rd.velocity = new Vector2(0, playerDirection.y * playerSpeed);// anythin that apply in rigid body shold happen in FixedUpadate()
    }

}
