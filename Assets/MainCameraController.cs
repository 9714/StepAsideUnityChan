using System.Collections;
using UnityEngine;

public class MainCameraController : MonoBehaviour {

	//uitychanのオブジェクト
	private GameObject unitychan;
	//ubitychanとカメラの距離
	private float diff;

	// Use this for initialization
	void Start () {
	//unitychanのオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
    //unitychanとカメラとの距離を算出
		this.diff = unitychan.transform.position.z - this.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {

		//unitychanの位置に合わせてカメラの位置を移動
		this.transform.position = new Vector3(0,this.transform.position.y,this.unitychan.transform.position.z - diff);
	}
}
