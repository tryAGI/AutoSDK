//HintName: G.Models.EncodingFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enumeration of encoding formats.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EncodingFormat
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
        [global::System.Runtime.Serialization.EnumMember(Value="float16")]
        Float16,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="int8")]
        Int8,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ubinary")]
        Ubinary,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uint8")]
        Uint8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EncodingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EncodingFormat value)
        {
            return value switch
            {
                EncodingFormat.Base64 => "base64",
                EncodingFormat.Binary => "binary",
                EncodingFormat.Float => "float",
                EncodingFormat.Float16 => "float16",
                EncodingFormat.Int8 => "int8",
                EncodingFormat.Ubinary => "ubinary",
                EncodingFormat.Uint8 => "uint8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EncodingFormat? ToEnum(string value)
        {
            return value switch
            {
                "base64" => EncodingFormat.Base64,
                "binary" => EncodingFormat.Binary,
                "float" => EncodingFormat.Float,
                "float16" => EncodingFormat.Float16,
                "int8" => EncodingFormat.Int8,
                "ubinary" => EncodingFormat.Ubinary,
                "uint8" => EncodingFormat.Uint8,
                _ => null,
            };
        }
    }
}