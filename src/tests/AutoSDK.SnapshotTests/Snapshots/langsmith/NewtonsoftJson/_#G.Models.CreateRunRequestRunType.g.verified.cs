//HintName: G.Models.CreateRunRequestRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRunRequestRunType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chain")]
        Chain,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embedding")]
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parser")]
        Parser,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retriever")]
        Retriever,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRunRequestRunTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRunRequestRunType value)
        {
            return value switch
            {
                CreateRunRequestRunType.Chain => "chain",
                CreateRunRequestRunType.Embedding => "embedding",
                CreateRunRequestRunType.Llm => "llm",
                CreateRunRequestRunType.Parser => "parser",
                CreateRunRequestRunType.Prompt => "prompt",
                CreateRunRequestRunType.Retriever => "retriever",
                CreateRunRequestRunType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRunRequestRunType? ToEnum(string value)
        {
            return value switch
            {
                "chain" => CreateRunRequestRunType.Chain,
                "embedding" => CreateRunRequestRunType.Embedding,
                "llm" => CreateRunRequestRunType.Llm,
                "parser" => CreateRunRequestRunType.Parser,
                "prompt" => CreateRunRequestRunType.Prompt,
                "retriever" => CreateRunRequestRunType.Retriever,
                "tool" => CreateRunRequestRunType.Tool,
                _ => null,
            };
        }
    }
}