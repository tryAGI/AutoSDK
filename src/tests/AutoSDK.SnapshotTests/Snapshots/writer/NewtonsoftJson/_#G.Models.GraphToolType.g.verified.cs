//HintName: G.Models.GraphToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GraphToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="graph")]
        Graph,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphToolType value)
        {
            return value switch
            {
                GraphToolType.Graph => "graph",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphToolType? ToEnum(string value)
        {
            return value switch
            {
                "graph" => GraphToolType.Graph,
                _ => null,
            };
        }
    }
}