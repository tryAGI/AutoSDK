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
        Success,
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
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        StartupFailure,
        /// <summary>
        /// 
        /// </summary>
        Stale,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
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
                CheckSuiteConclusion.Success => "success",
                CheckSuiteConclusion.Failure => "failure",
                CheckSuiteConclusion.Neutral => "neutral",
                CheckSuiteConclusion.Cancelled => "cancelled",
                CheckSuiteConclusion.Skipped => "skipped",
                CheckSuiteConclusion.TimedOut => "timed_out",
                CheckSuiteConclusion.ActionRequired => "action_required",
                CheckSuiteConclusion.StartupFailure => "startup_failure",
                CheckSuiteConclusion.Stale => "stale",
                CheckSuiteConclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
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
                "success" => CheckSuiteConclusion.Success,
                "failure" => CheckSuiteConclusion.Failure,
                "neutral" => CheckSuiteConclusion.Neutral,
                "cancelled" => CheckSuiteConclusion.Cancelled,
                "skipped" => CheckSuiteConclusion.Skipped,
                "timed_out" => CheckSuiteConclusion.TimedOut,
                "action_required" => CheckSuiteConclusion.ActionRequired,
                "startup_failure" => CheckSuiteConclusion.StartupFailure,
                "stale" => CheckSuiteConclusion.Stale,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => CheckSuiteConclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}