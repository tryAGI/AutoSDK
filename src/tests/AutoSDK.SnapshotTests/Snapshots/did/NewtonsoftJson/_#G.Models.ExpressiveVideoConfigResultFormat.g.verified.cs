//HintName: G.Models.ExpressiveVideoConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The file format of the result. If result_url is provided, result_format must match the format of the result_url.<br/>
    /// Example: mp4
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExpressiveVideoConfigResultFormat
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
    public static class ExpressiveVideoConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveVideoConfigResultFormat value)
        {
            return value switch
            {
                ExpressiveVideoConfigResultFormat.Mov => "mov",
                ExpressiveVideoConfigResultFormat.Mp4 => "mp4",
                ExpressiveVideoConfigResultFormat.Webm => "webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveVideoConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => ExpressiveVideoConfigResultFormat.Mov,
                "mp4" => ExpressiveVideoConfigResultFormat.Mp4,
                "webm" => ExpressiveVideoConfigResultFormat.Webm,
                _ => null,
            };
        }
    }
}