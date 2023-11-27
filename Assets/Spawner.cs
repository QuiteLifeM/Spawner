using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Point[] _points;
    [SerializeField] private Enemy _enemy;

    private WaitForSeconds _waitForSeconds;
    private float _delay = 0.5f;

    private void Awake()
    {
        _waitForSeconds = new WaitForSeconds(_delay);
    }

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (enabled)
        {
            Point point = _points[Random.Range(0, _points.Length)];
            Enemy newEnemy = Instantiate(_enemy, point.transform.position, Quaternion.identity);
            Transform target = point.GetRandomTarget();

            newEnemy.SetDirection(target);

            yield return _waitForSeconds;
        }
    }
}
