using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BundleLoadTest : MonoBehaviour
{

    public Button btn0,btn1,btn2;
    // Start is called before the first frame update
    void Start()
    {
        btn0 = transform.Find("Button").GetComponent<Button>();
        btn1 = transform.Find("Button_1").GetComponent<Button>();
        btn2 = transform.Find("Button_2").GetComponent<Button>();
        btn0.onClick.AddListener(()=> {

            LoadAsset(Application.streamingAssetsPath + "/prefab_cube.bundle","Cube.prefab");
        });

        btn1.onClick.AddListener(() => {
            LoadAsset(Application.streamingAssetsPath + "/mat_mat.bundle",string.Empty);
        });

        btn2.onClick.AddListener(() => {
            LoadAsset(Application.streamingAssetsPath + "/timg.bundle", string.Empty);
        });
    }



    AssetBundleCreateRequest assetBundle;
    string assetname = string.Empty;
    public void LoadAsset(string path,string assetname)
    {
        this.assetname = assetname;
        assetBundle = AssetBundle.LoadFromFileAsync(path);
        assetBundle.completed += LoadComplete;
    }

    public void LoadComplete(AsyncOperation operation)
    {
        if (string.IsNullOrEmpty(assetname))
        {
            return;
        }
        Object obj = assetBundle.assetBundle.LoadAsset(assetname);
        GameObject game = Instantiate(obj) as GameObject;
    }

}
