//HintName: G.Models.GetFocusReportResponseErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetFocusReportResponseErrorType2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="authorization_error")]
        AuthorizationError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_found")]
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_implemented")]
        NotImplemented,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rate_limited")]
        RateLimited,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="server_error")]
        ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validation_error")]
        ValidationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFocusReportResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFocusReportResponseErrorType2 value)
        {
            return value switch
            {
                GetFocusReportResponseErrorType2.AuthorizationError => "authorization_error",
                GetFocusReportResponseErrorType2.NotFound => "not_found",
                GetFocusReportResponseErrorType2.NotImplemented => "not_implemented",
                GetFocusReportResponseErrorType2.RateLimited => "rate_limited",
                GetFocusReportResponseErrorType2.ServerError => "server_error",
                GetFocusReportResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFocusReportResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetFocusReportResponseErrorType2.AuthorizationError,
                "not_found" => GetFocusReportResponseErrorType2.NotFound,
                "not_implemented" => GetFocusReportResponseErrorType2.NotImplemented,
                "rate_limited" => GetFocusReportResponseErrorType2.RateLimited,
                "server_error" => GetFocusReportResponseErrorType2.ServerError,
                "validation_error" => GetFocusReportResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}