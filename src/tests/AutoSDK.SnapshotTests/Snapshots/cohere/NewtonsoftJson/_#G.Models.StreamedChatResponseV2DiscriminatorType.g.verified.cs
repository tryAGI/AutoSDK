//HintName: G.Models.StreamedChatResponseV2DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StreamedChatResponseV2DiscriminatorType
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
        [global::System.Runtime.Serialization.EnumMember(Value="debug")]
        Debug,
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