//HintName: G.Models.CreateImageVariationRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated.
    /// <br/>Default Value: url
    /// <br/>Example: url
    /// </summary>
    public enum CreateImageVariationRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        B64Json,
    }

    public static class CreateImageVariationRequestResponseFormatExtensions
    {
        public static string ToValueString(this CreateImageVariationRequestResponseFormat value)
        {
            return value switch
            {
                CreateImageVariationRequestResponseFormat.Url => "url",
                CreateImageVariationRequestResponseFormat.B64Json => "b64_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageVariationRequestResponseFormat ToEnum(string value)
        {
            return value switch
            {
                "url" => CreateImageVariationRequestResponseFormat.Url,
                "b64_json" => CreateImageVariationRequestResponseFormat.B64Json,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageVariationRequestResponseFormat ToEnum(int value)
        {
            return value switch
            {
                0 => CreateImageVariationRequestResponseFormat.Url,
                1 => CreateImageVariationRequestResponseFormat.B64Json,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}