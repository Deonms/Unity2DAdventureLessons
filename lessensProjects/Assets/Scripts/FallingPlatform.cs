using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    [SerializeField] private string _playerTag = "Player";
    [SerializeField] private float _speed = 2f;
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
        if (collision.gameObject.CompareTag(_playerTag))
        {
            collision.transform.SetParent(transform); //set de speler een child als ze op de moving platform staan
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
