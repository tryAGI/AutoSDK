//HintName: G.Models.SentimentConfigVoiceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SentimentConfigVoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        Amazon,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SentimentConfigVoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SentimentConfigVoiceType value)
        {
            return value switch
            {
                SentimentConfigVoiceType.Amazon => "amazon",
                SentimentConfigVoiceType.AzureOpenai => "azure-openai",
                SentimentConfigVoiceType.Elevenlabs => "elevenlabs",
                SentimentConfigVoiceType.Google => "google",
                SentimentConfigVoiceType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SentimentConfigVoiceType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => SentimentConfigVoiceType.Amazon,
                "azure-openai" => SentimentConfigVoiceType.AzureOpenai,
                "elevenlabs" => SentimentConfigVoiceType.Elevenlabs,
                "google" => SentimentConfigVoiceType.Google,
                "microsoft" => SentimentConfigVoiceType.Microsoft,
                _ => null,
            };
        }
    }
}