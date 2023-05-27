using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Flask : MonoBehaviour { 
    void Start() {
        StartCoroutine(GetRequest("http://127.0.0.1:5000"));
    }

    IEnumerator GetRequest(string uri) {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri)) {
            yield return webRequest.SendWebRequest();
            if (webRequest.isNetworkError) {
                Debug.Log("Error: " + webRequest.error);
            } else {
                Debug.Log(webRequest.downloadHandler.text);

                if (webRequest.downloadHandler.text == "Hello World") {
                    Debug.Log("404");
                }
            }
        }
    }
}
