//HintName: G.Models.NaturalnessIssue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum NaturalnessIssue
    {
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        RoboticTone,
        /// <summary>
        /// 
        /// </summary>
        TooFast,
        /// <summary>
        /// 
        /// </summary>
        TooLoud,
        /// <summary>
        /// 
        /// </summary>
        TooQuiet,
        /// <summary>
        /// 
        /// </summary>
        TooSlow,
        /// <summary>
        /// 
        /// </summary>
        UnclearPronunciation,
        /// <summary>
        /// 
        /// </summary>
        UnnaturalPauses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NaturalnessIssueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NaturalnessIssue value)
        {
            return value switch
            {
                NaturalnessIssue.Other => "Other",
                NaturalnessIssue.RoboticTone => "Robotic Tone",
                NaturalnessIssue.TooFast => "Too Fast",
                NaturalnessIssue.TooLoud => "Too Loud",
                NaturalnessIssue.TooQuiet => "Too Quiet",
                NaturalnessIssue.TooSlow => "Too Slow",
                NaturalnessIssue.UnclearPronunciation => "Unclear Pronunciation",
                NaturalnessIssue.UnnaturalPauses => "Unnatural Pauses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NaturalnessIssue? ToEnum(string value)
        {
            return value switch
            {
                "Other" => NaturalnessIssue.Other,
                "Robotic Tone" => NaturalnessIssue.RoboticTone,
                "Too Fast" => NaturalnessIssue.TooFast,
                "Too Loud" => NaturalnessIssue.TooLoud,
                "Too Quiet" => NaturalnessIssue.TooQuiet,
                "Too Slow" => NaturalnessIssue.TooSlow,
                "Unclear Pronunciation" => NaturalnessIssue.UnclearPronunciation,
                "Unnatural Pauses" => NaturalnessIssue.UnnaturalPauses,
                _ => null,
            };
        }
    }
}