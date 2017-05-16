using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMapData : MonoBehaviour {

    public GameObject[] mapObjects;

    [SerializeField]
    public enum MAPDATATYPE
    {
        NONE,
        WALL,
        JEWEL,
        MINE,
    }

	// Use this for initialization
	void Start () {
		
	}

    /// <summary>
    /// マップデータに合わせたオブジェクトを生成する.
    /// </summary>
    /// <param name="mapDataString"></param>
    /// <param name="x"></param>
    /// <param name="z"></param>
    /// <param name="setOffset"></param>
    public void SetMapObject(string mapDataString,float x,float z)
    {
        MAPDATATYPE mapDataType = SelectMapObjectType(mapDataString);
        Vector3 setPosition = new Vector3(x,0.0f,z);
        if (mapDataType != MAPDATATYPE.NONE) {
            GameObject mapData = Instantiate(mapObjects[mapDataType.GetHashCode()], setPosition, Quaternion.identity);
        }
    }
    /// <summary>
    /// マップデータのタイプを選ぶ　引数のマップデータの文字列.
    /// </summary>
    /// <param name="mapDataString"></param>
    /// <returns></returns>
    MAPDATATYPE SelectMapObjectType(string mapDataString)
    {
        MAPDATATYPE mapDataType = MAPDATATYPE.NONE;
        switch (mapDataString)
        {
            case "*":
                mapDataType = MAPDATATYPE.NONE;
                break;
            case "w":
                mapDataType = MAPDATATYPE.WALL;
                break;
            case "m":
                mapDataType = MAPDATATYPE.MINE;
                break;
            case "j":
                mapDataType = MAPDATATYPE.JEWEL;
                break;
        }
        return mapDataType;
    }

}
