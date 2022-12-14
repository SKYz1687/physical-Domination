using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physic : MonoBehaviour
{
    [SerializeField] float u = 0;
    [SerializeField] float v = 0;
    [SerializeField] float t = 0;
    [SerializeField] float s = 0;

    public float U { get => u; set => u = value; }
    public float V { get => v; set => v = value; }
    public float T { get => t; set => t = value; }
    public float S { get => s; set => s = value; }

    private float z = 0;

    private Vector3 Location;
    private bool isPhysicActive = false;
    private void Start()
    {
        Location = transform.position;
        z = transform.position.x;
    }
    private void Update()
    {
        if (isPhysicActive)
        {
            T += Time.deltaTime;
            S = (U + V) / 2.0f * T;
            Location.x = z + S;
            transform.position = Location;
            Debug.Log(S);
            if (T >= 5)
            {
                this.enabled = false;
            }
        }
    }
    public void Activephysic()
    {
        isPhysicActive = true;
    }
}
