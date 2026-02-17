using UnityEngine;

public class Player1Input : MonoBehaviour
{
    [SerializeField] private float _jumpPower = 10;
    [SerializeField] private float _walkSpeed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float X = 0;
        float Y = 0;
        if (Input.GetKey(KeyCode.W))
        {
            print("ik heb W ingedrukt");
            transform.Translate(Vector3.up * _jumpPower * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            print("Ik heb A ingedrukt");
            Vector3 position = new Vector3(X = (_walkSpeed), Y, 0);
            transform.position -= position;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Ik heb D ingedrukt");
            Vector3 position = new Vector3(X = (_walkSpeed), Y, 0);
            transform.position += position;
        }
    }
}
