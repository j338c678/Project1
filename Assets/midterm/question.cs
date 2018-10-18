using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question : MonoBehaviour {

    //private points ps;

    void Awake()
    {
        
    }

    
    List<string> questions = new List<string>() { "A is member of object B", "B is member of Object A", "Product of A and B", "None of these" };
    List<string> questions1 = new List<string>() { "Operator-&", "Operator-||", "Operator-&&", "Operator +" };
    List<string> questions2 = new List<string>() { "A Slash (/)", "A Fullstop(.)", "A Comma (,)", "A Semicolon (;)" };
    List<string> questions3 = new List<string>() { "<fiostream>", "<ifstream>", "<ofstream>", "<fstream>" };
    List<string> questions4 = new List<string>() { "thrown", "threw", "throw", "throws" };
    public Dropdown dropdown;
    public Dropdown dropdown1;
    public Dropdown dropdown2;
    public Dropdown dropdown3;
    public Dropdown dropdown4;

    // Use this for initialization
    void Start () {
        questionlist();
        questionlist1();
        questionlist2();
        questionlist3();
        questionlist4();
    }

    void questionlist () {
        
        dropdown.AddOptions(questions);
        
	}

    void questionlist2() {
        
        dropdown2.AddOptions(questions2);
        
	}

    void questionlist3()
    {

        dropdown3.AddOptions(questions3);

    }

    void questionlist4()
    {

        dropdown4.AddOptions(questions4);;

    }


    void questionlist1()
    {
        dropdown1.AddOptions(questions1);
    }

    public Text Question;
    public Text Question1;
    public Text Question2;
    public Text Question3;
    public Text Question4;

    public static int point;
    
    public void DropdownIndex(int index)
    {
        Question.text = questions[index]; 
        if(index==1)
        {
            point += 20;
            Question.text = point.ToString();
        }
        else
        {
            
            Question.text = point.ToString();
        }
    }

    public void DropdownIndex1(int index)
    {
        Question1.text = questions1[index];
        if (index == 2)
        {
            point += 20;
            Question1.text = point.ToString();
        }
        else
        {
            
            Question1.text = point.ToString();
        }
    }

    public void DropdownIndex2(int index)
    {
        Question2.text = questions2[index];
        if (index == 3)
        {
            point+= 20;
            Question2.text = point.ToString();
        }
        else
        {

            Question2.text = point.ToString();
        }
    }

    public void DropdownIndex3(int index)
    {
        Question3.text = questions3[index];
        if (index == 3)
        {
            point += 20;
            Question3.text = point.ToString();
        }
        else
        {

            Question3.text = point.ToString();
        }
    }

    public void DropdownIndex4(int index)
    {
        Question4.text = questions4[index];
        if (index == 2)
        {
            point += 20;
            Question4.text = point.ToString();
        }
        else
        {

            Question4.text = point.ToString();
        }
    }
}

