//HintName: G.Models.ChunkingStrategyDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChunkingStrategyDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        MaxCharsChunkingStrategy,
        /// <summary>
        /// 
        /// </summary>
        SentenceChunkingStrategy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChunkingStrategyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChunkingStrategyDiscriminatorType value)
        {
            return value switch
            {
                ChunkingStrategyDiscriminatorType.MaxCharsChunkingStrategy => "max_chars_chunking_strategy",
                ChunkingStrategyDiscriminatorType.SentenceChunkingStrategy => "sentence_chunking_strategy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChunkingStrategyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "max_chars_chunking_strategy" => ChunkingStrategyDiscriminatorType.MaxCharsChunkingStrategy,
                "sentence_chunking_strategy" => ChunkingStrategyDiscriminatorType.SentenceChunkingStrategy,
                _ => null,
            };
        }
    }
}