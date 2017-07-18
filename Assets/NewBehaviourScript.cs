using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public int Memes = 0;
    public float MemesPerSecond = 0;
    public int ClickPower = 1;
    public Text currentMemes;
    public Text memesPerSecond;

    public float timer;

    // Use this for initialization
    void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        currentMemes.text = Memes.ToString() + " Memes";
        memesPerSecond.text = MemesPerSecond.ToString() + " Memes Per Second";

        timer += 1 * Time.deltaTime;
        //Calculates Memes Per Second
        MemesPerSecond = Memes / timer;
        /*
        if (Input.GetKeyUp(KeyCode.Mouse0)) { 
        MemesPerSecond = 1; }
        */
       }
    
    public void GUI()
    {

         }
    public void Doge()
        //Code for adding 
    { Memes = Memes + ClickPower;
    }
    
}

















