//HintName: G.Models.ConversationalRagConfigRetrievalStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: default
    /// </summary>
    public enum ConversationalRagConfigRetrievalStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Segments,
        /// <summary>
        /// 
        /// </summary>
        AddNeighbors,
        /// <summary>
        /// 
        /// </summary>
        FullDoc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationalRagConfigRetrievalStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationalRagConfigRetrievalStrategy value)
        {
            return value switch
            {
                ConversationalRagConfigRetrievalStrategy.Default => "default",
                ConversationalRagConfigRetrievalStrategy.Segments => "segments",
                ConversationalRagConfigRetrievalStrategy.AddNeighbors => "add_neighbors",
                ConversationalRagConfigRetrievalStrategy.FullDoc => "full_doc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationalRagConfigRetrievalStrategy? ToEnum(string value)
        {
            return value switch
            {
                "default" => ConversationalRagConfigRetrievalStrategy.Default,
                "segments" => ConversationalRagConfigRetrievalStrategy.Segments,
                "add_neighbors" => ConversationalRagConfigRetrievalStrategy.AddNeighbors,
                "full_doc" => ConversationalRagConfigRetrievalStrategy.FullDoc,
                _ => null,
            };
        }
    }
}