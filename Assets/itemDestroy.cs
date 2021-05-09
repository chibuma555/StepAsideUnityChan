using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemDestroy : MonoBehaviour
{
    // unityちゃんを入れる
    private GameObject unitychan;

    private float length;

    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        // unityちゃんと自身の距離(z座標）
        this.length = this.transform.position.z - unitychan.transform.position.z;
        // 距離に応じてオブジェクトを破棄する
        if (length <= -5.0f)
        {
            Destroy(gameObject);
        }
    }
}
