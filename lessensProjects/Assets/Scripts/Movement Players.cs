using UnityEngine;

public class MovementPlayers : MonoBehaviour
{
    [SerializeField] private float _jumpPower = 3f;
    [SerializeField] private float _walkSpeed = 3f;
    [SerializeField] private Player1Input _player1Input;
    [SerializeField] private Player2Input _player2Input;
    [SerializeField] private Player3Input _player3Input;
    [SerializeField] private Player4Input _player4Input;

    private void Start()
    {
        if(_player2Input == null)
        _player1Input.OnPlayerInputRecieve.AddListener(MovePlayerSideWays);
        if (_player1Input == null) ;
        _player2Input.OnPlayerInputRecieve.AddListener(MovePlayerSideWays);
        if (_player3Input == null) ;
        _player3Input.OnPlayerInputRecieve.AddListener(MovePlayerSideWays);
        if (_player4Input == null) ;
        _player4Input.OnPlayerInputRecieve.AddListener(MovePlayerSideWays);
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
