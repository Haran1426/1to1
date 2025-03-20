using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(-4.3f, transform.position.y, transform.position.z);

        if (Input.GetKeyDown(KeyCode.R)) // R Ű�� ������ y = 1.5
        {
            transform.position = new Vector3(transform.position.x, 1.5f, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.G)) // G Ű�� ������ y = 0
        {
            transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.B)) // B Ű�� ������ y = -1.5
        {
            transform.position = new Vector3(transform.position.x, -1.5f, transform.position.z);
        }
       
    }
}
