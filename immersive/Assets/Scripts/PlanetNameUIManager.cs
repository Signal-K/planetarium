using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetNameUIManager : MonoBehaviour {
    public Text planetNameText;

    // public Planet planet; // Reference to the Planet script

    public void UpdatePlanetName(string newPlanetName) {
        planetNameText.text = newPlanetName;
    }

    // public void UpdatePlanetTurnSpeed(float newPlanetTurnSpeed) {
    //     // Update the TurnSpeed variable in the Planet script
    //     planet.TurnSpeed = newPlanetTurnSpeed;
    // }
} 