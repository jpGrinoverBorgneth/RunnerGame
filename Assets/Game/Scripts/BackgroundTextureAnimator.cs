using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTextureAnimator : MonoBehaviour
{
    private Material _material;
    private Vector2 _offset;
    // Start is called before the first frame update
    void Start()
    {
        _material = gameObject.GetComponent<Renderer>().material;
        _offset = _material.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        _offset.x = _offset.x + (0.2f * Time.deltaTime);
        _material.SetTextureOffset("_MainTex", _offset);
    }
}
