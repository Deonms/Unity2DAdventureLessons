using UnityEngine;
using UnityEngine.Events;

public class Player1Input : MonoBehaviour
{
   
    public UnityEvent<Vector2> OnPlayerInputRecieve = new UnityEvent<Vector2>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            OnPlayerInputRecieve.Invoke(Vector2.up);
        }
        if (Input.GetKey(KeyCode.A))
        {
            OnPlayerInputRecieve.Invoke(Vector2.left);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            OnPlayerInputRecieve.Invoke(Vector2.right);
        }
    }
}
