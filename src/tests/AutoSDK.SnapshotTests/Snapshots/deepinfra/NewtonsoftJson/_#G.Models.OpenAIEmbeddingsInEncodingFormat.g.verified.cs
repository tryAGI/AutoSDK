//HintName: G.Models.OpenAIEmbeddingsInEncodingFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// format used when encoding<br/>
    /// Default Value: float
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIEmbeddingsInEncodingFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="float")]
        Float,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIEmbeddingsInEncodingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIEmbeddingsInEncodingFormat value)
        {
            return value switch
            {
                OpenAIEmbeddingsInEncodingFormat.Float => "float",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIEmbeddingsInEncodingFormat? ToEnum(string value)
        {
            return value switch
            {
                "float" => OpenAIEmbeddingsInEncodingFormat.Float,
                _ => null,
            };
        }
    }
}