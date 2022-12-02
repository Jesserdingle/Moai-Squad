
using UnityEngine;

public class ruchgracza : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float szybkoscRuchu = 5f;
    public float SkokMoc = 1f;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var ruch = Input.GetAxis("Horizontal");
        transform.position += new Vector3(ruch, 0, 0) * Time.deltaTime * szybkoscRuchu;
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, SkokMoc), ForceMode2D.Impulse);
        }

    }
}
