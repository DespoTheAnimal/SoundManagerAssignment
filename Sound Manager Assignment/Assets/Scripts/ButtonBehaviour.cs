using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonBehaviour : MonoBehaviour
{
    public GameObject[] objectsToInstantiate;

    private int _randomNumber;
    private int _minNum = 0;
    private int _maxNum = 3;
    private bool buttonPressed;
    [SerializeField]
    private Button _button;
    // Start is called before the first frame update
    void Start()
    {
        _button.onClick.AddListener(SpawnBlock);
    }

    private void SpawnBlock()
    {
        if (buttonPressed != true)
            buttonPressed = true;
        else
        {
            buttonPressed = false;
        }
    }

    private void OnClick()
    {
        if (buttonPressed == true)
        {
            _randomNumber = Random.Range(_minNum, _maxNum);

            switch (_randomNumber)
            {
                case 0: Instantiate(objectsToInstantiate[0], (Vector3.up), Quaternion.identity); Debug.Log("Worked"); break;

                case 1: Instantiate(objectsToInstantiate[1], (Vector3.zero), Quaternion.identity); Debug.Log("Worked"); break;

                case 2: Instantiate(objectsToInstantiate[2], (Vector3.down), Quaternion.identity); Debug.Log("Worked"); break;
            }
            buttonPressed = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        OnClick();
    }
}
