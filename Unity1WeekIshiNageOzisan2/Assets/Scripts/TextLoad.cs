using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLoad : MonoBehaviour {
    /*
    public int mapWidth;
    public int mapLength;
    [SerializeField]
    private string textMapData;

    public GameObject prefab_block;
    public string mapDataFilePath;

    public string[] p_mapData;

	// Use this for initialization
	void Start () {
        textMapData = Resources.Load(mapDataFilePath).ToString();
        LoadMapData();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// マップデータをロードする.
    /// </summary>
    public void LoadMapData()
    {
        //縦幅を改行コードで区切ることで取得する.
        string[] mapDataLength = textMapData.Split(new string[] { "\r", "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
        //Debug.Log(line[1]);
        //横幅を","で区切ることで取得する.
        string[] mapDataWidth = mapDataLength[0].Split(new string[] {","}, System.StringSplitOptions.RemoveEmptyEntries);
        mapWidth = mapDataWidth.Length;
        mapLength = mapDataLength.Length;
        //全部の要素をばらす.
        string[] mapData = textMapData.Split(new string[] {",","\r","\n"},System.StringSplitOptions.RemoveEmptyEntries);
        p_mapData = mapData;
    }
    */
}
