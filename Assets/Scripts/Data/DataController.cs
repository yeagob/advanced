using UnityEngine;
using System.IO;

public class DataController : MonoBehaviour
{
	//Struct
	[System.Serializable]
	public struct DataBucket
	{
		public int explosionCount;
		public int spawnCount;
		public int collistionCount;

		public void Save(string path)
		{
			string jsonString = JsonUtility.ToJson(this);
			File.WriteAllText(path, jsonString);
		}
	}

	//Attributes
	public DataBucket bucket;

	//Methods

	// Start is called before the first frame update
	void Start()
	{
		bucket.explosionCount = 0;
		bucket.spawnCount = 0;
		bucket.collistionCount = 0;
	}

	private void OnDestroy()
	{
		bucket.Save(Application.dataPath + "/Data/data.txt");
	}

	public void SendData(KPIType dataType)
	{
		switch (dataType)
		{
			case KPIType.CollisionKPI:
				bucket.collistionCount++;
				break;
			case KPIType.ExplosionsKPI:
				bucket.explosionCount++;
				break;
			case KPIType.SpawnedBallKPI:
				bucket.spawnCount++;
				break;
		}
	}
}
