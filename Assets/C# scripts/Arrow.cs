using UnityEngine;

public class Arrow : MonoBehaviour
{
   public ParticleSystem _particleSystem;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      _particleSystem= GameObject.Find("Particle System").GetComponent<ParticleSystem>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        _particleSystem.transform.position = other.transform.position;
        _particleSystem.Play();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
