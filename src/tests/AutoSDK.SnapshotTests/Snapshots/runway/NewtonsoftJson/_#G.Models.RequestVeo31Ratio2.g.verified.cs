//HintName: G.Models.RequestVeo31Ratio2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RequestVeo31Ratio2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1280:720")]
        x1280_720,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="720:1280")]
        x720_1280,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1080:1920")]
        x1080_1920,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1920:1080")]
        x1920_1080,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestVeo31Ratio2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVeo31Ratio2 value)
        {
            return value switch
            {
                RequestVeo31Ratio2.x1280_720 => "1280:720",
                RequestVeo31Ratio2.x720_1280 => "720:1280",
                RequestVeo31Ratio2.x1080_1920 => "1080:1920",
                RequestVeo31Ratio2.x1920_1080 => "1920:1080",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVeo31Ratio2? ToEnum(string value)
        {
            return value switch
            {
                "1280:720" => RequestVeo31Ratio2.x1280_720,
                "720:1280" => RequestVeo31Ratio2.x720_1280,
                "1080:1920" => RequestVeo31Ratio2.x1080_1920,
                "1920:1080" => RequestVeo31Ratio2.x1920_1080,
                _ => null,
            };
        }
    }
}