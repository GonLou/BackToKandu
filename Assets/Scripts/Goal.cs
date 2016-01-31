using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour
{

    public AudioSource drumSound;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        playSoundThenLoad();

        if (other.gameObject.CompareTag("Player"))
        {
            Application.LoadLevel(0);
        }
    }

    IEnumerator playSoundThenLoad()
    {
        drumSound.Play();
        yield return new WaitForSeconds(drumSound.clip.length);
    }

}
