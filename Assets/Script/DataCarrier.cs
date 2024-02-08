using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

using UnityEngine.SceneManagement;

public class DataCarrier : MonoBehaviour
{
    public GameObject[] inputs;
    private List<int> inputtext = new List<int>();

    public List<int> inputtextList{
        get{return this.inputtext;}
    }  

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void onClick(){
        setInputText();
        SceneManager.LoadScene("Sum");
    }

    public void setInputText(){
        for(int i = 0 ; i < inputs.Length ; i++)
        {
            inputtext.Add(int.Parse(inputs[i].GetComponent<InputField>().text));
        }
    }

}
// 別のシーンでこのオブジェクトを探してデータを取得することができます。