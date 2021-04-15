using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
	public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 };

    private const float Z = 10f;
    public RotationAxes axes = RotationAxes.MouseXAndY;
	public float sensitivityX = 15F;
	public float sensitivityY = 15F;

	public float minimumX = -360F;
	public float maximumX = 360F;

	public float minimumY = -60F;
	public float maximumY = 60F;

	float rotationX = 0F;
	float rotationY = 0F;


	Quaternion originalRotation;
	public Transform move;

	void Update()
	{
		
		move.transform.Rotate(0f, 0.0f, 10.0f, Space.Self);



		if (Input.GetMouseButton(0))
		{

			if (axes == RotationAxes.MouseXAndY)
			{
				// Read the mouse input axis
				rotationX += Input.GetAxis("Mouse X") * sensitivityX;
				rotationY += Input.GetAxis("Mouse Y") * sensitivityY;

				rotationX = ClampAngle(rotationX, minimumX, maximumX);
				rotationY = ClampAngle(rotationY, minimumY, maximumY);

				Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
				Quaternion yQuaternion = Quaternion.AngleAxis(rotationY, -Vector3.right);

				transform.localRotation = originalRotation * xQuaternion * yQuaternion;
			}
			else if (axes == RotationAxes.MouseX)
			{
				rotationX += Input.GetAxis("Mouse X") * sensitivityX;
				rotationX = ClampAngle(rotationX, minimumX, maximumX);

				Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
				transform.localRotation = originalRotation * xQuaternion;
			}
			else
			{
				rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
				rotationY = ClampAngle(rotationY, minimumY, maximumY);

				Quaternion yQuaternion = Quaternion.AngleAxis(-rotationY, Vector3.right);
				transform.localRotation = originalRotation * yQuaternion;
			}
		}
        if (Input.GetKey(KeyCode.KeypadPlus))
        {
			this.transform.Rotate(0f, 0f, 10.0f, Space.Self);
        }
		if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
		{
			this.transform.position += new Vector3(0f, 0f, 1.0f );
		}
		else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
		{
			this.transform.position -= new Vector3(0f, 0f, 1.0f );
		}



	}

	Rigidbody rigid;
	void Start()
	{


		if (rigid)
			rigid.freezeRotation = true;
		originalRotation = transform.localRotation;
	}

	public static float ClampAngle(float angle, float min, float max)
	{
		if (angle < -360F)
			angle += 360F;
		if (angle > 360F)
			angle -= 360F;
		return Mathf.Clamp(angle, min, max);
	}
	public void changeColor()
    {
		this.gameObject.GetComponent<Renderer>().material.color = Color.green;
	}
}
