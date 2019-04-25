using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    [SerializeField] private float speed = 10f;

    void Update() {
        transform.rotation *= Quaternion.Euler(0f, speed * Time.deltaTime, 0f);
    }
}
