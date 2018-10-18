using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question1 : MonoBehaviour
{
    //public question qu;

    List<string> questions = new List<string>() { "Operator-&", "Operator-||", "Operator-&&", "Operator +" };
    public Dropdown dropdown;

    // Use this for initialization
    void Start()
    {
        questionlist();
    }

    // Update is called once per frame

    //Operator-&&
    void questionlist()
    {
        dropdown.AddOptions(questions);
    }

    public Text Question;
    
    public int score ;


    public void DropdownIndex(int index)
    {
        //score = qu.getscore();
        //Debug.Log(score);

        Question.text = questions[index];
        if (index == 2)
        {
            score +=20;
            Question.text = score.ToString();
        }
        else
        {
            score = 0;
            Question.text = score.ToString();
        }
    }
}
