﻿namespace MoreDotNet.Tests.Extensions.Common.XmlExtensions
{
    using System.Xml.Serialization;

    [XmlRoot(nameof(XmlSerializableModel))]
    public class XmlSerializableModel
    {
        public XmlSerializableModel()
        {
            // Default constructor needed for deserialization.
        }

        public XmlSerializableModel(string value)
        {
            this.Value = value;
        }

        public string Value { get; set; }

        public void SetValue(string value)
        {
            this.Value = value;
        }

        public override bool Equals(object obj)
        {
            return Value == (obj as XmlSerializableModel).Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
