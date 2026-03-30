using UnityEngine;
using UnityEngine.Events;

public class Player2Input : MonoBehaviour
{
     public UnityEvent<Vector2> OnPlayerInputRecieve = new UnityEvent<Vector2>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            OnPlayerInputRecieve.Invoke(Vector2.up);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            OnPlayerInputRecieve.Invoke(Vector2.left);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            OnPlayerInputRecieve.Invoke(Vector2.right);
        }
    }
}
