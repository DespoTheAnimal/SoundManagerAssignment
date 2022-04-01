using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySoundOnStart : MonoBehaviour
{
    private int _randomNumber;

    [SerializeField]
    private GameObject _oracle1;
    [SerializeField]
    private GameObject _oracle2;
    [SerializeField]
    private GameObject _oracle3;

    private int _minNum = 0;
    private int _maxNum = 3;
    [SerializeField]
    private Button _button;
    [SerializeField]
    private AudioClip _clip;
    // Start is called before the first frame update
    void Start()
    {
        _button.onClick.AddListener(SpawnCube());
        SoundManager.Instance.PlaySound(_clip);
    }
    private void SpawnCube()
    {
        _randomNumber = Random.Range(_minNum, _maxNum);

        switch (_randomNumber)
        {
            case 0: Instantiate(_oracle1, (Vector3.up), Quaternion.identity); break;

            case 1: Instantiate(_oracle2, (Vector3.zero), Quaternion.identity); break;

            case 2: Instantiate(_oracle3, (Vector3.up), Quaternion.identity); break;
        }
    }
}
