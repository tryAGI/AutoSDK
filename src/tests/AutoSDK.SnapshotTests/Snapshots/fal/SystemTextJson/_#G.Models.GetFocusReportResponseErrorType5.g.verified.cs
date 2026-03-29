//HintName: G.Models.GetFocusReportResponseErrorType5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetFocusReportResponseErrorType5
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
    public static class GetFocusReportResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFocusReportResponseErrorType5 value)
        {
            return value switch
            {
                GetFocusReportResponseErrorType5.AuthorizationError => "authorization_error",
                GetFocusReportResponseErrorType5.NotFound => "not_found",
                GetFocusReportResponseErrorType5.NotImplemented => "not_implemented",
                GetFocusReportResponseErrorType5.RateLimited => "rate_limited",
                GetFocusReportResponseErrorType5.ServerError => "server_error",
                GetFocusReportResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFocusReportResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetFocusReportResponseErrorType5.AuthorizationError,
                "not_found" => GetFocusReportResponseErrorType5.NotFound,
                "not_implemented" => GetFocusReportResponseErrorType5.NotImplemented,
                "rate_limited" => GetFocusReportResponseErrorType5.RateLimited,
                "server_error" => GetFocusReportResponseErrorType5.ServerError,
                "validation_error" => GetFocusReportResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}