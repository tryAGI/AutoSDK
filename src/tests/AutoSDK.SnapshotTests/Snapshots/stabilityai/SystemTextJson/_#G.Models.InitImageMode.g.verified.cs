//HintName: G.Models.InitImageMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to use `image_strength` or `step_schedule_*` to control how much influence the `init_image` has on the result.<br/>
    /// Default Value: IMAGE_STRENGTH
    /// </summary>
    public enum InitImageMode
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
    public static class InitImageModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InitImageMode value)
        {
            return value switch
            {
                InitImageMode.ImageStrength => "IMAGE_STRENGTH",
                InitImageMode.StepSchedule => "STEP_SCHEDULE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InitImageMode? ToEnum(string value)
        {
            return value switch
            {
                "IMAGE_STRENGTH" => InitImageMode.ImageStrength,
                "STEP_SCHEDULE" => InitImageMode.StepSchedule,
                _ => null,
            };
        }
    }
}