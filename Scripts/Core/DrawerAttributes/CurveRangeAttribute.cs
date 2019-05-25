using System;
using UnityEngine;

namespace NaughtyAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class CurveRangeAttribute : DrawerAttribute
    {
        public float width { get; private set; }
        public float height { get; private set; }
        public Color color { get; private set; }

        public CurveRangeAttribute(float width, float height)
        {
            this.width = width;
            this.height = height;
            this.color = Color.green;
        }

        /// <summary>
        /// Draw Curve field with width, height, and an rgb color curve
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        public CurveRangeAttribute(float width, float height, float r = 0, float g = 1, float b = 1)
        {
            this.width = width;
            this.height = height;
            this.color = new Color(r, g, b);
        }
    }
}
