using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.SceneManagement;

public class UserInterfaceButtons : MonoBehaviour
{
	public float translationSpeed = 20.0f;
    public float rotationSpeed = 70.0f;
    //	public GameObject Model;

    bool repeatPositionUp = false;
	bool repeatPositionDown = false;
    bool repeatRotateLeft = false;
    bool repeatRotateRight = false;

    void Update ()
	{

		if (repeatPositionUp) {
			PositionUpButton();
		}

		if (repeatPositionDown) {
			PositionDownButton();
		}

        if (repeatRotateRight && (repeatPositionUp || repeatPositionDown))
        {
            RotationRightButton();
        }


        if (repeatRotateLeft && (repeatPositionUp || repeatPositionDown))
        {
            RotationLeftButton();
        } 

    }

    public void RotateLeftButtonOff()
    {
        repeatRotateLeft = false;
        Debug.Log("Off");
    }

    public void RotateRightButtonOff()
    {
        repeatRotateRight = false;
        Debug.Log("Off");
    }
    public void PositionUpButtonOff ()
	{
		repeatPositionUp = false;
		Debug.Log ("Off");
	}
	public void PositionDownButtonOff ()
	{
		repeatPositionDown = false;
		Debug.Log ("Off");
	}

    public void PositionDownButton()
	{
		GameObject.FindWithTag("Model").transform.Translate (0, 0, -translationSpeed * Time.deltaTime);
        repeatPositionDown = true;
    }

	public void PositionUpButton()
	{
		GameObject.FindWithTag("Model").transform.Translate (0, 0, translationSpeed * Time.deltaTime);
        repeatPositionUp = true;
    }

    public void RotationRightButton()
    {
        GameObject.FindWithTag("Model").transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        repeatRotateRight = true;
    }

    public void RotationLeftButton()
    {

        GameObject.FindWithTag("Model").transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        repeatRotateLeft = true;
    }

    public void AnyButton ()
	{
		Debug.Log ("Any");
	}
    
}
