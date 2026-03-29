//HintName: G.Models.EmbeddingAudioMetadataEmbeddingScopesItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbeddingAudioMetadataEmbeddingScopesItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asset")]
        Asset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip")]
        Clip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingAudioMetadataEmbeddingScopesItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingAudioMetadataEmbeddingScopesItems value)
        {
            return value switch
            {
                EmbeddingAudioMetadataEmbeddingScopesItems.Asset => "asset",
                EmbeddingAudioMetadataEmbeddingScopesItems.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingAudioMetadataEmbeddingScopesItems? ToEnum(string value)
        {
            return value switch
            {
                "asset" => EmbeddingAudioMetadataEmbeddingScopesItems.Asset,
                "clip" => EmbeddingAudioMetadataEmbeddingScopesItems.Clip,
                _ => null,
            };
        }
    }
}