using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject _Sphere;

    private Rigidbody _Rigidbody;

    private float SPEED = 100.0f;
    private float X_A = 50.0f;
    
    void Start()
    {
        _Rigidbody = _Sphere.GetComponent<Rigidbody>();

    }


    public void MoveSphere()
    {
        
        _Rigidbody.isKinematic = false;
        _Rigidbody.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
        
        Vector3 movemnet = new Vector3(X_A, 0, 0);
        _Rigidbody.AddForce(movemnet * SPEED);
    }
    
    public void StopSphere()
    {
        _Rigidbody.velocity = Vector3.zero;
        _Sphere.transform.position = new Vector3(-10,0.5f,0); 
            
        
        _Rigidbody.isKinematic = true;
        _Rigidbody.collisionDetectionMode = CollisionDetectionMode.Discrete;
        
     
    }
    
    
    
}
