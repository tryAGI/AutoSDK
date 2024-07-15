//HintName: G.Models.CheckRunWithSimpleCheckSuiteConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: neutral
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CheckRunWithSimpleCheckSuiteConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="waiting")]
        Waiting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="startup_failure")]
        StartupFailure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stale")]
        Stale,
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
    public static class CheckRunWithSimpleCheckSuiteConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckRunWithSimpleCheckSuiteConclusion value)
        {
            return value switch
            {
                CheckRunWithSimpleCheckSuiteConclusion.Waiting => "waiting",
                CheckRunWithSimpleCheckSuiteConclusion.Pending => "pending",
                CheckRunWithSimpleCheckSuiteConclusion.StartupFailure => "startup_failure",
                CheckRunWithSimpleCheckSuiteConclusion.Stale => "stale",
                CheckRunWithSimpleCheckSuiteConclusion.Success => "success",
                CheckRunWithSimpleCheckSuiteConclusion.Failure => "failure",
                CheckRunWithSimpleCheckSuiteConclusion.Neutral => "neutral",
                CheckRunWithSimpleCheckSuiteConclusion.Cancelled => "cancelled",
                CheckRunWithSimpleCheckSuiteConclusion.Skipped => "skipped",
                CheckRunWithSimpleCheckSuiteConclusion.TimedOut => "timed_out",
                CheckRunWithSimpleCheckSuiteConclusion.ActionRequired => "action_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckRunWithSimpleCheckSuiteConclusion? ToEnum(string value)
        {
            return value switch
            {
                "waiting" => CheckRunWithSimpleCheckSuiteConclusion.Waiting,
                "pending" => CheckRunWithSimpleCheckSuiteConclusion.Pending,
                "startup_failure" => CheckRunWithSimpleCheckSuiteConclusion.StartupFailure,
                "stale" => CheckRunWithSimpleCheckSuiteConclusion.Stale,
                "success" => CheckRunWithSimpleCheckSuiteConclusion.Success,
                "failure" => CheckRunWithSimpleCheckSuiteConclusion.Failure,
                "neutral" => CheckRunWithSimpleCheckSuiteConclusion.Neutral,
                "cancelled" => CheckRunWithSimpleCheckSuiteConclusion.Cancelled,
                "skipped" => CheckRunWithSimpleCheckSuiteConclusion.Skipped,
                "timed_out" => CheckRunWithSimpleCheckSuiteConclusion.TimedOut,
                "action_required" => CheckRunWithSimpleCheckSuiteConclusion.ActionRequired,
                _ => null,
            };
        }
    }
}