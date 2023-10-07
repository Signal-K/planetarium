using UnityEngine;

public class ObjectManager : MonoBehaviour {
    private bool isPlanetVisible = true;

    public void TogglePlanetVisibility() {
        isPlanetVisible = !isPlanetVisible;
        gameObject.SetActive(isPlanetVisible);
    }
}