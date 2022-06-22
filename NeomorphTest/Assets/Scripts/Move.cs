using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 Vec;
    public List<GameObject> Feet;
    public List<GameObject> BodyPoints;
    public List<GameObject> Legs;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            UpdateLegsForward();
            this.transform.Translate(Vector3.forward * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            UpdateLegsBack();
            this.transform.Translate(Vector3.back * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            UpdateLegsLeft();
            this.transform.Translate(Vector3.left * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            UpdateLegsRight();
            this.transform.Translate(Vector3.right * Time.deltaTime);
        }
    }

    private void UpdateLegsForward()
    {
        foreach (var item in Legs)
        {
            item.transform.Translate(Vector3.forward * Time.deltaTime);

            item.transform.LookAt(this.transform);
        }
        foreach (var item in Feet)
        {
            item.transform.Translate(Vector3.forward * Time.deltaTime);

            item.transform.LookAt(this.transform);
        }
    }

    private void UpdateLegsBack()
    {
        foreach (var item in Legs)
        {
            item.transform.Translate(Vector3.back * Time.deltaTime);

            item.transform.LookAt(this.transform);
        }
        foreach (var item in Feet)
        {
            item.transform.Translate(Vector3.back * Time.deltaTime);

            item.transform.LookAt(this.transform);
        }
    }

    private void UpdateLegsLeft()
    {
        foreach (var item in Legs)
        {
            item.transform.Translate(Vector3.left * Time.deltaTime);

            item.transform.LookAt(this.transform);
        }
        foreach (var item in Feet)
        {
            item.transform.Translate(Vector3.back * Time.deltaTime);

            item.transform.LookAt(this.transform);
        }
    }

    private void UpdateLegsRight()
    {
        foreach (var item in Legs)
        {
            item.transform.Translate(Vector3.right * Time.deltaTime);
            item.transform.LookAt(this.transform);
        }
        foreach (var item in Feet)
        {
            item.transform.Translate(Vector3.back * Time.deltaTime);

            item.transform.LookAt(this.transform);
        }
    }
}
