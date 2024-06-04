using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class MiProyecto : MonoBehaviour
{ 
public float numero1, numero2;
public float[] numeros;

private float[] pNumbers = { 4f, 2f, 6f, 4f, 5f };

void Start()
{
    Debug.Log("numero 1: " + numero1 +"numero 2: " + numero2);
    Debug.Log("Suma: " + Add(numero1, +numero2));
    float _Multiolicacion = Multiply(numero1, numero2);
    Debug.Log(" _Multiolicacion: " + _Multiolicacion);
    Debug.Log("La suma del arreglo publico es: " + Summation(numeros));
    Debug.Log("La suma del arreglo publico es: " + Summation(pNumbers));
} 

float Add(float numero1, float numero2)
{
    return numero1 + numero2;
}

float Multiply(float numero1, float numero2)
{
    return numero1 * numero2;
}

float Summation(float[] array)
{
    float _sumation = 0f;
    for (int i = 0; i < array.Length; i++) 
{ 
    _sumation += array[i];
}/*
    foreach (float _number in array)
    {
        _sumation += _number;
    }*/
    return _sumation;
}
}