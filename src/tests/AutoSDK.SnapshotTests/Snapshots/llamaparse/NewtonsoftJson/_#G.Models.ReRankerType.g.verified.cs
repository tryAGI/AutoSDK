//HintName: G.Models.ReRankerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for the reranker type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReRankerType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bedrock")]
        Bedrock,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cohere")]
        Cohere,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="score")]
        Score,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system_default")]
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