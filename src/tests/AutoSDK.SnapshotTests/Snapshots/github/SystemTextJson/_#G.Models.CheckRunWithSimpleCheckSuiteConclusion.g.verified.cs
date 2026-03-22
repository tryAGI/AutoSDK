//HintName: G.Models.CheckRunWithSimpleCheckSuiteConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: neutral
    /// </summary>
    public enum CheckRunWithSimpleCheckSuiteConclusion
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
        Pending,
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
        /// <summary>
        /// 
        /// </summary>
        Waiting,
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
                CheckRunWithSimpleCheckSuiteConclusion.ActionRequired => "action_required",
                CheckRunWithSimpleCheckSuiteConclusion.Cancelled => "cancelled",
                CheckRunWithSimpleCheckSuiteConclusion.Failure => "failure",
                CheckRunWithSimpleCheckSuiteConclusion.Neutral => "neutral",
                CheckRunWithSimpleCheckSuiteConclusion.Pending => "pending",
                CheckRunWithSimpleCheckSuiteConclusion.Skipped => "skipped",
                CheckRunWithSimpleCheckSuiteConclusion.Stale => "stale",
                CheckRunWithSimpleCheckSuiteConclusion.StartupFailure => "startup_failure",
                CheckRunWithSimpleCheckSuiteConclusion.Success => "success",
                CheckRunWithSimpleCheckSuiteConclusion.TimedOut => "timed_out",
                CheckRunWithSimpleCheckSuiteConclusion.Waiting => "waiting",
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
                "action_required" => CheckRunWithSimpleCheckSuiteConclusion.ActionRequired,
                "cancelled" => CheckRunWithSimpleCheckSuiteConclusion.Cancelled,
                "failure" => CheckRunWithSimpleCheckSuiteConclusion.Failure,
                "neutral" => CheckRunWithSimpleCheckSuiteConclusion.Neutral,
                "pending" => CheckRunWithSimpleCheckSuiteConclusion.Pending,
                "skipped" => CheckRunWithSimpleCheckSuiteConclusion.Skipped,
                "stale" => CheckRunWithSimpleCheckSuiteConclusion.Stale,
                "startup_failure" => CheckRunWithSimpleCheckSuiteConclusion.StartupFailure,
                "success" => CheckRunWithSimpleCheckSuiteConclusion.Success,
                "timed_out" => CheckRunWithSimpleCheckSuiteConclusion.TimedOut,
                "waiting" => CheckRunWithSimpleCheckSuiteConclusion.Waiting,
                _ => null,
            };
        }
    }
}