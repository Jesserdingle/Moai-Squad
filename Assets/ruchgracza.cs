
using UnityEngine;

public class ruchgracza : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float szybkoscRuchu = 5f;
    public float SkokMoc = 1f;
    public Animator animator;
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
        animator.SetFloat("predkosc", Mathf.Abs(ruch));

        if(ruch > 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, 1);
        }
        if(ruch < 0)
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, 1);
        }
    }
}
