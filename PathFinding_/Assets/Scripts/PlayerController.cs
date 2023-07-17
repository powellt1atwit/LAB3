using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private AudioSource music;
    private Rigidbody rb;
    public float speed;
    private Transform endtransform;


    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        
        endtransform = GameObject.FindGameObjectWithTag("End").transform;
        rb = GetComponent<Rigidbody>();
        speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

        float distance = Vector3.Distance(transform.position, endtransform.position);

        float normalizedDistance = Mathf.InverseLerp(2f, 50f, distance);
        float targetPitch = Mathf.Lerp(3f,0f,normalizedDistance);

        music.pitch = targetPitch;

    }
}
