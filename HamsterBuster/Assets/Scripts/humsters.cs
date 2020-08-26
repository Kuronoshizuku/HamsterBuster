using UnityEngine;
using System.Collections;

public class humsters : MonoBehaviour
{

	//　出現させる敵を入れておく
	[SerializeField] GameObject[] humster;
	//　次に敵が出現するまでの時間
	[SerializeField] float appearNextTime;
	//　この場所から出現する敵の数
	[SerializeField] int maxNumOfhumster;
	//　今何人の敵を出現させたか（総数）
	private int numberOfhumster;
	//　待ち時間計測フィールド
	private float elapsedTime;

	// Use this for initialization
	void Start()
	{
		numberOfhumster = 0;
		elapsedTime = 0f;
	}
	void Update()
	{
		//　この場所から出現する最大数を超えてたら何もしない
		if (numberOfhumster >= maxNumOfhumster)
		{
			return;
		}
		//　経過時間を足す
		elapsedTime += Time.deltaTime;

		//　経過時間が経ったら
		if (elapsedTime > appearNextTime)
		{
			elapsedTime = 0f;

			Appearhumster();
		}
	}
	//　敵出現メソッド
	void Appearhumster()
	{
		//　出現させる敵をランダムに選ぶ
		var randomValue = Random.Range(0, humster.Length);
		//　敵の向きをランダムに決定
		var RotationZ = 90f;

		GameObject.Instantiate(humster[randomValue], transform.position, Quaternion.Euler(0f, RotationZ, 0f));

		numberOfhumster++;
		elapsedTime = 0f;
	}
}