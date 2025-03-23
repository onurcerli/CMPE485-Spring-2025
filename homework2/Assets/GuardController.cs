using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuardController : MonoBehaviour
{

    public GameObject player;
    bool forward;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(move());
    }

    // Update is called once per frame
    void Update()
    {
        detectPlayer();
    }

    IEnumerator move()
    {
        while (true)
        {
            if (transform.position.x > 17)
            {
                forward = true;
                yield return new WaitForSeconds(5);
            }
            else if (transform.position.x < -30)
            {
                forward = false;
                yield return new WaitForSeconds(5);
            }
            else
                yield return null;


            if (forward)
                transform.position = transform.position + new Vector3(-2 * Time.deltaTime, 0, 0);
            else
                transform.position = transform.position + new Vector3(2 * Time.deltaTime, 0, 0);
        }
       
    }

    void detectPlayer()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 5)
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }
}
