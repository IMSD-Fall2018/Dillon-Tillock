using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayStory : MonoBehaviour
{

    public string[] words = new string[11];


    void Start()
    {
        string RandomStory = "";



        RandomStory += " Look over there it's a " + words[Random.Range(0, words.Length)] + " by your car.";

        RandomStory += " Hurry go get your " + words[Random.Range(0, words.Length)] + " and " + words[Random.Range(0, words.Length)] + " . ";

        RandomStory += " We can use those to " + words[Random.Range(0, words.Length)] + " and scare it off. ";

        RandomStory += " Oh is that " + words[Random.Range(0, words.Length)] + " coming to help us ";

        RandomStory += " Wait no " + words[Random.Range(0, words.Length)] + " is trying to hijack your car ";

        RandomStory += " We have to kill them all it's the only way to " + words[Random.Range(0, words.Length)] + " and save the car . ";

        RandomStory += " After all the madness " + words[Random.Range(0, words.Length)] + "  and " + words[Random.Range(0, words.Length)] + " stoped by with his car. ";

        RandomStory += " Realizing that the car they was trying to hijack wasn't there " + words[Random.Range(0, words.Length)] + " was used for no reason. ";

        RandomStory += " Feeling bad that they killed them for reason they went to turn themselves in";

        RandomStory += " On their way to the present " + words[Random.Range(0, words.Length)] + " convinced them to leave the city and stay on the run from all cops.  ";


        Debug.Log(RandomStory);
    }


}