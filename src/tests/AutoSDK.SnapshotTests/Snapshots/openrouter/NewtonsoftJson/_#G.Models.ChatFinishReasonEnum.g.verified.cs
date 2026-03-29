//HintName: G.Models.ChatFinishReasonEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatFinishReasonEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_filter")]
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="length")]
        Length,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stop")]
        Stop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_calls")]
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