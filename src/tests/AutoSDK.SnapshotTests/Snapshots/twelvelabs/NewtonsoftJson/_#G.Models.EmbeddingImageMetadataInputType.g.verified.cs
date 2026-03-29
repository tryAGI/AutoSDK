//HintName: G.Models.EmbeddingImageMetadataInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbeddingImageMetadataInputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingImageMetadataInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingImageMetadataInputType value)
        {
            return value switch
            {
                EmbeddingImageMetadataInputType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingImageMetadataInputType? ToEnum(string value)
        {
            return value switch
            {
                "image" => EmbeddingImageMetadataInputType.Image,
                _ => null,
            };
        }
    }
}