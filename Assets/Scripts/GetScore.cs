using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    public int score;
    public float speed;

    public AudioClip sound;
    public GameObject soundPrefab;

    private PlayerAvoid player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerAvoid>();
    }

    
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);

        if(transform.position.y < -4.5f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            player.score += score;
            GameObject soundPlay = Instantiate(soundPrefab) as GameObject;
            soundPlay.GetComponent<AudioSource>().clip = sound;
            soundPlay.GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
        }
    }
}
