//HintName: G.Models.BatchIngestRunsRequestPostRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchIngestRunsRequestPostRunType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chain")]
        Chain,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retriever")]
        Retriever,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embedding")]
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parser")]
        Parser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchIngestRunsRequestPostRunTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchIngestRunsRequestPostRunType value)
        {
            return value switch
            {
                BatchIngestRunsRequestPostRunType.Tool => "tool",
                BatchIngestRunsRequestPostRunType.Chain => "chain",
                BatchIngestRunsRequestPostRunType.Llm => "llm",
                BatchIngestRunsRequestPostRunType.Retriever => "retriever",
                BatchIngestRunsRequestPostRunType.Embedding => "embedding",
                BatchIngestRunsRequestPostRunType.Prompt => "prompt",
                BatchIngestRunsRequestPostRunType.Parser => "parser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchIngestRunsRequestPostRunType? ToEnum(string value)
        {
            return value switch
            {
                "tool" => BatchIngestRunsRequestPostRunType.Tool,
                "chain" => BatchIngestRunsRequestPostRunType.Chain,
                "llm" => BatchIngestRunsRequestPostRunType.Llm,
                "retriever" => BatchIngestRunsRequestPostRunType.Retriever,
                "embedding" => BatchIngestRunsRequestPostRunType.Embedding,
                "prompt" => BatchIngestRunsRequestPostRunType.Prompt,
                "parser" => BatchIngestRunsRequestPostRunType.Parser,
                _ => null,
            };
        }
    }
}