//HintName: G.Models.GraphEdgePurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The purpose of the edge
    /// </summary>
    public enum GraphEdgePurpose
    {
        /// <summary>
        /// 
        /// </summary>
        Control,
        /// <summary>
        /// 
        /// </summary>
        Data,
        /// <summary>
        /// 
        /// </summary>
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