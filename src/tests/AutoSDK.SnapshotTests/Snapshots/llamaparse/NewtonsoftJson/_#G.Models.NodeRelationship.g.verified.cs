//HintName: G.Models.NodeRelationship.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Node relationships used in `BaseNode` class.<br/>
    /// Attributes:<br/>
    ///     SOURCE: The node is the source document.<br/>
    ///     PREVIOUS: The node is the previous node in the document.<br/>
    ///     NEXT: The node is the next node in the document.<br/>
    ///     PARENT: The node is the parent node in the document.<br/>
    ///     CHILD: The node is a child node in the document.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NodeRelationship
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1")]
        x1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2")]
        x2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="3")]
        x3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="4")]
        x4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="5")]
        x5,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeRelationshipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeRelationship value)
        {
            return value switch
            {
                NodeRelationship.x1 => "1",
                NodeRelationship.x2 => "2",
                NodeRelationship.x3 => "3",
                NodeRelationship.x4 => "4",
                NodeRelationship.x5 => "5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeRelationship? ToEnum(string value)
        {
            return value switch
            {
                "1" => NodeRelationship.x1,
                "2" => NodeRelationship.x2,
                "3" => NodeRelationship.x3,
                "4" => NodeRelationship.x4,
                "5" => NodeRelationship.x5,
                _ => null,
            };
        }
    }
}