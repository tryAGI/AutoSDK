//HintName: G.Models.ChatStreamEventTypeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatStreamEventTypeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="citation-end")]
        CitationEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="citation-start")]
        CitationStart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content-delta")]
        ContentDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content-end")]
        ContentEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content-start")]
        ContentStart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message-end")]
        MessageEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message-start")]
        MessageStart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool-call-delta")]
        ToolCallDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool-call-end")]
        ToolCallEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool-call-start")]
        ToolCallStart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool-plan-delta")]
        ToolPlanDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatStreamEventTypeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatStreamEventTypeType value)
        {
            return value switch
            {
                ChatStreamEventTypeType.CitationEnd => "citation-end",
                ChatStreamEventTypeType.CitationStart => "citation-start",
                ChatStreamEventTypeType.ContentDelta => "content-delta",
                ChatStreamEventTypeType.ContentEnd => "content-end",
                ChatStreamEventTypeType.ContentStart => "content-start",
                ChatStreamEventTypeType.MessageEnd => "message-end",
                ChatStreamEventTypeType.MessageStart => "message-start",
                ChatStreamEventTypeType.ToolCallDelta => "tool-call-delta",
                ChatStreamEventTypeType.ToolCallEnd => "tool-call-end",
                ChatStreamEventTypeType.ToolCallStart => "tool-call-start",
                ChatStreamEventTypeType.ToolPlanDelta => "tool-plan-delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatStreamEventTypeType? ToEnum(string value)
        {
            return value switch
            {
                "citation-end" => ChatStreamEventTypeType.CitationEnd,
                "citation-start" => ChatStreamEventTypeType.CitationStart,
                "content-delta" => ChatStreamEventTypeType.ContentDelta,
                "content-end" => ChatStreamEventTypeType.ContentEnd,
                "content-start" => ChatStreamEventTypeType.ContentStart,
                "message-end" => ChatStreamEventTypeType.MessageEnd,
                "message-start" => ChatStreamEventTypeType.MessageStart,
                "tool-call-delta" => ChatStreamEventTypeType.ToolCallDelta,
                "tool-call-end" => ChatStreamEventTypeType.ToolCallEnd,
                "tool-call-start" => ChatStreamEventTypeType.ToolCallStart,
                "tool-plan-delta" => ChatStreamEventTypeType.ToolPlanDelta,
                _ => null,
            };
        }
    }
}