﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyForward : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
