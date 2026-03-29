//HintName: G.Models.ChatFinishReasonEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatFinishReasonEnum
    {
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFinishReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFinishReasonEnum value)
        {
            return value switch
            {
                ChatFinishReasonEnum.ContentFilter => "content_filter",
                ChatFinishReasonEnum.Error => "error",
                ChatFinishReasonEnum.Length => "length",
                ChatFinishReasonEnum.Stop => "stop",
                ChatFinishReasonEnum.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFinishReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => ChatFinishReasonEnum.ContentFilter,
                "error" => ChatFinishReasonEnum.Error,
                "length" => ChatFinishReasonEnum.Length,
                "stop" => ChatFinishReasonEnum.Stop,
                "tool_calls" => ChatFinishReasonEnum.ToolCalls,
                _ => null,
            };
        }
    }
}