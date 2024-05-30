//HintName: G.Models.CreateImageRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated.
    /// <br/>Default Value: url
    /// <br/>Example: url
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

    public static class CreateImageRequestResponseFormatExtensions
    {
        public static string ToValueString(this CreateImageRequestResponseFormat value)
        {
            return value switch
            {
                CreateImageRequestResponseFormat.Url => "url",
                CreateImageRequestResponseFormat.B64Json => "b64_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageRequestResponseFormat ToEnum(string value)
        {
            return value switch
            {
                "url" => CreateImageRequestResponseFormat.Url,
                "b64_json" => CreateImageRequestResponseFormat.B64Json,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageRequestResponseFormat ToEnum(int value)
        {
            return value switch
            {
                0 => CreateImageRequestResponseFormat.Url,
                1 => CreateImageRequestResponseFormat.B64Json,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}