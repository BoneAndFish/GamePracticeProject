using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMapData : MonoBehaviour {

    [HideInInspector]
    public int mapWidth;
    [HideInInspector]
    public int mapLength;
    [HideInInspector]
    public string[] mapData;

    [SerializeField]
    private string textMapData;

    public GameObject prefab_block;
    public string mapDataFilePath;

    // Use this for initialization
    void Start()
    {
        
        //LoadMap();
    }

    /// <summary>
    /// マップデータをロードする.
    /// </summary>
    public void LoadMap()
    {
        //テキストデータをロードする.
        textMapData = Resources.Load(mapDataFilePath).ToString();
        //縦幅を改行コードで区切ることで取得する.
        string[] mapDataLength = textMapData.Split(new string[] { "\r", "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
        //Debug.Log(line[1]);
        //横幅を","で区切ることで取得する.
        string[] mapDataWidth = mapDataLength[0].Split(new string[] { "," }, System.StringSplitOptions.RemoveEmptyEntries);
        mapWidth = mapDataWidth.Length;
        mapLength = mapDataLength.Length;
        //全部の要素をばらす.
        mapData = textMapData.Split(new string[] { ",", "\r", "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
    }
}
