//HintName: G.Models.BodyParamsForRunSchemaRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for run types.
    /// </summary>
    public enum BodyParamsForRunSchemaRunType
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
    public static class BodyParamsForRunSchemaRunTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyParamsForRunSchemaRunType value)
        {
            return value switch
            {
                BodyParamsForRunSchemaRunType.Tool => "tool",
                BodyParamsForRunSchemaRunType.Chain => "chain",
                BodyParamsForRunSchemaRunType.Llm => "llm",
                BodyParamsForRunSchemaRunType.Retriever => "retriever",
                BodyParamsForRunSchemaRunType.Embedding => "embedding",
                BodyParamsForRunSchemaRunType.Prompt => "prompt",
                BodyParamsForRunSchemaRunType.Parser => "parser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyParamsForRunSchemaRunType? ToEnum(string value)
        {
            return value switch
            {
                "tool" => BodyParamsForRunSchemaRunType.Tool,
                "chain" => BodyParamsForRunSchemaRunType.Chain,
                "llm" => BodyParamsForRunSchemaRunType.Llm,
                "retriever" => BodyParamsForRunSchemaRunType.Retriever,
                "embedding" => BodyParamsForRunSchemaRunType.Embedding,
                "prompt" => BodyParamsForRunSchemaRunType.Prompt,
                "parser" => BodyParamsForRunSchemaRunType.Parser,
                _ => null,
            };
        }
    }
}