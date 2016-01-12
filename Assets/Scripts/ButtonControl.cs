using UnityEngine;
using System.Collections;

public class ButtonControl : MonoBehaviour {
    public ButtonControl.ButtonType buttonPlay;
    // Use this for initialization
    private ButtonControl() {
    }
    private void OnMouseDown()
    {
        transform.localScale = new Vector3(0.5f , 0.5f);
    }
    private void OnMouseUp()
    {
        transform.localScale = new Vector3(0.5f, 0.5f);
        if (buttonPlay == ButtonControl.ButtonType.btnPlay) {
            Application.LoadLevel("GamePlay");
        }
    }
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    public enum ButtonType
    {
    btnPlay
    }
}
