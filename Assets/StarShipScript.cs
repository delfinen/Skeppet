using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarShipScript : MonoBehaviour
{

    [Range(-720, 720)]
    public float rotationspeed;
    public SpriteRenderer rend;
    public float timer;
    public float timestart;


    // Use this for initialization
    void Start()
    {
        timestart = 0;
        timer = timestart;
    }

    // Update is called once per frame
    void Update()
    {     // När man klickar på tangenten A så kommer något att hända
        if (Input.GetKey(KeyCode.A))
        {    // första kommandot gör så att när knappen a trycks ner så svänger den åt höger och det andra i mosvingarna gör så att när man trycker a blir skeppet grönt
            transform.Rotate(0f, 0f, rotationspeed * Time.deltaTime);
            rend.color = new Color(0f, 1f, 0f);
        }


        // När man klickar påc tangenten D så kommer något att hända
        if (Input.GetKey(KeyCode.D))
        { // första kommandot gör så att när knappen a trycks ner så svänger den åt vänster och det andra i mosvingarna gör så att när man trycker a blir skeppet blå
            transform.Rotate(0f, 0f, -rotationspeed * Time.deltaTime);
            rend.color = new Color(0f, 0f, 1f);
        }
        // När man klickar påc tangenten s så kommer något att hända

        if (Input.GetKey(KeyCode.S))
        {   // Den tar skeppets fart och delar den vilket gör så att farten saktas ner
            transform.Translate(-5f / 2 * Time.deltaTime, 0, 0, Space.Self);
        }


        // ger skeppet fart så den åker framåt
        transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);
        // den gör så att timern ökar med 1 sec och det under printar ut timer när det händer
        timer = timer + 1 * Time.deltaTime;
        print("Timer" + timer);



    }


}
