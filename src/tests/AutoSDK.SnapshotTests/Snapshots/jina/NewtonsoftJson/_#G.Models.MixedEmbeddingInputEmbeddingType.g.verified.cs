//HintName: G.Models.MixedEmbeddingInputEmbeddingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MixedEmbeddingInputEmbeddingType
    {
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
        [global::System.Runtime.Serialization.EnumMember(Value="float")]
        Float,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ubinary")]
        Ubinary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MixedEmbeddingInputEmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MixedEmbeddingInputEmbeddingType value)
        {
            return value switch
            {
                MixedEmbeddingInputEmbeddingType.Base64 => "base64",
                MixedEmbeddingInputEmbeddingType.Binary => "binary",
                MixedEmbeddingInputEmbeddingType.Float => "float",
                MixedEmbeddingInputEmbeddingType.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MixedEmbeddingInputEmbeddingType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => MixedEmbeddingInputEmbeddingType.Base64,
                "binary" => MixedEmbeddingInputEmbeddingType.Binary,
                "float" => MixedEmbeddingInputEmbeddingType.Float,
                "ubinary" => MixedEmbeddingInputEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}