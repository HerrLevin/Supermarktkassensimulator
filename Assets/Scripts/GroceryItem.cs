using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class GroceryItem : MonoBehaviour
{
	private Camera mainCamera;
	private float CameraZDistance;

	void Start() 
	{
		mainCamera = Camera.main;
		CameraZDistance = mainCamera.WorldToScreenPoint(transform.position).z;
	}

    void OnMouseDrag() {
		Vector3 ScreenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, CameraZDistance);
		Vector3 NewWorldPosition = mainCamera.ScreenToWorldPoint(ScreenPosition);
		transform.position = NewWorldPosition;
	}

    void OnTriggerEnter(Collider other)
    {
        ShouldMove(other);
    }

    void OnTriggerStay(Collider other)
    {
        ShouldMove(other);
    }

    void ShouldMove(Collider other)
    {
        if (other.gameObject.tag == "ConveyerR" && !GameManager.instance.stopRightConveyer)
        {
            Move();
        }

        if (other.gameObject.tag == "ConveyerL")
        {
            Move();
        }
    }

    void Move()
    {
        
        transform.Translate(-Vector3.right * Time.deltaTime, Space.World);
    }
}
