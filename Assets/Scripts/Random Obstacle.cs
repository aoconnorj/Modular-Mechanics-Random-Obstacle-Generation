using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObstacle : MonoBehaviour
{
    public GameObject myPrefab;
    public float x = 0f;
    public float y = 0f;
    public float z = 0f;
    public float Min = -5f;
    public float Max = 5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {

            Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
            x = Random.Range(Min, Max);

        } else if (Input.GetKeyDown(KeyCode.W)) {

            Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
            y = Random.Range(Min, Max);

        } else if (Input.GetKeyDown(KeyCode.D)) {

            Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
            z = Random.Range(Min, Max);
        }
            
    }
}
