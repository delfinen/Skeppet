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
        rotationspeed = 200;
    }

    // Update is called once per frame
    void Update()
    {     // När man klickar på tangenten A så kommer något att hända
        if (Input.GetKey(KeyCode.A))
        {    // första kommandot gör så att när knappen a trycks ner så svänger den åt höger och det andra i mosvingarna gör så att när man trycker a blir skeppet grönt

            transform.Rotate(0f, 0f, rotationspeed * Time.deltaTime);
            rend.color = new Color(0f, 1f, 0f);
            rotationspeed = 100;
            // gör så den svänge hälften av vad rotationspeed = med 

        }


        // När man klickar påc tangenten D så kommer något att hända
        if (Input.GetKey(KeyCode.D))
        { // första kommandot gör så att när knappen a trycks ner så svänger den åt vänster och det andra i mosvingarna gör så att när man trycker a blir skeppet blå

            transform.Rotate(0f, 0f, -rotationspeed * Time.deltaTime);
            rend.color = new Color(0f, 0f, 1f);
            rotationspeed = 200;
            // gär så skeppet svänger i farten 200 hundra när man klickar d
        }
        // När man klickar påc tangenten s så kommer något att hända

        if (Input.GetKey(KeyCode.S))
        {   // Den tar skeppets fart och delar den vilket gör så att farten saktas ner
            transform.Translate(-5f / 2 * Time.deltaTime, 0, 0, Space.Self);
        }


        // ger skeppet fart så den åker framåt
        transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);

        // gör så timern printar värdet varje sekund
        timer += Time.deltaTime;
        // printar varje sekund och gör så det står timer
        Debug.Log(string.Format("{0}", timer));

        // när man klickar space händer något
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // gör så att det bli en random färg mellan röd grön och blå
            rend.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));



        }





    }


}
