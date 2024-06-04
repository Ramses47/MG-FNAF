using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejeercicio5 : MonoBehaviour
{
    
    [SerializeField] private float timeToBegin;
    [SerializeField] private GameObject cube;

    void Start()
    {
        StartCoroutine(Begin());
    }

    // Update is called once per frame
    IEnumerator Begin()
    {
        Debug.Log("Empezando en: " + timeToBegin + "segundos");
        yield return new WaitForSeconds(timeToBegin);
        StartCoroutine(Appear());
    }

    IEnumerator Appear()
    {
        for(float _alpha = 0f; _alpha <= 1f; _alpha += 1f * Time.deltaTime)
        {
            Color _c = cube.GetComponent<Renderer>().material.color;
            _c.a = _alpha;
            cube.GetComponent<Renderer>().material.color = _c;
            yield return null;
        }
        OnAppear.Invoke();
    }
}
