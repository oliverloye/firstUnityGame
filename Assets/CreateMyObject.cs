using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// rename this class to suit your needs
public class CreateMyObject : MonoBehaviour
{
    // the Equip prefab - required for instantiation
    public GameObject equipPrefab;

    public void CreateObject()
    {
        // a prefab is need to perform the instantiation
        if (equipPrefab != null)
        {
            // get a random postion to instantiate the prefab - you can change this to be created at a fied point if desired
            //Vector3 position = new Vector3(Random.Range(minX + 0.5f, maxX - 0.5f), Random.Range(minY + 0.5f, maxY - 0.5f), 0);

            // instantiate the object
            Instantiate(equipPrefab, transform.position, Quaternion.identity);
        }
    }
}
