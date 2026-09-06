//HintName: G.Models.LogRequestErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LogRequestErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PROVIDER_AUTH_ERROR")]
        ProviderAuthError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PROVIDER_ERROR")]
        ProviderError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PROVIDER_QUOTA_LIMIT")]
        ProviderQuotaLimit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PROVIDER_RATE_LIMIT")]
        ProviderRateLimit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PROVIDER_TIMEOUT")]
        ProviderTimeout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TEMPLATE_RENDER_ERROR")]
        TemplateRenderError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNKNOWN_ERROR")]
        UnknownError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VARIABLE_MISSING_OR_EMPTY")]
        VariableMissingOrEmpty,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogRequestErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogRequestErrorType value)
        {
            return value switch
            {
                LogRequestErrorType.ProviderAuthError => "PROVIDER_AUTH_ERROR",
                LogRequestErrorType.ProviderError => "PROVIDER_ERROR",
                LogRequestErrorType.ProviderQuotaLimit => "PROVIDER_QUOTA_LIMIT",
                LogRequestErrorType.ProviderRateLimit => "PROVIDER_RATE_LIMIT",
                LogRequestErrorType.ProviderTimeout => "PROVIDER_TIMEOUT",
                LogRequestErrorType.TemplateRenderError => "TEMPLATE_RENDER_ERROR",
                LogRequestErrorType.UnknownError => "UNKNOWN_ERROR",
                LogRequestErrorType.VariableMissingOrEmpty => "VARIABLE_MISSING_OR_EMPTY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogRequestErrorType? ToEnum(string value)
        {
            return value switch
            {
                "PROVIDER_AUTH_ERROR" => LogRequestErrorType.ProviderAuthError,
                "PROVIDER_ERROR" => LogRequestErrorType.ProviderError,
                "PROVIDER_QUOTA_LIMIT" => LogRequestErrorType.ProviderQuotaLimit,
                "PROVIDER_RATE_LIMIT" => LogRequestErrorType.ProviderRateLimit,
                "PROVIDER_TIMEOUT" => LogRequestErrorType.ProviderTimeout,
                "TEMPLATE_RENDER_ERROR" => LogRequestErrorType.TemplateRenderError,
                "UNKNOWN_ERROR" => LogRequestErrorType.UnknownError,
                "VARIABLE_MISSING_OR_EMPTY" => LogRequestErrorType.VariableMissingOrEmpty,
                _ => null,
            };
        }
    }
}