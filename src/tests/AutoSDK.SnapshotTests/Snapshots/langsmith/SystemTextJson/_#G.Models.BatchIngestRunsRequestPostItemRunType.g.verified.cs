//HintName: G.Models.BatchIngestRunsRequestPostItemRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BatchIngestRunsRequestPostItemRunType
    {
        /// <summary>
        /// 
        /// </summary>
        Chain,
        /// <summary>
        /// 
        /// </summary>
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Parser,
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        Retriever,
        /// <summary>
        /// 
        /// </summary>
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