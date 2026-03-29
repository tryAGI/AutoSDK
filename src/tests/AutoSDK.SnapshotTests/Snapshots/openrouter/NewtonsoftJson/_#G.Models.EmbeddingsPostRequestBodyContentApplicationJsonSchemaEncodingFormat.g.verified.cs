//HintName: G.Models.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base64")]
        Base64,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="float")]
        Float,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat value)
        {
            return value switch
            {
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat.Base64 => "base64",
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat.Float => "float",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat? ToEnum(string value)
        {
            return value switch
            {
                "base64" => EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat.Base64,
                "float" => EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat.Float,
                _ => null,
            };
        }
    }
}