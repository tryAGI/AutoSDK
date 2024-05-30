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

    public static class RunCreateSchemaExtendedRunTypeExtensions
    {
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
        public static RunCreateSchemaExtendedRunType ToEnum(int value)
        {
            return value switch
            {
                0 => RunCreateSchemaExtendedRunType.Tool,
                1 => RunCreateSchemaExtendedRunType.Chain,
                2 => RunCreateSchemaExtendedRunType.Llm,
                3 => RunCreateSchemaExtendedRunType.Retriever,
                4 => RunCreateSchemaExtendedRunType.Embedding,
                5 => RunCreateSchemaExtendedRunType.Prompt,
                6 => RunCreateSchemaExtendedRunType.Parser,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}