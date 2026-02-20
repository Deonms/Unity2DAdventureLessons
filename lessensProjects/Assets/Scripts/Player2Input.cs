using UnityEngine;

public class Player2Input : MonoBehaviour
{
    [SerializeField] private float _jumpPower = 10;
    [SerializeField] private float _walkSpeed = 10;
    [SerializeField] private MovementPlayers _playerMovementSideways;
    [SerializeField] private MovementPlayers _playerMovementUp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float X = 0;
        float Y = 0;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            print("ik heb Boven Arrow ingedrukt");
            _playerMovementUp.MovePlayerSideWays(Vector2.up);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            print("Ik heb Linker Arrow ingedrukt");
            _playerMovementSideways.MovePlayerSideWays(Vector2.left);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            print("Ik heb Rechter Arrow ingedrukt");
            _playerMovementSideways.MovePlayerSideWays(Vector2.right);
        }
    }
}
