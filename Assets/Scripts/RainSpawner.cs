using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSpawner : MonoBehaviour
{
    public GameObject prefab;
    public bool rainOn = false;
    float freq = 0.2f;
    Vector3 colMin, colMax;

    void Start()
    {
        colMin = GetComponent<Collider>().bounds.min;
        colMax = GetComponent<Collider>().bounds.max;
    }

    void MakeDrop()
    {
        GameObject newDrop = Instantiate(prefab);
        float randX = Random.Range(colMin.x, colMax.x);
        float randY = Random.Range(colMin.y, colMax.y);
        float randZ = Random.Range(colMin.z, colMax.z);
        newDrop.transform.position = new Vector3(randX, randY, randZ);

        if (rainOn) Invoke("MakeDrop", freq);
    }

    public void RainToggle(bool val)
    {
        rainOn = val;
        if (rainOn) MakeDrop();
    }
    public void ChangeFreq(float val)
    {
        freq = val;
    }
}