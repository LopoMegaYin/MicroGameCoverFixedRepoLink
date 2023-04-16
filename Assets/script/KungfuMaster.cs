using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class KungfuMaster : MonoBehaviour
{
    public GameObject powermeter;
    public Image powermetermask;
    public float barChangeSpeed = 1;
    public float timer = 0f;
    float maxpowermetervalue = 100;
    float currentpowermetervalue;
    bool powerIsIncreasing;
    public GameObject cmaster;
    public SpriteRenderer cmasterbody;
    public Sprite[] pic;

    //bool powermeterON;
    // Start is called before the first frame update
    void Start()
    {

        currentpowermetervalue = 0;
        powerIsIncreasing = true;
        //powermeterON = true;
        timer += Time.deltaTime;
        cmasterbody.sprite = pic[0];


    }
    // Update is called once per frame
    void Update()
    {

        if (timer <= 10f)
        {

            if (powerIsIncreasing == true)
            {
                currentpowermetervalue += barChangeSpeed;
                float fill = currentpowermetervalue / maxpowermetervalue;
                powermetermask.fillAmount = fill;


                if (currentpowermetervalue >= maxpowermetervalue)
                {
                    currentpowermetervalue = 0;
                }


                if (Input.GetKeyDown("space"))
                {
                    //powermeterON = false;
                    barChangeSpeed = 0;
                    cmasterbody.sprite = pic[1];

                }

                if (timer > 10f)
                {
                    //powermeterON = false;
                    barChangeSpeed = 0;
                }
               
                if(barChangeSpeed == 0 && fill<0.92)
                    {
                        { StartCoroutine(CmbodyTimerF(0.5f)); }
                    }
                if (barChangeSpeed == 0 && fill >= 0.92)
                {
                    { StartCoroutine(CmbodyTimerS(0.5f)); }
                }
            }
        }
    }
    IEnumerator CmbodyTimerF(float delayf)
    {
       yield return new WaitForSecondsRealtime(delayf);
       cmasterbody.sprite = pic[2];
        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene("SampleScene");
        yield break;

    }
    IEnumerator CmbodyTimerS(float delay)
    {
        yield return new WaitForSecondsRealtime(delay);
        cmasterbody.sprite = pic[3];
        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene("SampleScene");
        yield break;
    }
}