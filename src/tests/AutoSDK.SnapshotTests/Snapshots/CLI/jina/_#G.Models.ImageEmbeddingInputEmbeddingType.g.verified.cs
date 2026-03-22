//HintName: G.Models.ImageEmbeddingInputEmbeddingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageEmbeddingInputEmbeddingType
    {
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
        Float,
        /// <summary>
        /// 
        /// </summary>
        Ubinary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageEmbeddingInputEmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEmbeddingInputEmbeddingType value)
        {
            return value switch
            {
                ImageEmbeddingInputEmbeddingType.Base64 => "base64",
                ImageEmbeddingInputEmbeddingType.Binary => "binary",
                ImageEmbeddingInputEmbeddingType.Float => "float",
                ImageEmbeddingInputEmbeddingType.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEmbeddingInputEmbeddingType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => ImageEmbeddingInputEmbeddingType.Base64,
                "binary" => ImageEmbeddingInputEmbeddingType.Binary,
                "float" => ImageEmbeddingInputEmbeddingType.Float,
                "ubinary" => ImageEmbeddingInputEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}