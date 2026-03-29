//HintName: G.Models.BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="execution_time_exceeded")]
        ExecutionTimeExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_tool_input")]
        InvalidToolInput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output_file_too_large")]
        OutputFileTooLarge,
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
    public static class BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode.InvalidToolInput => "invalid_tool_input",
                BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode.OutputFileTooLarge => "output_file_too_large",
                BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode.TooManyRequests => "too_many_requests",
                BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "execution_time_exceeded" => BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode.ExecutionTimeExceeded,
                "invalid_tool_input" => BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode.InvalidToolInput,
                "output_file_too_large" => BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode.OutputFileTooLarge,
                "too_many_requests" => BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode.TooManyRequests,
                "unavailable" => BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}