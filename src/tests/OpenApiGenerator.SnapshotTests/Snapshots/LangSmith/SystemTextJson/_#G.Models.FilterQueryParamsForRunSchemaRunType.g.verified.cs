//HintName: G.Models.FilterQueryParamsForRunSchemaRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for run types.
    /// </summary>
    public enum FilterQueryParamsForRunSchemaRunType
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
    public static class FilterQueryParamsForRunSchemaRunTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterQueryParamsForRunSchemaRunType value)
        {
            return value switch
            {
                FilterQueryParamsForRunSchemaRunType.Tool => "tool",
                FilterQueryParamsForRunSchemaRunType.Chain => "chain",
                FilterQueryParamsForRunSchemaRunType.Llm => "llm",
                FilterQueryParamsForRunSchemaRunType.Retriever => "retriever",
                FilterQueryParamsForRunSchemaRunType.Embedding => "embedding",
                FilterQueryParamsForRunSchemaRunType.Prompt => "prompt",
                FilterQueryParamsForRunSchemaRunType.Parser => "parser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterQueryParamsForRunSchemaRunType? ToEnum(string value)
        {
            return value switch
            {
                "tool" => FilterQueryParamsForRunSchemaRunType.Tool,
                "chain" => FilterQueryParamsForRunSchemaRunType.Chain,
                "llm" => FilterQueryParamsForRunSchemaRunType.Llm,
                "retriever" => FilterQueryParamsForRunSchemaRunType.Retriever,
                "embedding" => FilterQueryParamsForRunSchemaRunType.Embedding,
                "prompt" => FilterQueryParamsForRunSchemaRunType.Prompt,
                "parser" => FilterQueryParamsForRunSchemaRunType.Parser,
                _ => null,
            };
        }
    }
}