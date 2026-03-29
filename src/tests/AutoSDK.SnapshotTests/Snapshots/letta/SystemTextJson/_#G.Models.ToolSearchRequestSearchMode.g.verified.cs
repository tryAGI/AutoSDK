//HintName: G.Models.ToolSearchRequestSearchMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Search mode: vector, fts, or hybrid.<br/>
    /// Default Value: hybrid
    /// </summary>
    public enum ToolSearchRequestSearchMode
    {
        /// <summary>
        /// vector, fts, or hybrid.
        /// </summary>
        Fts,
        /// <summary>
        /// vector, fts, or hybrid.
        /// </summary>
        Hybrid,
        /// <summary>
        /// vector, fts, or hybrid.
        /// </summary>
        Vector,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSearchRequestSearchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchRequestSearchMode value)
        {
            return value switch
            {
                ToolSearchRequestSearchMode.Fts => "fts",
                ToolSearchRequestSearchMode.Hybrid => "hybrid",
                ToolSearchRequestSearchMode.Vector => "vector",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchRequestSearchMode? ToEnum(string value)
        {
            return value switch
            {
                "fts" => ToolSearchRequestSearchMode.Fts,
                "hybrid" => ToolSearchRequestSearchMode.Hybrid,
                "vector" => ToolSearchRequestSearchMode.Vector,
                _ => null,
            };
        }
    }
}