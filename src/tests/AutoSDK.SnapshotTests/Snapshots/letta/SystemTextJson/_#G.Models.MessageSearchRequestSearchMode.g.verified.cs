//HintName: G.Models.MessageSearchRequestSearchMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Search mode to use<br/>
    /// Default Value: hybrid
    /// </summary>
    public enum MessageSearchRequestSearchMode
    {
        /// <summary>
        /// 
        /// </summary>
        Fts,
        /// <summary>
        /// 
        /// </summary>
        Hybrid,
        /// <summary>
        /// 
        /// </summary>
        Vector,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageSearchRequestSearchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageSearchRequestSearchMode value)
        {
            return value switch
            {
                MessageSearchRequestSearchMode.Fts => "fts",
                MessageSearchRequestSearchMode.Hybrid => "hybrid",
                MessageSearchRequestSearchMode.Vector => "vector",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageSearchRequestSearchMode? ToEnum(string value)
        {
            return value switch
            {
                "fts" => MessageSearchRequestSearchMode.Fts,
                "hybrid" => MessageSearchRequestSearchMode.Hybrid,
                "vector" => MessageSearchRequestSearchMode.Vector,
                _ => null,
            };
        }
    }
}