using UnityEngine;
using UnityEngine.Events;

public class Player4Input : MonoBehaviour
{
    public UnityEvent<Vector2> OnPlayerInputRecieve = new UnityEvent<Vector2>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float X = 0;
        float Y = 0;
        if (Input.GetKey(KeyCode.U))
        {
            OnPlayerInputRecieve.Invoke(Vector2.up);
        }
        if (Input.GetKey(KeyCode.H))
        {
            OnPlayerInputRecieve.Invoke(Vector2.left);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            OnPlayerInputRecieve.Invoke(Vector2.right);
        }
    }
}
