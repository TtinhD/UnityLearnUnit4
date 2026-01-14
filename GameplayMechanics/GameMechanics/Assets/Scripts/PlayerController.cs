using System.Reflection;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody  playerRb;
    private GameObject localPoint;
    public float speed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        localPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");

        playerRb.AddForce(localPoint.transform.forward * forwardInput * speed);
    }
}
