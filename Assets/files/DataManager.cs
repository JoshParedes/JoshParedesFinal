using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A singleton class for storing persistent data between scenes.
public class DataManager : MonoBehaviour
{
    public static DataManager me;

    //Data to hold
    public Vector3 lastSavePoint;
    public GameObject lifeBar = null;
    public int maxLives = 5;
    public int lifeCount = 3;

    void Awake()
    {
        if (me != null) //If an instance of this class already exists
        {
            Destroy(gameObject);  //Destroy this new instance
            return;// Exit the function
        }
        // end of new code

        me = this;  // Store this instance in a static variable
        DontDestroyOnLoad(gameObject);  //Do not destroy this object when the current scene ends and a new one begins
    }

}
