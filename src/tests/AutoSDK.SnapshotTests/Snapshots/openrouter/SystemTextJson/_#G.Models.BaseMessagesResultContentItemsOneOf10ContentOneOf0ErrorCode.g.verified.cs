//HintName: G.Models.BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        ExecutionTimeExceeded,
        /// <summary>
        /// 
        /// </summary>
        InvalidToolInput,
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
    public static class BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode.InvalidToolInput => "invalid_tool_input",
                BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode.TooManyRequests => "too_many_requests",
                BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "execution_time_exceeded" => BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode.ExecutionTimeExceeded,
                "invalid_tool_input" => BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode.InvalidToolInput,
                "too_many_requests" => BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode.TooManyRequests,
                "unavailable" => BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}