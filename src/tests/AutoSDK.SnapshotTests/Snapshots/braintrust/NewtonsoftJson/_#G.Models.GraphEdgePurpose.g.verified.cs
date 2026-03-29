//HintName: G.Models.GraphEdgePurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The purpose of the edge
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GraphEdgePurpose
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="control")]
        Control,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="data")]
        Data,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="messages")]
        Messages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphEdgePurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphEdgePurpose value)
        {
            return value switch
            {
                GraphEdgePurpose.Control => "control",
                GraphEdgePurpose.Data => "data",
                GraphEdgePurpose.Messages => "messages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphEdgePurpose? ToEnum(string value)
        {
            return value switch
            {
                "control" => GraphEdgePurpose.Control,
                "data" => GraphEdgePurpose.Data,
                "messages" => GraphEdgePurpose.Messages,
                _ => null,
            };
        }
    }
}