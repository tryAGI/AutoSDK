//HintName: G.Models.WebConnectorUrlErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of error that can occur during web connector URL processing.
    /// </summary>
    public enum WebConnectorUrlErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        InvalidUrl,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        NotSearchable,
        /// <summary>
        /// 
        /// </summary>
        PaywallOrLoginPage,
        /// <summary>
        /// 
        /// </summary>
        UnexpectedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebConnectorUrlErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebConnectorUrlErrorType value)
        {
            return value switch
            {
                WebConnectorUrlErrorType.InvalidUrl => "invalid_url",
                WebConnectorUrlErrorType.NotFound => "not_found",
                WebConnectorUrlErrorType.NotSearchable => "not_searchable",
                WebConnectorUrlErrorType.PaywallOrLoginPage => "paywall_or_login_page",
                WebConnectorUrlErrorType.UnexpectedError => "unexpected_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebConnectorUrlErrorType? ToEnum(string value)
        {
            return value switch
            {
                "invalid_url" => WebConnectorUrlErrorType.InvalidUrl,
                "not_found" => WebConnectorUrlErrorType.NotFound,
                "not_searchable" => WebConnectorUrlErrorType.NotSearchable,
                "paywall_or_login_page" => WebConnectorUrlErrorType.PaywallOrLoginPage,
                "unexpected_error" => WebConnectorUrlErrorType.UnexpectedError,
                _ => null,
            };
        }
    }
}