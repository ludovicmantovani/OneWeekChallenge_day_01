using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpotLight : MonoBehaviour
{
    public float speed = 10f;
    public float range = 4f;

    [SerializeField] float horizontal = 0f;
    [SerializeField] float vertical = 0f;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Mouse X");
        vertical = Input.GetAxis("Mouse Y");

        // Déplacement horizontal de la Spot Light
        transform.position += new Vector3(horizontal * speed * Time.deltaTime, 0f, 0f) * -1;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -range, range), transform.position.y, transform.position.z);

        // Déplacement vertical de la Spot Light
        transform.position += new Vector3(0f, vertical * speed * Time.deltaTime, 0f);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -range, range), transform.position.z);
    }
}
