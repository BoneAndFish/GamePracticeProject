using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour {

    [SerializeField]
    private CreateMapData createMapData;
    private float mapTipSize;
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float rotateSpeed;

	// Use this for initialization
	void Start () {
        mapTipSize = createMapData.setOffSetValue;
    }

    public void Move(Vector3 inputDirection,float inputX,float inputZ)
    {
        Vector3 nextPos = transform.position;
        nextPos.x += inputDirection.x + mapTipSize * inputX;
        nextPos.z += inputDirection.z + mapTipSize * inputZ;
        Rotate(nextPos);
        transform.position = Vector3.Slerp(transform.position,nextPos,moveSpeed/60);
    }

    void Rotate(Vector3 nextPos)
    {
        /* angleは使いにくい.
        float angle = Vector3.Angle(transform.forward,direction);
        Debug.Log(angle);
        transform.Rotate(transform.up,angle);
        */
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(nextPos - transform.position),rotateSpeed);
    }

}
