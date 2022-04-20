using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _remainingLifeTime = 2f;

    private void Update()
    {
        _remainingLifeTime -= Time.deltaTime;

        if (_remainingLifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
