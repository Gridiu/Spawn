using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    private const int SecondsNumber = 2;

    [SerializeField] private UnityEvent _reset;

    private void Start()
    {
        StartCoroutine(NoteTime());
    }

    private IEnumerator NoteTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(SecondsNumber);

            _reset.Invoke();
        }
    }
}
