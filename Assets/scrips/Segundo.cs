using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segundo : MonoBehaviour
{
    [SerializeField] private int firstNumber, lasNumber, loop;
    // Start is called before the first frame update
    void Start()
    {
        switch(loop)
        {
            case 1:
                UsingForLoop();
                break;
            case 2:
                UsingWhileLoop();
                break;
            default:
                Debug.Log("Numeros invalidos");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UsingForLoop()
    {
        for (int i = firstNumber; i <lasNumber; i++)
        {
            Debug.Log(i);
            if (i == (int)Mathf.Lerp(firstNumber, lasNumber, 0.5f)) ;
            {
                Debug.Log("mitad del camino");
            }
        }
        Debug.Log("Terminado con un ciclo for");
    }

    void UsingWhileLoop()
    {
        int _index = firstNumber;
        while (_index <= lasNumber)
        {
            Debug.Log(_index);
            if (_index == (int)Mathf.Lerp(firstNumber, lasNumber, 0.5f))
            {
                Debug.Log("Mitad del camino");
            }
            _index++;
        }
        Debug.Log("Terminado con un ciclo while");
    }
}
