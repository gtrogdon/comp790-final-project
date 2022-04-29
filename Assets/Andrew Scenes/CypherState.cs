using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CypherState : MonoBehaviour
{
    public char[] code = new char[5] { 'D', 'E', 'A', 'T', 'H' };
    public char[] stored = new char[5];
    public bool solved=false;

    public void putChar(char value, int index)
    {
        stored[index] = value;

        bool isSolved = true;
        for(int i = 0; i < 5; i++)
        {
            isSolved = isSolved && (code[i] == stored[i]);
        }

        solved = isSolved;
    }

}
