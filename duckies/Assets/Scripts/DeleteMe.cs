using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMe : MonoBehaviour
{
    float time = 5;
    float totalTime = 5;
    public string owner;

    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0f) {
            Destroy(this.gameObject);
        }
    }
}
