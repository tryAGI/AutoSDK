//HintName: G.Models.SimpleCheckSuiteConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: neutral
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SimpleCheckSuiteConclusion
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stale")]
        Stale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="startup_failure")]
        StartupFailure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimpleCheckSuiteConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimpleCheckSuiteConclusion value)
        {
            return value switch
            {
                SimpleCheckSuiteConclusion.Success => "success",
                SimpleCheckSuiteConclusion.Failure => "failure",
                SimpleCheckSuiteConclusion.Neutral => "neutral",
                SimpleCheckSuiteConclusion.Cancelled => "cancelled",
                SimpleCheckSuiteConclusion.Skipped => "skipped",
                SimpleCheckSuiteConclusion.TimedOut => "timed_out",
                SimpleCheckSuiteConclusion.ActionRequired => "action_required",
                SimpleCheckSuiteConclusion.Stale => "stale",
                SimpleCheckSuiteConclusion.StartupFailure => "startup_failure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimpleCheckSuiteConclusion ToEnum(string value)
        {
            return value switch
            {
                "success" => SimpleCheckSuiteConclusion.Success,
                "failure" => SimpleCheckSuiteConclusion.Failure,
                "neutral" => SimpleCheckSuiteConclusion.Neutral,
                "cancelled" => SimpleCheckSuiteConclusion.Cancelled,
                "skipped" => SimpleCheckSuiteConclusion.Skipped,
                "timed_out" => SimpleCheckSuiteConclusion.TimedOut,
                "action_required" => SimpleCheckSuiteConclusion.ActionRequired,
                "stale" => SimpleCheckSuiteConclusion.Stale,
                "startup_failure" => SimpleCheckSuiteConclusion.StartupFailure,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}