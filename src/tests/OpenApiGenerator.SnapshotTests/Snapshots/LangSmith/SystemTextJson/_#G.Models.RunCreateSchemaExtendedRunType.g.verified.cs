//HintName: G.Models.RunCreateSchemaExtendedRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for run types.
    /// </summary>
    public enum RunCreateSchemaExtendedRunType
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
        public static RunCreateSchemaExtendedRunType? ToEnum(string value)
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
                _ => null,
            };
        }
    }
}