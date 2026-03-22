//HintName: G.Models.CreateImageToVideoRequestVeo3Ratio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageToVideoRequestVeo3Ratio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1080:1920")]
        x1080_1920,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1280:720")]
        x1280_720,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1920:1080")]
        x1920_1080,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="720:1280")]
        x720_1280,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestVeo3RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestVeo3Ratio value)
        {
            return value switch
            {
                CreateImageToVideoRequestVeo3Ratio.x1080_1920 => "1080:1920",
                CreateImageToVideoRequestVeo3Ratio.x1280_720 => "1280:720",
                CreateImageToVideoRequestVeo3Ratio.x1920_1080 => "1920:1080",
                CreateImageToVideoRequestVeo3Ratio.x720_1280 => "720:1280",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestVeo3Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1080:1920" => CreateImageToVideoRequestVeo3Ratio.x1080_1920,
                "1280:720" => CreateImageToVideoRequestVeo3Ratio.x1280_720,
                "1920:1080" => CreateImageToVideoRequestVeo3Ratio.x1920_1080,
                "720:1280" => CreateImageToVideoRequestVeo3Ratio.x720_1280,
                _ => null,
            };
        }
    }
}