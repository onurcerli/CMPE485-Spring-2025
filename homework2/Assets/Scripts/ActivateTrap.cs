using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTrap : MonoBehaviour
{
    public GameObject trapactiveprefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Activate());
    }

    IEnumerator Activate()
    {
        yield return new WaitForSeconds(5);
        Instantiate(trapactiveprefab, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }

}
