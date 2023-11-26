using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private Enemy _enemy;

    private WaitForSeconds _waitForSeconds;
    private int _delay = 3;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private void Awake()
    {
        _waitForSeconds = new WaitForSeconds(_delay);
    }

    private IEnumerator Spawn()
    {
        while (enabled)
        {
            Transform point = _points[Random.Range(0, _points.Length)];
            Enemy newEnemy = Instantiate(_enemy, point.position, Quaternion.identity);
            newEnemy.SetDirection(Vector3.up);

            yield return _waitForSeconds;
        }
    }
}
