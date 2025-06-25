//HintName: G.Models.WebhookUsageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookUsageType
    {
        /// <summary>
        /// 
        /// </summary>
        ConvAIAgentSettings,
        /// <summary>
        /// 
        /// </summary>
        ConvAISettings,
        /// <summary>
        /// 
        /// </summary>
        VoiceLibraryRemovalNotices,
        /// <summary>
        /// 
        /// </summary>
        SpeechToText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookUsageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookUsageType value)
        {
            return value switch
            {
                WebhookUsageType.ConvAIAgentSettings => "ConvAI Agent Settings",
                WebhookUsageType.ConvAISettings => "ConvAI Settings",
                WebhookUsageType.VoiceLibraryRemovalNotices => "Voice Library Removal Notices",
                WebhookUsageType.SpeechToText => "Speech to Text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookUsageType? ToEnum(string value)
        {
            return value switch
            {
                "ConvAI Agent Settings" => WebhookUsageType.ConvAIAgentSettings,
                "ConvAI Settings" => WebhookUsageType.ConvAISettings,
                "Voice Library Removal Notices" => WebhookUsageType.VoiceLibraryRemovalNotices,
                "Speech to Text" => WebhookUsageType.SpeechToText,
                _ => null,
            };
        }
    }
}