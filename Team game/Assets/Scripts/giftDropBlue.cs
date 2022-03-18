using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class giftDropBlue : MonoBehaviour
{
    //public Text ti;
    public GameObject ball;
    int open = 1;//switch

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private float update;
    void Update()
    {
        //ti.text = "" + (int)Time.time;
        update += Time.deltaTime;
        // if((int)Time.time == 10 & open == 1)//every 5 seconds execute 1 times (create gift)
        if (update > 11.0f & open == 1)//every 5 seconds execute 1 times (create gift)
        {
            open = 2;//only execute 1 time
            GameObject a = Instantiate(ball, new Vector3(10, 35, 0), Quaternion.identity);
            Debug.Log(open);
        }
    }

    /*
    public GameObject[] gos;
    public void GenGift()
    {
        Vector3 pos = transform.position;
        Instantiate(gos[Random.Range(0, gos.Length)], pos, Quaternion.identity);
    }
    */

}
