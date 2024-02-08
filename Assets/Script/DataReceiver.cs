using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataReceiver : MonoBehaviour
{
    private GameObject DataCarrier;
    List<int> ReceiveData = new List<int>();
    // Start is called before the first frame update
    private DataCarrier datacarrier;
    private GameObject receiver;
    void Start()
    {
        GameObject DataCarrierObject = GameObject.Find("DataCarrier");
        datacarrier = DataCarrierObject.GetComponent<DataCarrier>();

        int sum =  0;
        ReceiveData = datacarrier.inputtextList;
        foreach(int value in ReceiveData){
            Debug.Log(value);
            sum += value;
        }
        setValue(sum);
    }

    private void setValue(int value){
        receiver = GameObject.Find("Receiver");
        Text receiveText = receiver.GetComponent<Text>();
        receiveText.text = value.ToString();
    } 
}
