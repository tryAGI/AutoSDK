//HintName: G.Models.RunCreateSchemaRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for run types.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunCreateSchemaRunType
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
    public static class RunCreateSchemaRunTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunCreateSchemaRunType value)
        {
            return value switch
            {
                RunCreateSchemaRunType.Tool => "tool",
                RunCreateSchemaRunType.Chain => "chain",
                RunCreateSchemaRunType.Llm => "llm",
                RunCreateSchemaRunType.Retriever => "retriever",
                RunCreateSchemaRunType.Embedding => "embedding",
                RunCreateSchemaRunType.Prompt => "prompt",
                RunCreateSchemaRunType.Parser => "parser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunCreateSchemaRunType ToEnum(string value)
        {
            return value switch
            {
                "tool" => RunCreateSchemaRunType.Tool,
                "chain" => RunCreateSchemaRunType.Chain,
                "llm" => RunCreateSchemaRunType.Llm,
                "retriever" => RunCreateSchemaRunType.Retriever,
                "embedding" => RunCreateSchemaRunType.Embedding,
                "prompt" => RunCreateSchemaRunType.Prompt,
                "parser" => RunCreateSchemaRunType.Parser,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}