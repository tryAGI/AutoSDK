//HintName: G.Models.MediaFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Format of the media data.<br/>
    /// Default Value: neither
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MediaFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base64")]
        Base64,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neither")]
        Neither,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MediaFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MediaFormat value)
        {
            return value switch
            {
                MediaFormat.Base64 => "base64",
                MediaFormat.Neither => "neither",
                MediaFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MediaFormat? ToEnum(string value)
        {
            return value switch
            {
                "base64" => MediaFormat.Base64,
                "neither" => MediaFormat.Neither,
                "url" => MediaFormat.Url,
                _ => null,
            };
        }
    }
}