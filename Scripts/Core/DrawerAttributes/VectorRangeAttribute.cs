using System;
using UnityEngine;


namespace NaughtyAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class VectorRangeAttribute : DrawerAttribute
    {
        public Vector3 minValue { get; private set; }
        public Vector3 maxValue { get; private set; }

        public VectorRangeAttribute(float minX, float maxX, float minY, float maxY)
        {
            minValue = new Vector3(minX, minY, float.MinValue);
            maxValue = new Vector3(maxX, maxY, float.MaxValue);
        }

        public VectorRangeAttribute(float minX, float maxX, float minY, float maxY, float minZ, float maxZ)
        {
            minValue = new Vector3(minX, minY, minZ);
            maxValue = new Vector3(maxX, maxY, maxZ);
        }
    }

}
