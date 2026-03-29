//HintName: G.Models.BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        InvalidToolInput,
        /// <summary>
        /// 
        /// </summary>
        MaxUsesExceeded,
        /// <summary>
        /// 
        /// </summary>
        TooManyRequests,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedContentType,
        /// <summary>
        /// 
        /// </summary>
        UrlNotAccessible,
        /// <summary>
        /// 
        /// </summary>
        UrlNotAllowed,
        /// <summary>
        /// 
        /// </summary>
        UrlTooLong,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.InvalidToolInput => "invalid_tool_input",
                BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.MaxUsesExceeded => "max_uses_exceeded",
                BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.TooManyRequests => "too_many_requests",
                BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.Unavailable => "unavailable",
                BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.UnsupportedContentType => "unsupported_content_type",
                BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.UrlNotAccessible => "url_not_accessible",
                BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.UrlNotAllowed => "url_not_allowed",
                BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.UrlTooLong => "url_too_long",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_tool_input" => BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.InvalidToolInput,
                "max_uses_exceeded" => BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.MaxUsesExceeded,
                "too_many_requests" => BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.TooManyRequests,
                "unavailable" => BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.Unavailable,
                "unsupported_content_type" => BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.UnsupportedContentType,
                "url_not_accessible" => BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.UrlNotAccessible,
                "url_not_allowed" => BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.UrlNotAllowed,
                "url_too_long" => BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode.UrlTooLong,
                _ => null,
            };
        }
    }
}