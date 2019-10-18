using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _platforms;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < _platforms.Length; i++)
        {
            Instantiate(_platforms[i], new Vector3(0, 0, i * 50), Quaternion.Euler(0, 0, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
