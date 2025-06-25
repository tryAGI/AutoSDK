//HintName: G.Models.ImageEmbeddingInputEmbeddingTypeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageEmbeddingInputEmbeddingTypeItem
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
    public static class ImageEmbeddingInputEmbeddingTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEmbeddingInputEmbeddingTypeItem value)
        {
            return value switch
            {
                ImageEmbeddingInputEmbeddingTypeItem.Float => "float",
                ImageEmbeddingInputEmbeddingTypeItem.Base64 => "base64",
                ImageEmbeddingInputEmbeddingTypeItem.Binary => "binary",
                ImageEmbeddingInputEmbeddingTypeItem.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEmbeddingInputEmbeddingTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "float" => ImageEmbeddingInputEmbeddingTypeItem.Float,
                "base64" => ImageEmbeddingInputEmbeddingTypeItem.Base64,
                "binary" => ImageEmbeddingInputEmbeddingTypeItem.Binary,
                "ubinary" => ImageEmbeddingInputEmbeddingTypeItem.Ubinary,
                _ => null,
            };
        }
    }
}