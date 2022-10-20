
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] 

public class MoveCube : MonoBehaviour
{
    private Rigidbody cubeRB;
    public static float speed , force = 50f;  

    void Start()
    {
        speed = 5f;
        cubeRB = GetComponent<Rigidbody>();
        speed = 5f;

    }

    private void FixedUpdate()
    {
        speed = ButtonUI.speedSpeed;
        cubeRB.MovePosition(transform.position - transform.forward * speed * Time.fixedDeltaTime);
    }
}
