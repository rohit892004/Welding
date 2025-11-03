using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FifithSceene : MonoBehaviour
{
    public enum ActionMode { Delete, Deactivate }

    [Header("Objects to Switch")]
    public GameObject objectToActivate;
    public GameObject objectToDeactivate;

    [Header("Empty Groups to Handle")]
    public GameObject[] emptyGroupsToClear;  // Group1 ke jagah array
    public ActionMode groupAction = ActionMode.Delete;

    public GameObject[] emptyGroupsToActivate; // Group2 ke jagah array

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FifthScene")) // Player tag required
        {
            // Activate / Deactivate main objects
            if (objectToActivate != null) objectToActivate.SetActive(true);
            if (objectToDeactivate != null) objectToDeactivate.SetActive(false);

            // Handle groups to clear
            foreach (GameObject group in emptyGroupsToClear)
            {
                if (group != null)
                {
                    if (groupAction == ActionMode.Delete)
                        DeleteChildren(group);
                    else if (groupAction == ActionMode.Deactivate)
                        SetChildrenActive(group, false);
                }
            }

            // Handle groups to activate
            foreach (GameObject group in emptyGroupsToActivate)
            {
                if (group != null) SetChildrenActive(group, true);
            }

            // ⚡ Player ko bhi delete karna hai
            Destroy(other.gameObject);
        }
    }

    private void DeleteChildren(GameObject parent)
    {
        foreach (Transform child in parent.transform)
        {
            Destroy(child.gameObject);
        }
    }

    private void SetChildrenActive(GameObject parent, bool state)
    {
        foreach (Transform child in parent.transform)
        {
            child.gameObject.SetActive(state);
        }
    }
}
