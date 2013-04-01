using UnityEngine;
using System.Collections;

public class MySwipeRecognizer : MonoBehaviour 
{
	private GameObject timothy;
	
	void Awake()
	{
		timothy = GameObject.FindGameObjectWithTag("Timothy");
	}
	
	void OnSwipe( SwipeGesture gesture ) 
	{
	    FingerGestures.SwipeDirection direction = gesture.Direction;

		if(direction == FingerGestures.SwipeDirection.Right)
		{
			timothy.SendMessage ("TimothyDash", SendMessageOptions.DontRequireReceiver);
		}
		else if(direction == FingerGestures.SwipeDirection.Left)
		{
			// punch, kick enemies
		}
		else if(direction == FingerGestures.SwipeDirection.Up)
		{
			timothy.SendMessage ("TimothyJump", SendMessageOptions.DontRequireReceiver);
		}
		else if(direction == FingerGestures.SwipeDirection.Down)
		{
            timothy.SendMessage("TimothySwipedDown", SendMessageOptions.DontRequireReceiver);
		}
	}
}
