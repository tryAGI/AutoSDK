//HintName: G.Models.ConversationalRagConfigRetrievalStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: default
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationalRagConfigRetrievalStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="segments")]
        Segments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="add_neighbors")]
        AddNeighbors,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="full_doc")]
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