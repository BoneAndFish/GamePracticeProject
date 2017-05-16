using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMapData : MonoBehaviour {

    [SerializeField]
    private SetMapData setMapData;
    [SerializeField]
    private LoadMapData loadMapData;

    public float startXValue;
    public float StartZValue;
    public float setOffSetValue;

    // Use this for initialization
    void Start () {
		
	}
    /// <summary>
    /// マップを生成する.
    /// </summary>
    public void CreateMap()
    {
        //横幅を取得.
        int mapWidth = loadMapData.mapWidth;
        //縦幅を取得.
        int mapLength = loadMapData.mapLength;
        //マップデータを移す.
        string[] mapData = loadMapData.mapData;
        //マップデータを選んでいくためのカウント.
        int mapDataCount = 0;

        //二重for文で縦と横を計算してマップに配置する.マップデータの内容通りに設置できる.
        for (int mapLengthCount = 0;mapLengthCount < mapLength;mapLengthCount++)
        {
            for (int mapWidthCount = 0;mapWidthCount < mapWidth;mapWidthCount++)
            {
                //マップオブジェクトを配置する.
                setMapData.SetMapObject(mapData[mapDataCount],startXValue + setOffSetValue * mapWidthCount,StartZValue+ setOffSetValue * mapLengthCount);
                mapDataCount++;
            }
        }           
    }
    

}
