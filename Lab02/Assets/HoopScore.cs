using UnityEngine;
using System.Linq;


public class HoopTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grab = other.GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        Rigidbody rb = other.GetComponent<Rigidbody>();

        if (rb != null && grab != null)
        {
            var selectingInteractor = grab.interactorsSelecting.FirstOrDefault();

            if (selectingInteractor != null)
            {
                Transform handTransform = selectingInteractor.transform;
                float distance = Vector3.Distance(other.transform.position, handTransform.position);
                float score = distance;

                if (ScoreManager.Instance != null)
                    ScoreManager.Instance.AddScore(score);
            }
            else
            {
                if (ScoreManager.Instance != null)
                    ScoreManager.Instance.AddScore(1.0f);
            }
        }
    }
}