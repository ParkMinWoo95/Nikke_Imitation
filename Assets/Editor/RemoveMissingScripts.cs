using UnityEngine;
using UnityEditor;

public class RemoveMissingScripts : MonoBehaviour
{
    [MenuItem("Tools/Remove Missing Scripts in Selected GameObject")]
    private static void RemoveMissingScriptsFromSelected()
    {
        GameObject[] selectedObjects = Selection.gameObjects;
        foreach (GameObject go in selectedObjects)
        {
            RemoveMissingScriptsInGameObject(go);
        }
        Debug.Log("Missing scripts removed from selected GameObjects.");
    }

    private static void RemoveMissingScriptsInGameObject(GameObject go)
    {
        GameObjectUtility.RemoveMonoBehavioursWithMissingScript(go);

        foreach (Transform child in go.transform)
        {
            RemoveMissingScriptsInGameObject(child.gameObject);
        }
    }
}