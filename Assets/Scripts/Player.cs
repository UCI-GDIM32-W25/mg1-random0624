using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        if (_playerTransform == null)
        {
            _playerTransform = transform;
        }

        // Initialize seed counts
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        // Player movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, vertical, 0) * _speed * Time.deltaTime;
        _playerTransform.Translate(movement, Space.World);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        // Check if the player has seeds left to plant
        if (_numSeedsLeft > 0)
        {
            Instantiate(_plantPrefab, _playerTransform.position + _playerTransform.forward, Quaternion.identity);
            _numSeedsLeft--;
            _numSeedsPlanted++;
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }
    }
}
