using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    private Rigidbody2D playerRigidbody;
    private Vector3 currentMovement;


    // Start is called before the first frame update
    void Start(){
        playerRigidbody = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update(){
        currentMovement = Vector3.zero;
        // GetAxisRaw is only 1 or 0, getAxis "accls" from 0-1
        currentMovement.x = Input.GetAxisRaw("Horizontal");
        currentMovement.y = Input.GetAxisRaw("Vertical");
        if(currentMovement != Vector3.zero) MoveCharacter();
    }

    void MoveCharacter(){
        playerRigidbody.MovePosition(transform.position + currentMovement * moveSpeed * Time.deltaTime);
    }


}
