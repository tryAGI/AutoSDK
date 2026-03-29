//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode
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
        TooManyRequests,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode.InvalidToolInput => "invalid_tool_input",
                MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode.MaxUsesExceeded => "max_uses_exceeded",
                MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode.QueryTooLong => "query_too_long",
                MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode.TooManyRequests => "too_many_requests",
                MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_tool_input" => MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode.InvalidToolInput,
                "max_uses_exceeded" => MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode.MaxUsesExceeded,
                "query_too_long" => MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode.QueryTooLong,
                "too_many_requests" => MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode.TooManyRequests,
                "unavailable" => MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}