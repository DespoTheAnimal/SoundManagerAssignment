using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySoundOnStart : MonoBehaviour
{
    [SerializeField]
    private AudioClip _clip;
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.Instance.PlaySound(_clip);
        Destroy(gameObject, 3f);
    }
}
