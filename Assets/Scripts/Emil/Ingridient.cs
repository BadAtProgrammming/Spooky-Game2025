using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingridient : MonoBehaviour
{
    public int[] numbers = new int[5];
    void Start()
    {
        List<int> list = new List<int>();
        for (int b = 1; b < 6; b++)
        {
            list.Add(b);
        }
        for (int i = 0; i < 5; i++)
        {
            int num = Random.Range(0, list.Count - 1);
            numbers[i] = list[num];
            list.RemoveAt(num);
        }
        print(numbers[0]);
        print(numbers[1]);
        print(numbers[2]);
        print(numbers[3]);
        print(numbers[4]);
    }
}
