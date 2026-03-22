//HintName: G.Models.CreateTextToImageRequestGen4ImageRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resolution of the output image.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTextToImageRequestGen4ImageRatio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024:1024")]
        x1024_1024,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1080:1080")]
        x1080_1080,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1080:1440")]
        x1080_1440,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1080:1920")]
        x1080_1920,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1168:880")]
        x1168_880,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1280:720")]
        x1280_720,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1360:768")]
        x1360_768,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1440:1080")]
        x1440_1080,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1680:720")]
        x1680_720,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1808:768")]
        x1808_768,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1920:1080")]
        x1920_1080,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2112:912")]
        x2112_912,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="720:1280")]
        x720_1280,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="720:720")]
        x720_720,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="720:960")]
        x720_960,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="960:720")]
        x960_720,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestGen4ImageRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGen4ImageRatio value)
        {
            return value switch
            {
                CreateTextToImageRequestGen4ImageRatio.x1024_1024 => "1024:1024",
                CreateTextToImageRequestGen4ImageRatio.x1080_1080 => "1080:1080",
                CreateTextToImageRequestGen4ImageRatio.x1080_1440 => "1080:1440",
                CreateTextToImageRequestGen4ImageRatio.x1080_1920 => "1080:1920",
                CreateTextToImageRequestGen4ImageRatio.x1168_880 => "1168:880",
                CreateTextToImageRequestGen4ImageRatio.x1280_720 => "1280:720",
                CreateTextToImageRequestGen4ImageRatio.x1360_768 => "1360:768",
                CreateTextToImageRequestGen4ImageRatio.x1440_1080 => "1440:1080",
                CreateTextToImageRequestGen4ImageRatio.x1680_720 => "1680:720",
                CreateTextToImageRequestGen4ImageRatio.x1808_768 => "1808:768",
                CreateTextToImageRequestGen4ImageRatio.x1920_1080 => "1920:1080",
                CreateTextToImageRequestGen4ImageRatio.x2112_912 => "2112:912",
                CreateTextToImageRequestGen4ImageRatio.x720_1280 => "720:1280",
                CreateTextToImageRequestGen4ImageRatio.x720_720 => "720:720",
                CreateTextToImageRequestGen4ImageRatio.x720_960 => "720:960",
                CreateTextToImageRequestGen4ImageRatio.x960_720 => "960:720",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGen4ImageRatio? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => CreateTextToImageRequestGen4ImageRatio.x1024_1024,
                "1080:1080" => CreateTextToImageRequestGen4ImageRatio.x1080_1080,
                "1080:1440" => CreateTextToImageRequestGen4ImageRatio.x1080_1440,
                "1080:1920" => CreateTextToImageRequestGen4ImageRatio.x1080_1920,
                "1168:880" => CreateTextToImageRequestGen4ImageRatio.x1168_880,
                "1280:720" => CreateTextToImageRequestGen4ImageRatio.x1280_720,
                "1360:768" => CreateTextToImageRequestGen4ImageRatio.x1360_768,
                "1440:1080" => CreateTextToImageRequestGen4ImageRatio.x1440_1080,
                "1680:720" => CreateTextToImageRequestGen4ImageRatio.x1680_720,
                "1808:768" => CreateTextToImageRequestGen4ImageRatio.x1808_768,
                "1920:1080" => CreateTextToImageRequestGen4ImageRatio.x1920_1080,
                "2112:912" => CreateTextToImageRequestGen4ImageRatio.x2112_912,
                "720:1280" => CreateTextToImageRequestGen4ImageRatio.x720_1280,
                "720:720" => CreateTextToImageRequestGen4ImageRatio.x720_720,
                "720:960" => CreateTextToImageRequestGen4ImageRatio.x720_960,
                "960:720" => CreateTextToImageRequestGen4ImageRatio.x960_720,
                _ => null,
            };
        }
    }
}