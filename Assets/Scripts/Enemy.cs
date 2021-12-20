using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    // Variables
    [Header("Enemy Info")]
    [SerializeField] private float _speed = 4.0f;

    private Player _player;


    private void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
    }

    void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y <= -5)
        {
            float randomX = Random.Range(-8f, 8f);
            transform.position = new Vector3(randomX, 7, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();

            if(player != null)
            {
                player.Damage();
            }

            Destroy(this.gameObject);
        }

        if(other.tag == "Laser")
        {
            Destroy(other.gameObject);
            
            if (_player != null)
            {
                _player.AddScore(10);
            }
            
            Destroy(this.gameObject);
        }
    }
}