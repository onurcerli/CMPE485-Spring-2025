using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapCollision : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Key") || collision.collider.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameFailureScene");
        }
    }
}