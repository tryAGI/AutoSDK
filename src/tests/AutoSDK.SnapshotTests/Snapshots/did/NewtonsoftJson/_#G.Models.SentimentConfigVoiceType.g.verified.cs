//HintName: G.Models.SentimentConfigVoiceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SentimentConfigVoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="amazon")]
        Amazon,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure-openai")]
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="elevenlabs")]
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google")]
        Google,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="microsoft")]
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