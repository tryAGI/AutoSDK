//HintName: G.Models.RunCreateSchemaExtendedRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for run types.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunCreateSchemaExtendedRunType
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
    public static class RunCreateSchemaExtendedRunTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunCreateSchemaExtendedRunType value)
        {
            return value switch
            {
                RunCreateSchemaExtendedRunType.Tool => "tool",
                RunCreateSchemaExtendedRunType.Chain => "chain",
                RunCreateSchemaExtendedRunType.Llm => "llm",
                RunCreateSchemaExtendedRunType.Retriever => "retriever",
                RunCreateSchemaExtendedRunType.Embedding => "embedding",
                RunCreateSchemaExtendedRunType.Prompt => "prompt",
                RunCreateSchemaExtendedRunType.Parser => "parser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunCreateSchemaExtendedRunType ToEnum(string value)
        {
            return value switch
            {
                "tool" => RunCreateSchemaExtendedRunType.Tool,
                "chain" => RunCreateSchemaExtendedRunType.Chain,
                "llm" => RunCreateSchemaExtendedRunType.Llm,
                "retriever" => RunCreateSchemaExtendedRunType.Retriever,
                "embedding" => RunCreateSchemaExtendedRunType.Embedding,
                "prompt" => RunCreateSchemaExtendedRunType.Prompt,
                "parser" => RunCreateSchemaExtendedRunType.Parser,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}