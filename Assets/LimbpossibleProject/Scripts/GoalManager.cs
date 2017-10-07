using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour {

    public bool IsGoalActive;

    [Header("What gets activated if the goal is active?")]
    public List<Animator> ThingsToActivate;
   
	public void UnlockGoal()
    {
        foreach(Animator anim in ThingsToActivate)
        {
            anim.SetTrigger("Activate");
        }
    }
}
