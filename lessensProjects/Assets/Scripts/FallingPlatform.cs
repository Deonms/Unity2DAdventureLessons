using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    [SerializeField] private string _playerTag = "Player";
    [SerializeField] private float _fallspeed = 10f;
    [SerializeField] private GameObject _platformToFall;
    [SerializeField] private float _toRespawnX;
    [SerializeField] private float _toRespawnY;
    [SerializeField] private float _dieFromY;

    private bool _isFalling = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_isFalling)
        {
            transform.position += new Vector3(0, -1, 0) * _fallspeed * Time.deltaTime;

            // Respawn platform once it falls past the die threshold
            if (transform.position.y < _dieFromY)
            {
                transform.DetachChildren();
                transform.position = new Vector3(_toRespawnX, _toRespawnY, transform.position.z);
                _isFalling = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(_playerTag))
        {
            collision.transform.SetParent(transform); //set de speler een child als ze op de moving platform staan
        }
        if (collision.gameObject.CompareTag(_playerTag))
        {
            _isFalling = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(_playerTag))
        {
            collision.transform.SetParent(null); //haalt de speler weg van child van de moving platform omdat ze er niet meer op staan
        }
    }
    
        

}
