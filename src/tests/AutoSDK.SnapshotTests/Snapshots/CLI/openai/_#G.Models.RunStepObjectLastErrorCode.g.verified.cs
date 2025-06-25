//HintName: G.Models.RunStepObjectLastErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `server_error` or `rate_limit_exceeded`.
    /// </summary>
    public enum RunStepObjectLastErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        ServerError,
        /// <summary>
        /// 
        /// </summary>
        RateLimitExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepObjectLastErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepObjectLastErrorCode value)
        {
            return value switch
            {
                RunStepObjectLastErrorCode.ServerError => "server_error",
                RunStepObjectLastErrorCode.RateLimitExceeded => "rate_limit_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepObjectLastErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "server_error" => RunStepObjectLastErrorCode.ServerError,
                "rate_limit_exceeded" => RunStepObjectLastErrorCode.RateLimitExceeded,
                _ => null,
            };
        }
    }
}