using System;

namespace NaughtyAttributes
{
    public abstract class MetaAttribute : Attribute, INaughtyAttribute
    {
        public int Order { get; set; }
    }
}
