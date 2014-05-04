using UnityEngine;
using System.Collections;

public class PheelCamera : MonoBehaviour
{

    public Transform target;
	public float relativeHeigth = 1.0f;
    public float zDistance = 5.0f;
    public float dampSpeed = 2;

    void Update () {
        Vector3 newPos = target.position + new Vector3(0, 2, -10);
        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime*dampSpeed);
	}
}
