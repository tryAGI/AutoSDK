//HintName: G.Models.CreateImageEditRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated.
    /// <br/>Default Value: url
    /// <br/>Example: url
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageEditRequestResponseFormat
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

    public static class CreateImageEditRequestResponseFormatExtensions
    {
        public static string ToValueString(this CreateImageEditRequestResponseFormat value)
        {
            return value switch
            {
                CreateImageEditRequestResponseFormat.Url => "url",
                CreateImageEditRequestResponseFormat.B64Json => "b64_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageEditRequestResponseFormat ToEnum(string value)
        {
            return value switch
            {
                "url" => CreateImageEditRequestResponseFormat.Url,
                "b64_json" => CreateImageEditRequestResponseFormat.B64Json,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageEditRequestResponseFormat ToEnum(int value)
        {
            return value switch
            {
                0 => CreateImageEditRequestResponseFormat.Url,
                1 => CreateImageEditRequestResponseFormat.B64Json,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}