//HintName: G.Models.FilterQueryParamsForRunSchemaRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for run types.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FilterQueryParamsForRunSchemaRunType
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