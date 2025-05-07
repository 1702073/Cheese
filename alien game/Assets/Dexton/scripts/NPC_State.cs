using UnityEngine;

public class Alien_State : MonoBehaviour
{
    NpcAI npcAI;

    ActionToPreform actionToPreform;

    AlienMovement alienMovement;

    public enum ActionToPreform
    {
        infect = 0,
        Wander = 1
    }
    private void Awake()
    {
        NpcAI npcAI = GetComponent<NpcAI>();
        AlienMovement alienMovement = GetComponent<AlienMovement>();
    }

    private void Update()
    {
        if (npcAI == null)
        {
            npcAI = GetComponent<NpcAI>();
        }
        if (actionToPreform == ActionToPreform.Wander)
        {
            npcAI.enabled = true;
            alienMovement.enabled = false;
        }
        else if (actionToPreform == ActionToPreform.infect)
        {

        }
    }
}
