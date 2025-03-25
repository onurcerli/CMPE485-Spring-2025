using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeactivateTrap : MonoBehaviour
{
    public GameObject trapinactiveprefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Deactivate());
    }


    IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(5);
        Instantiate(trapinactiveprefab, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
