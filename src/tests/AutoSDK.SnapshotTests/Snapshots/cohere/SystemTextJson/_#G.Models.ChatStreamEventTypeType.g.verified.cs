//HintName: G.Models.ChatStreamEventTypeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatStreamEventTypeType
    {
        /// <summary>
        /// 
        /// </summary>
        CitationEnd,
        /// <summary>
        /// 
        /// </summary>
        CitationStart,
        /// <summary>
        /// 
        /// </summary>
        ContentDelta,
        /// <summary>
        /// 
        /// </summary>
        ContentEnd,
        /// <summary>
        /// 
        /// </summary>
        ContentStart,
        /// <summary>
        /// 
        /// </summary>
        MessageEnd,
        /// <summary>
        /// 
        /// </summary>
        MessageStart,
        /// <summary>
        /// 
        /// </summary>
        ToolCallDelta,
        /// <summary>
        /// 
        /// </summary>
        ToolCallEnd,
        /// <summary>
        /// 
        /// </summary>
        ToolCallStart,
        /// <summary>
        /// 
        /// </summary>
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