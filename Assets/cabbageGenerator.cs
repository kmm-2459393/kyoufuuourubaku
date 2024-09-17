using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabbageGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 3.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
         this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(5,-4);
            go.transform.position = new Vector3(-42, px, 3);
        }
    }
}
