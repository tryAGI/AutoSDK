//HintName: G.Models.ReRankerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for the reranker type.
    /// </summary>
    public enum ReRankerType
    {
        /// <summary>
        /// 
        /// </summary>
        Bedrock,
        /// <summary>
        /// 
        /// </summary>
        Cohere,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Score,
        /// <summary>
        /// 
        /// </summary>
        SystemDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReRankerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReRankerType value)
        {
            return value switch
            {
                ReRankerType.Bedrock => "bedrock",
                ReRankerType.Cohere => "cohere",
                ReRankerType.Disabled => "disabled",
                ReRankerType.Llm => "llm",
                ReRankerType.Score => "score",
                ReRankerType.SystemDefault => "system_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReRankerType? ToEnum(string value)
        {
            return value switch
            {
                "bedrock" => ReRankerType.Bedrock,
                "cohere" => ReRankerType.Cohere,
                "disabled" => ReRankerType.Disabled,
                "llm" => ReRankerType.Llm,
                "score" => ReRankerType.Score,
                "system_default" => ReRankerType.SystemDefault,
                _ => null,
            };
        }
    }
}