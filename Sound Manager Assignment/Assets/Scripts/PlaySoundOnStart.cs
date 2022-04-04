using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySoundOnStart : MonoBehaviour
{
   /* [SerializeField]
    private GameObject _oracle1;
    [SerializeField]
    private GameObject _oracle2;
    [SerializeField]
    private GameObject _oracle3;*/

    [SerializeField]
    private AudioClip _clip;
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.Instance.PlaySound(_clip);
    }
   
    
    /* private void OnClick()
    {
        _randomNumber = Random.Range(_minNum, _maxNum);

        switch (_randomNumber)
        {
            case 0: Instantiate(_oracle1, (Vector3.up), Quaternion.identity); break;

            case 1: Instantiate(_oracle2, (Vector3.zero), Quaternion.identity); break;

            case 2: Instantiate(_oracle3, (Vector3.up), Quaternion.identity); break;
        }
    }*/



}
