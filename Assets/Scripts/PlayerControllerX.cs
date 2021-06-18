using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spamTime = 0f;

    // Update is called once per frame
    void Update()
    {
        spamTime += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spamTime > 1.5f)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                spamTime = 0f;
            }
        }
    }
}
