//HintName: G.Models.ChunkingStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Strategy used for chunking document content.
    /// </summary>
    public enum ChunkingStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        Page,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChunkingStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChunkingStrategy value)
        {
            return value switch
            {
                ChunkingStrategy.Page => "page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChunkingStrategy? ToEnum(string value)
        {
            return value switch
            {
                "page" => ChunkingStrategy.Page,
                _ => null,
            };
        }
    }
}