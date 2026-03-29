//HintName: G.Models.EmbeddingVideoMetadataEmbeddingScopesItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingVideoMetadataEmbeddingScopesItems
    {
        /// <summary>
        /// 
        /// </summary>
        Asset,
        /// <summary>
        /// 
        /// </summary>
        Clip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingVideoMetadataEmbeddingScopesItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingVideoMetadataEmbeddingScopesItems value)
        {
            return value switch
            {
                EmbeddingVideoMetadataEmbeddingScopesItems.Asset => "asset",
                EmbeddingVideoMetadataEmbeddingScopesItems.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingVideoMetadataEmbeddingScopesItems? ToEnum(string value)
        {
            return value switch
            {
                "asset" => EmbeddingVideoMetadataEmbeddingScopesItems.Asset,
                "clip" => EmbeddingVideoMetadataEmbeddingScopesItems.Clip,
                _ => null,
            };
        }
    }
}