using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject _sampleCubePrefab;
    GameObject[] _sampleCube = new GameObject[512];
    public float _maxScale;
    // Start is called before the first frame update
    void Start()
    {
        for(int index=0;index<512;index++)
        {
            GameObject _instance = (GameObject)Instantiate(_sampleCubePrefab);
            _instance.transform.position = this.transform.position;
            _instance.transform.parent = this.transform;
            _instance.name = "SampleCube" + index;
            this.transform.eulerAngles = new Vector3(0, -0.703125f * index, 0);
            _instance.transform.position = Vector3.forward * 100;
            _sampleCube[index] = _instance;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int index=0;index<512;index++)
        {
            if(_sampleCube!=null)
            {
                _sampleCube[index].transform.localScale = new Vector3(1, (AudioPeer._samples[index]*_maxScale)+1, 1);
            }
        }
    }
}
