using UnityEngine;

public class teleporter : MonoBehaviour
{
    [SerializeField] private GameObject _player1;
    [SerializeField] private GameObject _player2;
    [SerializeField] private GameObject _maincamera;
    [SerializeField] private float _toTeleportXPlayer;
    [SerializeField] private float _toTeleportYPlayer;
    [SerializeField] private float _toTeleportXCamera;
    [SerializeField] private float _toTeleportYCamera;

    private int playerCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerCount++;
        }
        if(playerCount == 2)
        {
            _player1.transform.position = new Vector3(_toTeleportXPlayer, _toTeleportYPlayer+1, 0);
            _player2.transform.position = new Vector3(_toTeleportXPlayer, _toTeleportYPlayer, 0);

            _maincamera.transform.position = new Vector3(_toTeleportXCamera, _toTeleportYCamera, -10f); ;
        }
     }
    private void OnCollisionExit2D(Collision2D collision)
    {
        playerCount--;
    }
}
