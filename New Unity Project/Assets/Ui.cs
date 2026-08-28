using UnityEngine;
using UnityEngine.UIElements;

public class Ui : MonoBehaviour
{
    private void OnEnable()
    {
        var panel = GetComponent<PanelRenderer>();

        panel.RegisterUIReloadCallback((panelRenderer, root, version) =>
        {
            var test = root.Q<Label>("test");
            var farm = root.Q<Button>("farm");

            farm.clicked += () => test.text = "YOOO";
        });
    }
}
