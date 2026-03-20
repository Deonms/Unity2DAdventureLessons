using UnityEngine;

public class teleporter : MonoBehaviour
{
    [SerializeField] private GameObject _player1; //om de gameobject speler 1 te krijgen
    [SerializeField] private GameObject _player2; //om de gameobject speler 2 te krijgen
    [SerializeField] private GameObject _maincamera; //om de gameobject Camera te krijgen
    //om te kijken waar naartoe de spelers en camera geteleporteert moet worden
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
        if (collision.gameObject.tag == "Player") //check of er een speler erop komt zo ja dan word playercount +1 gedaan
        {
            playerCount++;
        }
        if(playerCount == 2) //checkt of er 2 spelers erop staan zo ja dan worden ze pas geteleporteert
        {
            _player1.transform.position = new Vector3(_toTeleportXPlayer, _toTeleportYPlayer+1, 0);
            _player2.transform.position = new Vector3(_toTeleportXPlayer, _toTeleportYPlayer, 0);

            _maincamera.transform.position = new Vector3(_toTeleportXCamera, _toTeleportYCamera, -10f); ;
        }
     }
    private void OnCollisionExit2D(Collision2D collision) //check of er een speler eraf gaat zo ja dan word playercount -1 gedaan
    {
        playerCount--;
    }
}
