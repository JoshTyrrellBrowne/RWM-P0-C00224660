using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Name: DecrementIfLessThanFirst
//Description: Minus 1 from any number which is less than the first number in the array. Leave all other numbers unchanged.

public class DecrementIfLessThanFirstFilter : MonoBehaviour
{

    public static int[] decrementIfLessThanFirst(int[] xs)
    {
        int first = xs[0];
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            if (xs[i] < first)
            {
                result[i] = xs[i] - 1;
            }
            else
            {
                result[i] = xs[i];
            }
        }
        return result;
    }
}
