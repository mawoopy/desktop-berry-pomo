using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushGrowth : MonoBehaviour
{
    public GameObject bush0;
    public GameObject bush1;
    public GameObject bush2;
    public GameObject bush3;
    public GameObject bush4;
    public GameObject bush5;
    public GameObject bush6;
    public GameObject bush7;
    public GameObject berries;

    void Start()
    {
        bush0.GetComponent<SpriteRenderer>().enabled = true;
        bush1.GetComponent<SpriteRenderer>().enabled = false;
        bush2.GetComponent<SpriteRenderer>().enabled = false;
        bush3.GetComponent<SpriteRenderer>().enabled = false;
        bush4.GetComponent<SpriteRenderer>().enabled = false;
        bush5.GetComponent<SpriteRenderer>().enabled = false;
        bush6.GetComponent<SpriteRenderer>().enabled = false;
        bush7.GetComponent<SpriteRenderer>().enabled = false;
        berries.GetComponent<SpriteRenderer>().enabled = false;
    }

    void Growth1()
    {
        bush0.GetComponent<SpriteRenderer>().enabled = false;
        bush1.GetComponent<SpriteRenderer>().enabled = true;
    }

    void Growth2()
    {
        bush1.GetComponent<SpriteRenderer>().enabled = false;
        bush2.GetComponent<SpriteRenderer>().enabled = true;
    }

    void Growth3()
    {
        bush2.GetComponent<SpriteRenderer>().enabled = false;
        bush3.GetComponent<SpriteRenderer>().enabled = true;
    }
    void Growth4()
    {
        bush3.GetComponent<SpriteRenderer>().enabled = false;
        bush4.GetComponent<SpriteRenderer>().enabled = true;
    }
    void Growth5()
    {
        bush4.GetComponent<SpriteRenderer>().enabled = false;
        bush5.GetComponent<SpriteRenderer>().enabled = true;
    }
    void Growth6()
    {
        bush5.GetComponent<SpriteRenderer>().enabled = false;
        bush6.GetComponent<SpriteRenderer>().enabled = true;
    }
    void Growth7()
    {
        bush6.GetComponent<SpriteRenderer>().enabled = false;
        bush7.GetComponent<SpriteRenderer>().enabled = true;
    }
    void GrowBerries()
    {
        berries.GetComponent<SpriteRenderer>().enabled = true;
    }
    void HarvestBerries()
    {
        berries.GetComponent<SpriteRenderer>().enabled = false;
    }
}

