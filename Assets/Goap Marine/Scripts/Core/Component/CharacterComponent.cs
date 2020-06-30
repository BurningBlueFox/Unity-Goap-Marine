using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoapMarine.Core
{
    public class CharacterComponent : MonoBehaviour
    {
        private CharacterMoveData moveData;

        public void MoveCharacter()
        {
            Debug.Log("Calling from method Move Character");
        }
        public void MoveCharacterWithParam(InputValues inputValues)
        {
            Debug.Log("Calling from method Move Character with input values \n " + inputValues);
        }
        private void Update()
        {
            //TODO: Change this to Actually get the input or some sort
            InputValues input = new InputValues(1f, 0.5f);

        }
    }
}