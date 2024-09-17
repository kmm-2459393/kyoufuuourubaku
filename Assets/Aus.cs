using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Aus : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

}
        public void LButtonDown()
        {
            transform.Translate(-3, 0, 0);
        }

        public void RButtonDown()
        {
            transform.Translate(3, 0, 0);
        }
    
    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ÉSÅ[Éã");
        SceneManager.LoadScene("Game Kuria");
    }
}
