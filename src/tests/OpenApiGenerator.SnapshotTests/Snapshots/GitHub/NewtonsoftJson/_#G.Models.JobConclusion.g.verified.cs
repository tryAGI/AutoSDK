//HintName: G.Models.JobConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The outcome of the job.
    /// <br/>Example: success
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JobConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
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
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timed_out")]
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="action_required")]
        ActionRequired,
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
                JobConclusion.Success => "success",
                JobConclusion.Failure => "failure",
                JobConclusion.Neutral => "neutral",
                JobConclusion.Cancelled => "cancelled",
                JobConclusion.Skipped => "skipped",
                JobConclusion.TimedOut => "timed_out",
                JobConclusion.ActionRequired => "action_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobConclusion ToEnum(string value)
        {
            return value switch
            {
                "success" => JobConclusion.Success,
                "failure" => JobConclusion.Failure,
                "neutral" => JobConclusion.Neutral,
                "cancelled" => JobConclusion.Cancelled,
                "skipped" => JobConclusion.Skipped,
                "timed_out" => JobConclusion.TimedOut,
                "action_required" => JobConclusion.ActionRequired,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}