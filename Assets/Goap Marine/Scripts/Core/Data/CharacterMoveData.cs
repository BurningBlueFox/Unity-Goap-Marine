using UnityEngine;

namespace GoapMarine.Core
{
    [CreateAssetMenu(fileName = "Character Move Data"), System.Serializable]
    public class CharacterMoveData : ScriptableObject
    {
        [Range(0f, 10f)] public float BaseSpeed = 2f;
        [Range(0.01f, 5f)] public float Acceleration = 0.2f;
    }
}