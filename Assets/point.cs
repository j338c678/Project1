
﻿//reference: https://blog.csdn.net/peanutdo1t/article/details/79706261; Author: PeanutDo1t
// EECS448 Project3: TicTakToe - Xinyun Yu
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToe : MonoBehaviour
{
    private int[,] block = new int[3, 3];
    private int player = 1;
    // The computer will be -1

    // Use this for initialization
    void Start()
    {
        player = 1;
        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                block[i, j] = 0;
            }
        }
    }

    // Checking for the game result:
    int check()
    {
        // winning case:horizontal
        for (int i = 0; i < 3; ++i)
        {
            if ((block[i, 0] != 0) && (block[i, 0] == block[i, 1]) && (block[i, 1] == block[i, 2]))
            {
                return block[i, 0];
            }
        }

        // winning case:vertical
        for (int j = 0; j < 3; ++j)
        {
            if ((block[0, j] != 0) && (block[0, j] == block[1, j]) && (block[1, j] == block[2, j]))
            {
                return block[0, j];
            }
        }

        // winning case: diagonal
        if ((block[1, 1] != 0) &&
            (block[0, 0] == block[1, 1]) && (block[1, 1] == block[2, 2]) ||
            (block[0, 2] == block[1, 1]) && (block[1, 1] == block[2, 0]))
        {
            return block[1, 1];
        }

        // checking game status: 0 means game is still on
        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                if (block[i, j] == 0)
                {
                    return 0;
                }
            }
        }

        // Draw:
        return 2;

    }

    void OnGUI()
    {
        GUIStyle fontStyle = new GUIStyle();
        fontStyle.normal.background = null;
        fontStyle.normal.textColor = new Color(1, 1, 0);
        fontStyle.fontSize = 40;

        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                if (block[i, j] == 1)
                {
                    GUI.Button(new Rect(300 + i * 100, 100 + j * 100, 100, 100), "O");
                    //public Button button1;
                }
                if (block[i, j] == -1)
                {
                    GUI.Button(new Rect(300 + i * 100, 100 + j * 100, 100, 100), "X");
                }
                if (GUI.Button(new Rect(300 + i * 100, 100 + j * 100, 100, 100), ""))
                {
                    if (check() == 0)
                    {
                        if (player == 1)
                        {
                            block[i, j] = 1;
                        }
                        else
                        {
                            block[i, j] = -1;
                        }
                        player = -player;
                    }
                }
            }
        }

        if ((player == -1) && (check() == 0))
        {
            int ri = (int)Random.Range(0, 3);
            int rj = (int)Random.Range(0, 3); //Random 方程左闭右开

            bool left = false;
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    if (block[i, j] == 0)
                    {
                        left = true;
                    }
                }
            }

            while ((block[ri, rj] != 0) && (left == true))
            {
                ri = (int)Random.Range(0, 3);
                rj = (int)Random.Range(0, 3);
            }

            if (block[ri, rj] == 0)
            {
                block[ri, rj] = -1;
            }

            player = -player;
        }

        //GUI.Label(new Rect(100, 185, 100, 100), "Result:");
        if (check() == -1)
        {
            GUI.Label(new Rect(65, 185, 200, 200), "You lose!", fontStyle);
        }
        else if (check() == 1)
        {
            GUI.Label(new Rect(65, 185, 200, 200), "You win!", fontStyle);
        }
        else if (check() == 2)
        {
            GUI.Label(new Rect(65, 185, 200, 200), "Draw!", fontStyle);
        }
    }




}