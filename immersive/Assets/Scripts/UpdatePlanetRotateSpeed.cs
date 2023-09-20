using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePlanetRotateSpeed : MonoBehaviour {
    public Planet planet; // Reference to the Planet script
    public ColourSettings colourSettings; // Reference to that planet's colourSettings

    public void UpdatePlanetTurnSpeed(float newPlanetTurnSpeed) {
        // Update the TurnSpeed variable in the Planet script
        planet.TurnSpeed = newPlanetTurnSpeed;

        // Access the ColourSettings of the planet and update noiseStrength
        if (planet != null && planet.colourSettings != null) {
            planet.colourSettings.biomeColourSettings.noiseStrength = 3.0f;
        }
    }

    public void UpdatePlanetStrength(float newPlanetStrength) {
        planet.colourSettings.biomeColourSettings.noiseStrength = newPlanetStrength;
    }

    public void SetNoiseStrengthTo3() {
        // Access the ColourSettings of the planet and update noiseStrength
        if (planet != null && planet.colourSettings != null) {
            planet.colourSettings.biomeColourSettings.noiseStrength = 3.0f;
        }
    }
} 