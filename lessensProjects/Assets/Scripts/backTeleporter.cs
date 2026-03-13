using UnityEngine;

public class backTeleporter : MonoBehaviour
{
    [SerializeField] private string _playertag = "Player";
    [SerializeField] float _respawnX;
    [SerializeField] float _respawnY;
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
        if (collision.gameObject.CompareTag(_playertag))
        {
            Vector3 position = new Vector3(_respawnX, _respawnY, -1f);
            collision.gameObject.transform.position = position;
        }

    }
}
