using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _lifeTime = 2f;

    private void Update()
    {
        Destroy(gameObject, _lifeTime);
    }
}
