//HintName: G.Models.NaturalnessIssue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NaturalnessIssue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Other")]
        Other,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Robotic Tone")]
        RoboticTone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Too Fast")]
        TooFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Too Loud")]
        TooLoud,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Too Quiet")]
        TooQuiet,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Too Slow")]
        TooSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Unclear Pronunciation")]
        UnclearPronunciation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Unnatural Pauses")]
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