//HintName: G.Models.RunTypeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for run types.
    /// </summary>
    public enum RunTypeEnum
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
    public static class RunTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunTypeEnum value)
        {
            return value switch
            {
                RunTypeEnum.Tool => "tool",
                RunTypeEnum.Chain => "chain",
                RunTypeEnum.Llm => "llm",
                RunTypeEnum.Retriever => "retriever",
                RunTypeEnum.Embedding => "embedding",
                RunTypeEnum.Prompt => "prompt",
                RunTypeEnum.Parser => "parser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "tool" => RunTypeEnum.Tool,
                "chain" => RunTypeEnum.Chain,
                "llm" => RunTypeEnum.Llm,
                "retriever" => RunTypeEnum.Retriever,
                "embedding" => RunTypeEnum.Embedding,
                "prompt" => RunTypeEnum.Prompt,
                "parser" => RunTypeEnum.Parser,
                _ => null,
            };
        }
    }
}