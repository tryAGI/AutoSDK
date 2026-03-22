//HintName: G.Models.StreamedChatResponseV2DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StreamedChatResponseV2DiscriminatorType
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
        Debug,
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
    public static class StreamedChatResponseV2DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamedChatResponseV2DiscriminatorType value)
        {
            return value switch
            {
                StreamedChatResponseV2DiscriminatorType.CitationEnd => "citation-end",
                StreamedChatResponseV2DiscriminatorType.CitationStart => "citation-start",
                StreamedChatResponseV2DiscriminatorType.ContentDelta => "content-delta",
                StreamedChatResponseV2DiscriminatorType.ContentEnd => "content-end",
                StreamedChatResponseV2DiscriminatorType.ContentStart => "content-start",
                StreamedChatResponseV2DiscriminatorType.Debug => "debug",
                StreamedChatResponseV2DiscriminatorType.MessageEnd => "message-end",
                StreamedChatResponseV2DiscriminatorType.MessageStart => "message-start",
                StreamedChatResponseV2DiscriminatorType.ToolCallDelta => "tool-call-delta",
                StreamedChatResponseV2DiscriminatorType.ToolCallEnd => "tool-call-end",
                StreamedChatResponseV2DiscriminatorType.ToolCallStart => "tool-call-start",
                StreamedChatResponseV2DiscriminatorType.ToolPlanDelta => "tool-plan-delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamedChatResponseV2DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "citation-end" => StreamedChatResponseV2DiscriminatorType.CitationEnd,
                "citation-start" => StreamedChatResponseV2DiscriminatorType.CitationStart,
                "content-delta" => StreamedChatResponseV2DiscriminatorType.ContentDelta,
                "content-end" => StreamedChatResponseV2DiscriminatorType.ContentEnd,
                "content-start" => StreamedChatResponseV2DiscriminatorType.ContentStart,
                "debug" => StreamedChatResponseV2DiscriminatorType.Debug,
                "message-end" => StreamedChatResponseV2DiscriminatorType.MessageEnd,
                "message-start" => StreamedChatResponseV2DiscriminatorType.MessageStart,
                "tool-call-delta" => StreamedChatResponseV2DiscriminatorType.ToolCallDelta,
                "tool-call-end" => StreamedChatResponseV2DiscriminatorType.ToolCallEnd,
                "tool-call-start" => StreamedChatResponseV2DiscriminatorType.ToolCallStart,
                "tool-plan-delta" => StreamedChatResponseV2DiscriminatorType.ToolPlanDelta,
                _ => null,
            };
        }
    }
}