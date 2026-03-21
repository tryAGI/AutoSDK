//HintName: G.Models.CreateImageToVideoRequestGen3aTurboRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resolution of the output video.<br/>
    /// Example: 1280:768
    /// </summary>
    public enum CreateImageToVideoRequestGen3aTurboRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x768_1280,
        /// <summary>
        /// 
        /// </summary>
        x1280_768,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestGen3aTurboRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestGen3aTurboRatio value)
        {
            return value switch
            {
                CreateImageToVideoRequestGen3aTurboRatio.x768_1280 => "768:1280",
                CreateImageToVideoRequestGen3aTurboRatio.x1280_768 => "1280:768",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestGen3aTurboRatio? ToEnum(string value)
        {
            return value switch
            {
                "768:1280" => CreateImageToVideoRequestGen3aTurboRatio.x768_1280,
                "1280:768" => CreateImageToVideoRequestGen3aTurboRatio.x1280_768,
                _ => null,
            };
        }
    }
}