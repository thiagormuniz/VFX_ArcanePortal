using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AutoRotator))]
public class AutoRotator_Editor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        AutoRotator autoRotator = (AutoRotator)target;
        if (GUILayout.Button("Reset Rotation"))
        {
            autoRotator.autoRotateOnEditor = false;
            autoRotator.transform.localEulerAngles = Vector3.zero;

            autoRotator.transform.GetChild(0).transform.localPosition = new Vector3(0, 0, 3f);
            autoRotator.transform.GetChild(0).transform.localEulerAngles = Vector3.zero;

            autoRotator.transform.GetChild(1).transform.localPosition = new Vector3(0, 0, -3f);
            autoRotator.transform.GetChild(1).transform.localEulerAngles = Vector3.zero;
        }
    }
}
