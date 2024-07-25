//HintName: G.Models.BatchIngestRunsRequestPostRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BatchIngestRunsRequestPostRunType
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