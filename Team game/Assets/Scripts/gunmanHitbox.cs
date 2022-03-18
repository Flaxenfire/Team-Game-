using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunmanHitbox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait1Second());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator Wait1Second()
    {
        yield return new WaitForSeconds(1f);
        DestroyObject(gameObject);
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.layer == 3)
        {
            DestroyObject(gameObject);
        }


    }
}
