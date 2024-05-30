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