using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    public void SetDirection(Vector3 direction)
    {
        StartCoroutine(Move(direction));
    }

    private IEnumerator Move(Vector3 direction)
    {
        while (enabled)
        {
            transform.Translate(direction * _speed * Time.deltaTime);

            yield return null;
        }
    }
}
