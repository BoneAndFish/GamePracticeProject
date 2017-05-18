using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTankController : MonoBehaviour {

    [SerializeField]
    private TankMove tankMove;
    private Vector3 moveDirection;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Horizontal") !=0||Input.GetAxis("Vertical")!=0) {
            InputPlayer();
        }
    }

    void InputPlayer()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        moveDirection = new Vector3(x,transform.position.y,z);
        tankMove.Move(moveDirection,x,z);
    }   


}
