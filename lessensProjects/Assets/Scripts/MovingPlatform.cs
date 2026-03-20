using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private Transform[] _points;
    [SerializeField] private string _playerTag = "Player";

    private int i;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        transform.position = _points[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, _points[i].position) < 0.01f)
        {
            i++;
            if (i == _points.Length)
            {
                i = 0;
            }
        }
        //laat de platform bewegen naar de target platforms
        transform.position = Vector2.MoveTowards(transform.position, _points[i].position, _speed * Time.deltaTime);
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