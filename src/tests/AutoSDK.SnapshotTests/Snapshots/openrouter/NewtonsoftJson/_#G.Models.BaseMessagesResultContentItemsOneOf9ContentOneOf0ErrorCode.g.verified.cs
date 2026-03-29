//HintName: G.Models.BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="execution_time_exceeded")]
        ExecutionTimeExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_not_found")]
        FileNotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_tool_input")]
        InvalidToolInput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="too_many_requests")]
        TooManyRequests,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unavailable")]
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCode value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCode.FileNotFound => "file_not_found",
                BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCode.InvalidToolInput => "invalid_tool_input",
                BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCode.TooManyRequests => "too_many_requests",
                BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "execution_time_exceeded" => BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCode.ExecutionTimeExceeded,
                "file_not_found" => BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCode.FileNotFound,
                "invalid_tool_input" => BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCode.InvalidToolInput,
                "too_many_requests" => BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCode.TooManyRequests,
                "unavailable" => BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}