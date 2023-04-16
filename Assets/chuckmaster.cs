using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chuckmaster : MonoBehaviour
{
    public GameObject cmaster;
    public SpriteRenderer cmasterbody;
    public Sprite[] pic;


    // Start is called before the first frame update
    void Start()
    {
        cmasterbody.sprite =pic[1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
