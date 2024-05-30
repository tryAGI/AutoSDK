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

    public static class RunCreateSchemaRunTypeExtensions
    {
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
        public static RunCreateSchemaRunType ToEnum(int value)
        {
            return value switch
            {
                0 => RunCreateSchemaRunType.Tool,
                1 => RunCreateSchemaRunType.Chain,
                2 => RunCreateSchemaRunType.Llm,
                3 => RunCreateSchemaRunType.Retriever,
                4 => RunCreateSchemaRunType.Embedding,
                5 => RunCreateSchemaRunType.Prompt,
                6 => RunCreateSchemaRunType.Parser,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}