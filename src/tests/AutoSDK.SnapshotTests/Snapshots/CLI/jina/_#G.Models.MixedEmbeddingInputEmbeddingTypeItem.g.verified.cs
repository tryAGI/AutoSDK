//HintName: G.Models.MixedEmbeddingInputEmbeddingTypeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MixedEmbeddingInputEmbeddingTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        Binary,
        /// <summary>
        /// 
        /// </summary>
        Ubinary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MixedEmbeddingInputEmbeddingTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MixedEmbeddingInputEmbeddingTypeItem value)
        {
            return value switch
            {
                MixedEmbeddingInputEmbeddingTypeItem.Float => "float",
                MixedEmbeddingInputEmbeddingTypeItem.Base64 => "base64",
                MixedEmbeddingInputEmbeddingTypeItem.Binary => "binary",
                MixedEmbeddingInputEmbeddingTypeItem.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MixedEmbeddingInputEmbeddingTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "float" => MixedEmbeddingInputEmbeddingTypeItem.Float,
                "base64" => MixedEmbeddingInputEmbeddingTypeItem.Base64,
                "binary" => MixedEmbeddingInputEmbeddingTypeItem.Binary,
                "ubinary" => MixedEmbeddingInputEmbeddingTypeItem.Ubinary,
                _ => null,
            };
        }
    }
}