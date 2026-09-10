//HintName: G.Models.LogRequestErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LogRequestErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        ProviderAuthError,
        /// <summary>
        /// 
        /// </summary>
        ProviderError,
        /// <summary>
        /// 
        /// </summary>
        ProviderQuotaLimit,
        /// <summary>
        /// 
        /// </summary>
        ProviderRateLimit,
        /// <summary>
        /// 
        /// </summary>
        ProviderTimeout,
        /// <summary>
        /// 
        /// </summary>
        TemplateRenderError,
        /// <summary>
        /// 
        /// </summary>
        UnknownError,
        /// <summary>
        /// 
        /// </summary>
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