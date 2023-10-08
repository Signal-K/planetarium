using UnityEngine;

public class ObjectManager : MonoBehaviour {
    private bool isPlanetVisible = true;

    public void TogglePlanetVisibility() {
        isPlanetVisible = !isPlanetVisible;
        gameObject.SetActive(isPlanetVisible); // Will need to update this to be able to re-show the planet
    }
}