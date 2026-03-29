//HintName: G.Models.LogRequestErrorType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LogRequestErrorType2
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
    public static class LogRequestErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogRequestErrorType2 value)
        {
            return value switch
            {
                LogRequestErrorType2.ProviderAuthError => "PROVIDER_AUTH_ERROR",
                LogRequestErrorType2.ProviderError => "PROVIDER_ERROR",
                LogRequestErrorType2.ProviderQuotaLimit => "PROVIDER_QUOTA_LIMIT",
                LogRequestErrorType2.ProviderRateLimit => "PROVIDER_RATE_LIMIT",
                LogRequestErrorType2.ProviderTimeout => "PROVIDER_TIMEOUT",
                LogRequestErrorType2.TemplateRenderError => "TEMPLATE_RENDER_ERROR",
                LogRequestErrorType2.UnknownError => "UNKNOWN_ERROR",
                LogRequestErrorType2.VariableMissingOrEmpty => "VARIABLE_MISSING_OR_EMPTY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogRequestErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "PROVIDER_AUTH_ERROR" => LogRequestErrorType2.ProviderAuthError,
                "PROVIDER_ERROR" => LogRequestErrorType2.ProviderError,
                "PROVIDER_QUOTA_LIMIT" => LogRequestErrorType2.ProviderQuotaLimit,
                "PROVIDER_RATE_LIMIT" => LogRequestErrorType2.ProviderRateLimit,
                "PROVIDER_TIMEOUT" => LogRequestErrorType2.ProviderTimeout,
                "TEMPLATE_RENDER_ERROR" => LogRequestErrorType2.TemplateRenderError,
                "UNKNOWN_ERROR" => LogRequestErrorType2.UnknownError,
                "VARIABLE_MISSING_OR_EMPTY" => LogRequestErrorType2.VariableMissingOrEmpty,
                _ => null,
            };
        }
    }
}