//HintName: G.Models.BodyParamsForRunSchemaRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for run types.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyParamsForRunSchemaRunType
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
    public static class BodyParamsForRunSchemaRunTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyParamsForRunSchemaRunType value)
        {
            return value switch
            {
                BodyParamsForRunSchemaRunType.Tool => "tool",
                BodyParamsForRunSchemaRunType.Chain => "chain",
                BodyParamsForRunSchemaRunType.Llm => "llm",
                BodyParamsForRunSchemaRunType.Retriever => "retriever",
                BodyParamsForRunSchemaRunType.Embedding => "embedding",
                BodyParamsForRunSchemaRunType.Prompt => "prompt",
                BodyParamsForRunSchemaRunType.Parser => "parser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyParamsForRunSchemaRunType? ToEnum(string value)
        {
            return value switch
            {
                "tool" => BodyParamsForRunSchemaRunType.Tool,
                "chain" => BodyParamsForRunSchemaRunType.Chain,
                "llm" => BodyParamsForRunSchemaRunType.Llm,
                "retriever" => BodyParamsForRunSchemaRunType.Retriever,
                "embedding" => BodyParamsForRunSchemaRunType.Embedding,
                "prompt" => BodyParamsForRunSchemaRunType.Prompt,
                "parser" => BodyParamsForRunSchemaRunType.Parser,
                _ => null,
            };
        }
    }
}