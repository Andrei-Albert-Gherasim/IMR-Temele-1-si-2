using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trow : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Test()
    {
      m_Rigidbody.AddForce(transform.forward * m_Thrust);
    }
}
