//HintName: G.Models.GetFocusReportResponseErrorType3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetFocusReportResponseErrorType3
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationError,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        NotImplemented,
        /// <summary>
        /// 
        /// </summary>
        RateLimited,
        /// <summary>
        /// 
        /// </summary>
        ServerError,
        /// <summary>
        /// 
        /// </summary>
        ValidationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFocusReportResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFocusReportResponseErrorType3 value)
        {
            return value switch
            {
                GetFocusReportResponseErrorType3.AuthorizationError => "authorization_error",
                GetFocusReportResponseErrorType3.NotFound => "not_found",
                GetFocusReportResponseErrorType3.NotImplemented => "not_implemented",
                GetFocusReportResponseErrorType3.RateLimited => "rate_limited",
                GetFocusReportResponseErrorType3.ServerError => "server_error",
                GetFocusReportResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFocusReportResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetFocusReportResponseErrorType3.AuthorizationError,
                "not_found" => GetFocusReportResponseErrorType3.NotFound,
                "not_implemented" => GetFocusReportResponseErrorType3.NotImplemented,
                "rate_limited" => GetFocusReportResponseErrorType3.RateLimited,
                "server_error" => GetFocusReportResponseErrorType3.ServerError,
                "validation_error" => GetFocusReportResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}