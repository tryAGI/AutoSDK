//HintName: G.Models.GenerationGetResponsesContentApplicationJsonSchemaDataApiType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of API used for the generation
    /// </summary>
    public enum GenerationGetResponsesContentApplicationJsonSchemaDataApiType
    {
        /// <summary>
        /// 
        /// </summary>
        Completions,
        /// <summary>
        /// 
        /// </summary>
        Embeddings,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationGetResponsesContentApplicationJsonSchemaDataApiTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationGetResponsesContentApplicationJsonSchemaDataApiType value)
        {
            return value switch
            {
                GenerationGetResponsesContentApplicationJsonSchemaDataApiType.Completions => "completions",
                GenerationGetResponsesContentApplicationJsonSchemaDataApiType.Embeddings => "embeddings",
                GenerationGetResponsesContentApplicationJsonSchemaDataApiType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationGetResponsesContentApplicationJsonSchemaDataApiType? ToEnum(string value)
        {
            return value switch
            {
                "completions" => GenerationGetResponsesContentApplicationJsonSchemaDataApiType.Completions,
                "embeddings" => GenerationGetResponsesContentApplicationJsonSchemaDataApiType.Embeddings,
                "video" => GenerationGetResponsesContentApplicationJsonSchemaDataApiType.Video,
                _ => null,
            };
        }
    }
}