//HintName: G.Models.CreateImageRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format in which generated images with `dall-e-2` and `dall-e-3` are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated. This parameter isn't supported for `gpt-image-1` which will always return base64-encoded images.<br/>
    /// Default Value: url<br/>
    /// Example: url
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="b64_json")]
        B64Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestResponseFormat value)
        {
            return value switch
            {
                CreateImageRequestResponseFormat.Url => "url",
                CreateImageRequestResponseFormat.B64Json => "b64_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => CreateImageRequestResponseFormat.Url,
                "b64_json" => CreateImageRequestResponseFormat.B64Json,
                _ => null,
            };
        }
    }
}