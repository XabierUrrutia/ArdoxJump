using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringManager : MonoBehaviour
{
    public GameObject[] rings;
    public Renderer[] ringsRenderer;
    public Material black, blue;
    int rand = 0;
    // Start is called before the first frame update

    public void Awake()
    {
        rand = Random.Range(0, rings.Length);
        ringsRenderer[rand].material = black;
        rings[rand].tag = "Enemy";

        rand = Random.Range(0, rings.Length);
        ringsRenderer[rand].material = black;
        rings[rand].tag = "Enemy";

        rand = Random.Range(0, rings.Length);
        ringsRenderer[rand].material = black;
        rings[rand].tag = "Enemy";


        rings[Random.Range(0, rings.Length)].SetActive(false);
        rings[Random.Range(0, rings.Length)].SetActive(false);
    }
}
