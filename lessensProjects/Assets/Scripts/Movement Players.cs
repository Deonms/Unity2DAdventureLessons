using UnityEngine;

public class MovementPlayers : MonoBehaviour
{
    [SerializeField] private float _jumpPower = 10;
    [SerializeField] private float _walkSpeed = 10;
    public void MovePlayerSideWays(Vector2 direction)
    {
        transform.position += new Vector3(direction.x, direction.y, 0) * _walkSpeed * Time.deltaTime;
    }
    public void MovePlayerUp(Vector2 direction)
    {
        transform.position += new Vector3(direction.x, direction.y, 0) * _jumpPower * Time.deltaTime;
    }
}
