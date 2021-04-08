using UnityEngine;
using Vuforia;

public class AnimationCanva : MonoBehaviour//, ITrackableEventHandler
{
    private TrackableBehaviour animations;
    // Start is called before the first frame update
    void Start()
    {
		animations = GetComponent<TrackableBehaviour>();
        if (animations)
		{
			//animations.RegisterTrackableEventHandler(this);
        }
    }

	public void OnTrackableStateChanged(TrackableBehaviour.Status PreviusStatus, TrackableBehaviour.Status newStatus)
	{
		Animator[] ListAmimatios = GetComponentsInChildren<Animator>();
		if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			foreach (Animator varAnimator in ListAmimatios)
			{
				varAnimator.enabled = true;
			}
		}
		else
		{
			foreach (Animator varAnimator in ListAmimatios)
			{
				varAnimator.Rebind();
				varAnimator.enabled = false;
			}
		}
	}
}

