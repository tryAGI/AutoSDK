//HintName: G.Models.GetClipResponseConfigResultFormat2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result<br/>
    /// Default Value: mp4
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetClipResponseConfigResultFormat2
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
    public static class GetClipResponseConfigResultFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetClipResponseConfigResultFormat2 value)
        {
            return value switch
            {
                GetClipResponseConfigResultFormat2.Mov => "mov",
                GetClipResponseConfigResultFormat2.Mp4 => "mp4",
                GetClipResponseConfigResultFormat2.Webm => "webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetClipResponseConfigResultFormat2? ToEnum(string value)
        {
            return value switch
            {
                "mov" => GetClipResponseConfigResultFormat2.Mov,
                "mp4" => GetClipResponseConfigResultFormat2.Mp4,
                "webm" => GetClipResponseConfigResultFormat2.Webm,
                _ => null,
            };
        }
    }
}