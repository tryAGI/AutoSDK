//HintName: G.Models.ImageToImageRequestBodyDiscriminatorInitImageMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageToImageRequestBodyDiscriminatorInitImageMode
    {
        /// <summary>
        /// 
        /// </summary>
        ImageStrength,
        /// <summary>
        /// 
        /// </summary>
        StepSchedule,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageToImageRequestBodyDiscriminatorInitImageModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageToImageRequestBodyDiscriminatorInitImageMode value)
        {
            return value switch
            {
                ImageToImageRequestBodyDiscriminatorInitImageMode.ImageStrength => "IMAGE_STRENGTH",
                ImageToImageRequestBodyDiscriminatorInitImageMode.StepSchedule => "STEP_SCHEDULE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageToImageRequestBodyDiscriminatorInitImageMode? ToEnum(string value)
        {
            return value switch
            {
                "IMAGE_STRENGTH" => ImageToImageRequestBodyDiscriminatorInitImageMode.ImageStrength,
                "STEP_SCHEDULE" => ImageToImageRequestBodyDiscriminatorInitImageMode.StepSchedule,
                _ => null,
            };
        }
    }
}