//HintName: G.Models.CreateTextToImageRequestGen4ImageTurboRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resolution of the output image.
    /// </summary>
    public enum CreateTextToImageRequestGen4ImageTurboRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x1024_1024,
        /// <summary>
        /// 
        /// </summary>
        x1080_1080,
        /// <summary>
        /// 
        /// </summary>
        x1080_1440,
        /// <summary>
        /// 
        /// </summary>
        x1080_1920,
        /// <summary>
        /// 
        /// </summary>
        x1168_880,
        /// <summary>
        /// 
        /// </summary>
        x1280_720,
        /// <summary>
        /// 
        /// </summary>
        x1360_768,
        /// <summary>
        /// 
        /// </summary>
        x1440_1080,
        /// <summary>
        /// 
        /// </summary>
        x1680_720,
        /// <summary>
        /// 
        /// </summary>
        x1808_768,
        /// <summary>
        /// 
        /// </summary>
        x1920_1080,
        /// <summary>
        /// 
        /// </summary>
        x2112_912,
        /// <summary>
        /// 
        /// </summary>
        x720_1280,
        /// <summary>
        /// 
        /// </summary>
        x720_720,
        /// <summary>
        /// 
        /// </summary>
        x720_960,
        /// <summary>
        /// 
        /// </summary>
        x960_720,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestGen4ImageTurboRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGen4ImageTurboRatio value)
        {
            return value switch
            {
                CreateTextToImageRequestGen4ImageTurboRatio.x1024_1024 => "1024:1024",
                CreateTextToImageRequestGen4ImageTurboRatio.x1080_1080 => "1080:1080",
                CreateTextToImageRequestGen4ImageTurboRatio.x1080_1440 => "1080:1440",
                CreateTextToImageRequestGen4ImageTurboRatio.x1080_1920 => "1080:1920",
                CreateTextToImageRequestGen4ImageTurboRatio.x1168_880 => "1168:880",
                CreateTextToImageRequestGen4ImageTurboRatio.x1280_720 => "1280:720",
                CreateTextToImageRequestGen4ImageTurboRatio.x1360_768 => "1360:768",
                CreateTextToImageRequestGen4ImageTurboRatio.x1440_1080 => "1440:1080",
                CreateTextToImageRequestGen4ImageTurboRatio.x1680_720 => "1680:720",
                CreateTextToImageRequestGen4ImageTurboRatio.x1808_768 => "1808:768",
                CreateTextToImageRequestGen4ImageTurboRatio.x1920_1080 => "1920:1080",
                CreateTextToImageRequestGen4ImageTurboRatio.x2112_912 => "2112:912",
                CreateTextToImageRequestGen4ImageTurboRatio.x720_1280 => "720:1280",
                CreateTextToImageRequestGen4ImageTurboRatio.x720_720 => "720:720",
                CreateTextToImageRequestGen4ImageTurboRatio.x720_960 => "720:960",
                CreateTextToImageRequestGen4ImageTurboRatio.x960_720 => "960:720",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGen4ImageTurboRatio? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => CreateTextToImageRequestGen4ImageTurboRatio.x1024_1024,
                "1080:1080" => CreateTextToImageRequestGen4ImageTurboRatio.x1080_1080,
                "1080:1440" => CreateTextToImageRequestGen4ImageTurboRatio.x1080_1440,
                "1080:1920" => CreateTextToImageRequestGen4ImageTurboRatio.x1080_1920,
                "1168:880" => CreateTextToImageRequestGen4ImageTurboRatio.x1168_880,
                "1280:720" => CreateTextToImageRequestGen4ImageTurboRatio.x1280_720,
                "1360:768" => CreateTextToImageRequestGen4ImageTurboRatio.x1360_768,
                "1440:1080" => CreateTextToImageRequestGen4ImageTurboRatio.x1440_1080,
                "1680:720" => CreateTextToImageRequestGen4ImageTurboRatio.x1680_720,
                "1808:768" => CreateTextToImageRequestGen4ImageTurboRatio.x1808_768,
                "1920:1080" => CreateTextToImageRequestGen4ImageTurboRatio.x1920_1080,
                "2112:912" => CreateTextToImageRequestGen4ImageTurboRatio.x2112_912,
                "720:1280" => CreateTextToImageRequestGen4ImageTurboRatio.x720_1280,
                "720:720" => CreateTextToImageRequestGen4ImageTurboRatio.x720_720,
                "720:960" => CreateTextToImageRequestGen4ImageTurboRatio.x720_960,
                "960:720" => CreateTextToImageRequestGen4ImageTurboRatio.x960_720,
                _ => null,
            };
        }
    }
}