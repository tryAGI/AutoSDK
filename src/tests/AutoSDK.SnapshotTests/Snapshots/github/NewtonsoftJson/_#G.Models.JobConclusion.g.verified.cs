//HintName: G.Models.JobConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The outcome of the job.<br/>
    /// Example: success
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JobConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="action_required")]
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neutral")]
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timed_out")]
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobConclusion value)
        {
            return value switch
            {
                JobConclusion.ActionRequired => "action_required",
                JobConclusion.Cancelled => "cancelled",
                JobConclusion.Failure => "failure",
                JobConclusion.Neutral => "neutral",
                JobConclusion.Skipped => "skipped",
                JobConclusion.Success => "success",
                JobConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobConclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => JobConclusion.ActionRequired,
                "cancelled" => JobConclusion.Cancelled,
                "failure" => JobConclusion.Failure,
                "neutral" => JobConclusion.Neutral,
                "skipped" => JobConclusion.Skipped,
                "success" => JobConclusion.Success,
                "timed_out" => JobConclusion.TimedOut,
                _ => null,
            };
        }
    }
}