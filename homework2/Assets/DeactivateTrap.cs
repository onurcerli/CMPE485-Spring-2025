using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateTrap : MonoBehaviour
{
    public GameObject trapinactiveprefab;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5);
        Instantiate(trapinactiveprefab, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
