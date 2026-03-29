//HintName: G.Models.InvocationsGetResponseCauseCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InvocationsGetResponseCauseCode
    {
        /// <summary>
        /// 
        /// </summary>
        InternalError,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        WorkloadError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InvocationsGetResponseCauseCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvocationsGetResponseCauseCode value)
        {
            return value switch
            {
                InvocationsGetResponseCauseCode.InternalError => "INTERNAL_ERROR",
                InvocationsGetResponseCauseCode.TimedOut => "TIMED_OUT",
                InvocationsGetResponseCauseCode.WorkloadError => "WORKLOAD_ERROR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvocationsGetResponseCauseCode? ToEnum(string value)
        {
            return value switch
            {
                "INTERNAL_ERROR" => InvocationsGetResponseCauseCode.InternalError,
                "TIMED_OUT" => InvocationsGetResponseCauseCode.TimedOut,
                "WORKLOAD_ERROR" => InvocationsGetResponseCauseCode.WorkloadError,
                _ => null,
            };
        }
    }
}