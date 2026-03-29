//HintName: G.Models.EmbeddingDataEmbeddingScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The scope for which the embedding was generated.<br/>
    /// **Values**:<br/>
    /// - `clip`: Embedding for a segment<br/>
    /// - `asset`: Embedding for the entire file. Use this scope for videos up to 10-30 seconds to maintain optimal performance.<br/>
    /// - `null`: For text and image embeddings
    /// </summary>
    public enum EmbeddingDataEmbeddingScope
    {
        /// <summary>
        /// Embedding for the entire file. Use this scope for videos up to 10-30 seconds to maintain optimal performance.
        /// </summary>
        Asset,
        /// <summary>
        /// Embedding for a segment
        /// </summary>
        Clip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingDataEmbeddingScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingDataEmbeddingScope value)
        {
            return value switch
            {
                EmbeddingDataEmbeddingScope.Asset => "asset",
                EmbeddingDataEmbeddingScope.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingDataEmbeddingScope? ToEnum(string value)
        {
            return value switch
            {
                "asset" => EmbeddingDataEmbeddingScope.Asset,
                "clip" => EmbeddingDataEmbeddingScope.Clip,
                _ => null,
            };
        }
    }
}