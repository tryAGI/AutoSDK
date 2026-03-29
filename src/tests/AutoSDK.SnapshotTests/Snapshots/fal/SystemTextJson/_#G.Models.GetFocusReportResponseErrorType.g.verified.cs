//HintName: G.Models.GetFocusReportResponseErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetFocusReportResponseErrorType
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
    public static class GetFocusReportResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFocusReportResponseErrorType value)
        {
            return value switch
            {
                GetFocusReportResponseErrorType.AuthorizationError => "authorization_error",
                GetFocusReportResponseErrorType.NotFound => "not_found",
                GetFocusReportResponseErrorType.NotImplemented => "not_implemented",
                GetFocusReportResponseErrorType.RateLimited => "rate_limited",
                GetFocusReportResponseErrorType.ServerError => "server_error",
                GetFocusReportResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFocusReportResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetFocusReportResponseErrorType.AuthorizationError,
                "not_found" => GetFocusReportResponseErrorType.NotFound,
                "not_implemented" => GetFocusReportResponseErrorType.NotImplemented,
                "rate_limited" => GetFocusReportResponseErrorType.RateLimited,
                "server_error" => GetFocusReportResponseErrorType.ServerError,
                "validation_error" => GetFocusReportResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}