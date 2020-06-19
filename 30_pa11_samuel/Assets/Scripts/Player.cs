using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public float speed;
    public float hp = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(0f, verticalInput, 0f);
        Vector3 clampedPosition = transform.position;
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, -4.1f, 4.1f);
        transform.position = clampedPosition;
    }
    void OnTriggerEnter(Collider other)
    {
        //destroy this bullet when it hit something


        if (other.tag == "Obstacle")
        {
            SceneManager.LoadScene("end");
            hp -= 1;

        }

    }


}
