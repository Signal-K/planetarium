using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetNameUIManager : MonoBehaviour {
    public Text planetNameText;

    public void UpdatePlanetName(string newPlanetName) {
        planetNameText.text = newPlanetName;
    }
}