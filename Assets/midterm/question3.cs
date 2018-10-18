using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question3 : MonoBehaviour
{
    List<string> questions = new List<string>() { "<fiostream>", "<ifstream>", "<ofstream>", "<fstream>" };
    public Dropdown dropdown;

    // Use this for initialization
    void Start()
    {
        questionlist();
    }

    // Update is called once per frame
    //<fstream>
    void questionlist()
    {
        dropdown.AddOptions(questions);
    }
}
