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
        Tool,
        /// <summary>
        /// 
        /// </summary>
        Chain,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Retriever,
        /// <summary>
        /// 
        /// </summary>
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        Parser,
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
                BatchIngestRunsRequestPostItemRunType.Tool => "tool",
                BatchIngestRunsRequestPostItemRunType.Chain => "chain",
                BatchIngestRunsRequestPostItemRunType.Llm => "llm",
                BatchIngestRunsRequestPostItemRunType.Retriever => "retriever",
                BatchIngestRunsRequestPostItemRunType.Embedding => "embedding",
                BatchIngestRunsRequestPostItemRunType.Prompt => "prompt",
                BatchIngestRunsRequestPostItemRunType.Parser => "parser",
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
                "tool" => BatchIngestRunsRequestPostItemRunType.Tool,
                "chain" => BatchIngestRunsRequestPostItemRunType.Chain,
                "llm" => BatchIngestRunsRequestPostItemRunType.Llm,
                "retriever" => BatchIngestRunsRequestPostItemRunType.Retriever,
                "embedding" => BatchIngestRunsRequestPostItemRunType.Embedding,
                "prompt" => BatchIngestRunsRequestPostItemRunType.Prompt,
                "parser" => BatchIngestRunsRequestPostItemRunType.Parser,
                _ => null,
            };
        }
    }
}