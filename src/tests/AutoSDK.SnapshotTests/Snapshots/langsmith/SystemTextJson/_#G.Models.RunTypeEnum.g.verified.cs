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
        Chain,
        /// <summary>
        /// 
        /// </summary>
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Parser,
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        Retriever,
        /// <summary>
        /// 
        /// </summary>
        Tool,
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
                RunTypeEnum.Chain => "chain",
                RunTypeEnum.Embedding => "embedding",
                RunTypeEnum.Llm => "llm",
                RunTypeEnum.Parser => "parser",
                RunTypeEnum.Prompt => "prompt",
                RunTypeEnum.Retriever => "retriever",
                RunTypeEnum.Tool => "tool",
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
                "chain" => RunTypeEnum.Chain,
                "embedding" => RunTypeEnum.Embedding,
                "llm" => RunTypeEnum.Llm,
                "parser" => RunTypeEnum.Parser,
                "prompt" => RunTypeEnum.Prompt,
                "retriever" => RunTypeEnum.Retriever,
                "tool" => RunTypeEnum.Tool,
                _ => null,
            };
        }
    }
}