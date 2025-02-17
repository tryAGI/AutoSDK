﻿//HintName: G.Models.ImageEmbeddingInputEmbeddingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageEmbeddingInputEmbeddingType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="float")]
        Float,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base64")]
        Base64,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="binary")]
        Binary,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ubinary")]
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
                ImageEmbeddingInputEmbeddingType.Float => "float",
                ImageEmbeddingInputEmbeddingType.Base64 => "base64",
                ImageEmbeddingInputEmbeddingType.Binary => "binary",
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
                "float" => ImageEmbeddingInputEmbeddingType.Float,
                "base64" => ImageEmbeddingInputEmbeddingType.Base64,
                "binary" => ImageEmbeddingInputEmbeddingType.Binary,
                "ubinary" => ImageEmbeddingInputEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}