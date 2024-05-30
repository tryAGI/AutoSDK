//HintName: G.Models.RunCreateSchemaRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for run types.
    /// </summary>
    public enum RunCreateSchemaRunType
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