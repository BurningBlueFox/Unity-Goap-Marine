using System.Collections;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;


namespace GoapMarine.Core
{
    public class PlayMakerEventHandler : MonoBehaviour
    {
        [SerializeField] private PlayMakerFSM characterFSM;
        [SerializeField] private FsmEvent characterFSMEvent;


        private void OnEnable()
        {
            Debug.Log("Lets see");
            characterFSM = this.GetComponent<PlayMakerFSM>();
            foreach (var item in characterFSM.Fsm.ExposedEvents)
            {
                Debug.Log(item.Name);
                characterFSM.Fsm.Event(item);
            }
            
        }
    }
}
