//HintName: G.Models.BatchIngestRunsRequestPostItemRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchIngestRunsRequestPostItemRunType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chain")]
        Chain,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embedding")]
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parser")]
        Parser,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retriever")]
        Retriever,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchIngestRunsRequestPostItemRunTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchIngestRunsRequestPostItemRunType value)
        {
            return value switch
            {
                BatchIngestRunsRequestPostItemRunType.Chain => "chain",
                BatchIngestRunsRequestPostItemRunType.Embedding => "embedding",
                BatchIngestRunsRequestPostItemRunType.Llm => "llm",
                BatchIngestRunsRequestPostItemRunType.Parser => "parser",
                BatchIngestRunsRequestPostItemRunType.Prompt => "prompt",
                BatchIngestRunsRequestPostItemRunType.Retriever => "retriever",
                BatchIngestRunsRequestPostItemRunType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchIngestRunsRequestPostItemRunType? ToEnum(string value)
        {
            return value switch
            {
                "chain" => BatchIngestRunsRequestPostItemRunType.Chain,
                "embedding" => BatchIngestRunsRequestPostItemRunType.Embedding,
                "llm" => BatchIngestRunsRequestPostItemRunType.Llm,
                "parser" => BatchIngestRunsRequestPostItemRunType.Parser,
                "prompt" => BatchIngestRunsRequestPostItemRunType.Prompt,
                "retriever" => BatchIngestRunsRequestPostItemRunType.Retriever,
                "tool" => BatchIngestRunsRequestPostItemRunType.Tool,
                _ => null,
            };
        }
    }
}