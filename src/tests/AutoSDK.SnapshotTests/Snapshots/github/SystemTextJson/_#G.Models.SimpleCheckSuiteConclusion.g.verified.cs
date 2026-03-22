//HintName: G.Models.SimpleCheckSuiteConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: neutral
    /// </summary>
    public enum SimpleCheckSuiteConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Stale,
        /// <summary>
        /// 
        /// </summary>
        StartupFailure,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
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
                SimpleCheckSuiteConclusion.ActionRequired => "action_required",
                SimpleCheckSuiteConclusion.Cancelled => "cancelled",
                SimpleCheckSuiteConclusion.Failure => "failure",
                SimpleCheckSuiteConclusion.Neutral => "neutral",
                SimpleCheckSuiteConclusion.Skipped => "skipped",
                SimpleCheckSuiteConclusion.Stale => "stale",
                SimpleCheckSuiteConclusion.StartupFailure => "startup_failure",
                SimpleCheckSuiteConclusion.Success => "success",
                SimpleCheckSuiteConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimpleCheckSuiteConclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => SimpleCheckSuiteConclusion.ActionRequired,
                "cancelled" => SimpleCheckSuiteConclusion.Cancelled,
                "failure" => SimpleCheckSuiteConclusion.Failure,
                "neutral" => SimpleCheckSuiteConclusion.Neutral,
                "skipped" => SimpleCheckSuiteConclusion.Skipped,
                "stale" => SimpleCheckSuiteConclusion.Stale,
                "startup_failure" => SimpleCheckSuiteConclusion.StartupFailure,
                "success" => SimpleCheckSuiteConclusion.Success,
                "timed_out" => SimpleCheckSuiteConclusion.TimedOut,
                _ => null,
            };
        }
    }
}