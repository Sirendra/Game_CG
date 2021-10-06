using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTO : MonoBehaviour
{   int nextSceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        nextSceneToLoad=SceneManager.GetActiveScene().buildIndex+1;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
