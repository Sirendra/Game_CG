using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{
    public int count;
    int nextSceneToLoad;

    void Start()
    {
        count = 0;
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        SetCountText();
    }
    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Pickup")
        {
            Destroy(other.gameObject);
            count = count + 1;
            SetCountText();
        }

    }

    void SetCountText()
    {
        if (count == 10)
        {
            SceneManager.LoadScene(nextSceneToLoad);
        }
    }
}
