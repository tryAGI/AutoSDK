//HintName: G.Models.CreateRunRequestRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateRunRequestRunType
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
    public static class CreateRunRequestRunTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRunRequestRunType value)
        {
            return value switch
            {
                CreateRunRequestRunType.Tool => "tool",
                CreateRunRequestRunType.Chain => "chain",
                CreateRunRequestRunType.Llm => "llm",
                CreateRunRequestRunType.Retriever => "retriever",
                CreateRunRequestRunType.Embedding => "embedding",
                CreateRunRequestRunType.Prompt => "prompt",
                CreateRunRequestRunType.Parser => "parser",
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
                "tool" => CreateRunRequestRunType.Tool,
                "chain" => CreateRunRequestRunType.Chain,
                "llm" => CreateRunRequestRunType.Llm,
                "retriever" => CreateRunRequestRunType.Retriever,
                "embedding" => CreateRunRequestRunType.Embedding,
                "prompt" => CreateRunRequestRunType.Prompt,
                "parser" => CreateRunRequestRunType.Parser,
                _ => null,
            };
        }
    }
}