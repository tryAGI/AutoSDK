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
        AddNeighbors,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        FullDoc,
        /// <summary>
        /// 
        /// </summary>
        Segments,
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
                ConversationalRagConfigRetrievalStrategy.AddNeighbors => "add_neighbors",
                ConversationalRagConfigRetrievalStrategy.Default => "default",
                ConversationalRagConfigRetrievalStrategy.FullDoc => "full_doc",
                ConversationalRagConfigRetrievalStrategy.Segments => "segments",
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
                "add_neighbors" => ConversationalRagConfigRetrievalStrategy.AddNeighbors,
                "default" => ConversationalRagConfigRetrievalStrategy.Default,
                "full_doc" => ConversationalRagConfigRetrievalStrategy.FullDoc,
                "segments" => ConversationalRagConfigRetrievalStrategy.Segments,
                _ => null,
            };
        }
    }
}