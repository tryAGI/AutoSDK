//HintName: G.Models.BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode
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
        QueryTooLong,
        /// <summary>
        /// 
        /// </summary>
        RequestTooLarge,
        /// <summary>
        /// 
        /// </summary>
        TooManyRequests,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode.InvalidToolInput => "invalid_tool_input",
                BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode.MaxUsesExceeded => "max_uses_exceeded",
                BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode.QueryTooLong => "query_too_long",
                BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode.RequestTooLarge => "request_too_large",
                BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode.TooManyRequests => "too_many_requests",
                BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_tool_input" => BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode.InvalidToolInput,
                "max_uses_exceeded" => BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode.MaxUsesExceeded,
                "query_too_long" => BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode.QueryTooLong,
                "request_too_large" => BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode.RequestTooLarge,
                "too_many_requests" => BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode.TooManyRequests,
                "unavailable" => BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}