using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip select, swordswing, termiteattack, termitedeath, magicshoot, collect, gameover, treelvlup, poisoncollect;
    static AudioSource audiosrc;
    // Start is called before the first frame update
    void Start()
    {
        select = Resources.Load<AudioClip>("select");
        swordswing = Resources.Load<AudioClip>("swordswing");
        magicshoot = Resources.Load<AudioClip>("magicshoot");
        collect = Resources.Load<AudioClip>("collect");
        gameover = Resources.Load<AudioClip>("gameover");
        treelvlup = Resources.Load<AudioClip>("treelvlup");
        poisoncollect = Resources.Load<AudioClip>("poisoncollect");
        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "select":
                audiosrc.PlayOneShot(select);
                break;
            case "swordswing":
                audiosrc.PlayOneShot(swordswing);
                break;
            case "magicshoot":
                audiosrc.PlayOneShot(magicshoot);
                break;
            case "collect":
                audiosrc.PlayOneShot(collect);
                break;
            case "treelvlup":
                audiosrc.PlayOneShot(treelvlup);
                break;
            case "gameover":
                audiosrc.PlayOneShot(gameover);
                break;
            case "poisoncollect":
                audiosrc.PlayOneShot(poisoncollect);
                break;
        }
    }
}
