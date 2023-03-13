using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpotLight : MonoBehaviour
{
    public float speed = 10f;
    public float rangeX = 10f;
    public float rangeY = 4f;

    [SerializeField] float horizontal = 0f;
    [SerializeField] float vertical = 0f;
    [SerializeField] bool canMove = true;

    [SerializeField] float spotLightZpos = 10f;

    private void Start()
    {
        transform.position.Set(
            0,
            0,
            spotLightZpos);
    }

    void Update()
    {
        if (canMove)
            Locomotion();
    }


    private void Locomotion()
    {
        //horizontal = Input.GetAxis("Mouse X");
        horizontal = Input.GetAxis("Horizontal");
        //vertical = Input.GetAxis("Mouse Y");
        vertical = Input.GetAxis("Vertical");

        // Déplacement horizontal de la Spot Light
        transform.position += new Vector3(horizontal * speed * Time.deltaTime, 0f, 0f) * -1;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -rangeX, rangeX), transform.position.y, transform.position.z);

        // Déplacement vertical de la Spot Light
        transform.position += new Vector3(0f, vertical * speed * Time.deltaTime, 0f);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -rangeY, rangeY), transform.position.z);
    }
}
