using UnityEngine;

namespace GoapMarine.Core
{
    public struct InputValues
    {
        public float xAxis;
        public float yAxis;

        public InputValues(float xAxis, float yAxis)
        {
            this.xAxis = xAxis;
            this.yAxis = yAxis;
        }

        public override string ToString() => JsonUtility.ToJson(this);

    }
}