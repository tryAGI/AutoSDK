//HintName: G.Models.CheckSuiteConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: neutral
    /// </summary>
    public enum CheckSuiteConclusion
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
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
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
    public static class CheckSuiteConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckSuiteConclusion value)
        {
            return value switch
            {
                CheckSuiteConclusion.ActionRequired => "action_required",
                CheckSuiteConclusion.Cancelled => "cancelled",
                CheckSuiteConclusion.Failure => "failure",
                CheckSuiteConclusion.Neutral => "neutral",
                CheckSuiteConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                CheckSuiteConclusion.Skipped => "skipped",
                CheckSuiteConclusion.Stale => "stale",
                CheckSuiteConclusion.StartupFailure => "startup_failure",
                CheckSuiteConclusion.Success => "success",
                CheckSuiteConclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckSuiteConclusion? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => CheckSuiteConclusion.ActionRequired,
                "cancelled" => CheckSuiteConclusion.Cancelled,
                "failure" => CheckSuiteConclusion.Failure,
                "neutral" => CheckSuiteConclusion.Neutral,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => CheckSuiteConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "skipped" => CheckSuiteConclusion.Skipped,
                "stale" => CheckSuiteConclusion.Stale,
                "startup_failure" => CheckSuiteConclusion.StartupFailure,
                "success" => CheckSuiteConclusion.Success,
                "timed_out" => CheckSuiteConclusion.TimedOut,
                _ => null,
            };
        }
    }
}