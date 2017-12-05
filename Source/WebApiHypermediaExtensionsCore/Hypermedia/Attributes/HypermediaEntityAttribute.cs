using System;

namespace WebApiHypermediaExtensionsCore.Hypermedia.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class HypermediaEntityAttribute : Attribute
    {
        public HypermediaEntityAttribute(string[] relations)
        {
            Relations = relations;
        }

        public HypermediaEntityAttribute(string relation)
        {
            Relations = new []{ relation };
        }

        public string[] Relations { get; private set; }
    }
}