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
        [global::System.Runtime.Serialization.EnumMember(Value="message-start")]
        MessageStart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content-start")]
        ContentStart,
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
        [global::System.Runtime.Serialization.EnumMember(Value="tool-call-start")]
        ToolCallStart,
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
        [global::System.Runtime.Serialization.EnumMember(Value="tool-plan-delta")]
        ToolPlanDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="citation-start")]
        CitationStart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="citation-end")]
        CitationEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message-end")]
        MessageEnd,
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
                ChatStreamEventTypeType.MessageStart => "message-start",
                ChatStreamEventTypeType.ContentStart => "content-start",
                ChatStreamEventTypeType.ContentDelta => "content-delta",
                ChatStreamEventTypeType.ContentEnd => "content-end",
                ChatStreamEventTypeType.ToolCallStart => "tool-call-start",
                ChatStreamEventTypeType.ToolCallDelta => "tool-call-delta",
                ChatStreamEventTypeType.ToolCallEnd => "tool-call-end",
                ChatStreamEventTypeType.ToolPlanDelta => "tool-plan-delta",
                ChatStreamEventTypeType.CitationStart => "citation-start",
                ChatStreamEventTypeType.CitationEnd => "citation-end",
                ChatStreamEventTypeType.MessageEnd => "message-end",
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
                "message-start" => ChatStreamEventTypeType.MessageStart,
                "content-start" => ChatStreamEventTypeType.ContentStart,
                "content-delta" => ChatStreamEventTypeType.ContentDelta,
                "content-end" => ChatStreamEventTypeType.ContentEnd,
                "tool-call-start" => ChatStreamEventTypeType.ToolCallStart,
                "tool-call-delta" => ChatStreamEventTypeType.ToolCallDelta,
                "tool-call-end" => ChatStreamEventTypeType.ToolCallEnd,
                "tool-plan-delta" => ChatStreamEventTypeType.ToolPlanDelta,
                "citation-start" => ChatStreamEventTypeType.CitationStart,
                "citation-end" => ChatStreamEventTypeType.CitationEnd,
                "message-end" => ChatStreamEventTypeType.MessageEnd,
                _ => null,
            };
        }
    }
}