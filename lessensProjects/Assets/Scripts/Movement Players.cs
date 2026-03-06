using UnityEngine;

public class MovementPlayers : MonoBehaviour
{
    [SerializeField] private float _jumpPower = 3f;
    [SerializeField] private float _walkSpeed = 3f;
    [SerializeField] private Player1Input _player1Input;
    [SerializeField] private Player2Input _player2Input;

    private void Start()
    {
        _player1Input.OnPlayerInputRecieve.AddListener(MovePlayerSideWays);
        _player2Input.OnPlayerInputRecieve.AddListener(MovePlayerSideWays);
    }
    public void MovePlayerSideWays(Vector2 direction)
    {
        transform.position += new Vector3(direction.x, direction.y, 0) * _walkSpeed * Time.deltaTime;
    }
    public void MovePlayerUp(Vector2 direction)
    {
        transform.position += new Vector3(direction.x, direction.y, 0) * _jumpPower * Time.deltaTime;
    }

}
