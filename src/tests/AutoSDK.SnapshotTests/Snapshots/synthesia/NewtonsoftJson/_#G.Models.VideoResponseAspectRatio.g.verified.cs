//HintName: G.Models.VideoResponseAspectRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aspect ratio of the video. Default is `landscape (16:9)`.<br/>
    /// Default Value: 16:9
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VideoResponseAspectRatio
    {
        /// <summary>
        /// 9)`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="16:9")]
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1:1")]
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="4:5")]
        x4_5,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="5:4")]
        x5_4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="9:16")]
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoResponseAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoResponseAspectRatio value)
        {
            return value switch
            {
                VideoResponseAspectRatio.x16_9 => "16:9",
                VideoResponseAspectRatio.x1_1 => "1:1",
                VideoResponseAspectRatio.x4_5 => "4:5",
                VideoResponseAspectRatio.x5_4 => "5:4",
                VideoResponseAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoResponseAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => VideoResponseAspectRatio.x16_9,
                "1:1" => VideoResponseAspectRatio.x1_1,
                "4:5" => VideoResponseAspectRatio.x4_5,
                "5:4" => VideoResponseAspectRatio.x5_4,
                "9:16" => VideoResponseAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}