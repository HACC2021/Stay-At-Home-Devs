using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class User : MonoBehaviour
{

    public Text t;
    private UserData userData = UserData.Instance();

    // Start is called before the first frame update
    void Start()
    {
        t.text = "Name: " + userData.getName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
