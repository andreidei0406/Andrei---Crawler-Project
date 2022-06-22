using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLegs : MonoBehaviour
{
    public List<GameObject> Legs;
    public List<GameObject> Feet;
    private float growthRate = 10f;
    private float growthAmount = 0.0f;
    private Vector3 lastPos;
    public GameObject GroundPlane;

    private void Start()
    {
        lastPos = transform.position;
    }

    //private void Update()
    //{
    //    if(transform.hasChanged)
    //    {
    //        foreach (var item in Feet)
    //        {
    //            item.transform.position = new Vector3(Random.Range(-10, 10), item.transform.position.y, Random.Range(-10, 10));
    //            item.transform.LookAt(transform.position);
    //        }
    //        transform.hasChanged = false;
    //    }
    //}

    private void UpdateLegsDimension(Vector3 distance)
    {
        foreach (var item in Legs)
        {
            growthAmount = growthRate * Time.deltaTime;
            float dist = Vector3.Distance(item.transform.position, GroundPlane.transform.position);
            if(dist >= 0)
                item.transform.localScale += new Vector3(0, growthAmount, 0);
        }
    }
}
