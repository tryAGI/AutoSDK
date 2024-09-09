//HintName: G.Models.ConversationalRagFlowPublicFieldsRetrievalStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: default
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationalRagFlowPublicFieldsRetrievalStrategy
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
    public static class ConversationalRagFlowPublicFieldsRetrievalStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationalRagFlowPublicFieldsRetrievalStrategy value)
        {
            return value switch
            {
                ConversationalRagFlowPublicFieldsRetrievalStrategy.Default => "default",
                ConversationalRagFlowPublicFieldsRetrievalStrategy.Segments => "segments",
                ConversationalRagFlowPublicFieldsRetrievalStrategy.AddNeighbors => "add_neighbors",
                ConversationalRagFlowPublicFieldsRetrievalStrategy.FullDoc => "full_doc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationalRagFlowPublicFieldsRetrievalStrategy? ToEnum(string value)
        {
            return value switch
            {
                "default" => ConversationalRagFlowPublicFieldsRetrievalStrategy.Default,
                "segments" => ConversationalRagFlowPublicFieldsRetrievalStrategy.Segments,
                "add_neighbors" => ConversationalRagFlowPublicFieldsRetrievalStrategy.AddNeighbors,
                "full_doc" => ConversationalRagFlowPublicFieldsRetrievalStrategy.FullDoc,
                _ => null,
            };
        }
    }
}