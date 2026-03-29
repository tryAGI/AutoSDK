//HintName: G.Models.GetClipsResponseClipConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result<br/>
    /// Default Value: mp4
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetClipsResponseClipConfigResultFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mov")]
        Mov,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp4")]
        Mp4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webm")]
        Webm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetClipsResponseClipConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetClipsResponseClipConfigResultFormat value)
        {
            return value switch
            {
                GetClipsResponseClipConfigResultFormat.Mov => "mov",
                GetClipsResponseClipConfigResultFormat.Mp4 => "mp4",
                GetClipsResponseClipConfigResultFormat.Webm => "webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetClipsResponseClipConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => GetClipsResponseClipConfigResultFormat.Mov,
                "mp4" => GetClipsResponseClipConfigResultFormat.Mp4,
                "webm" => GetClipsResponseClipConfigResultFormat.Webm,
                _ => null,
            };
        }
    }
}