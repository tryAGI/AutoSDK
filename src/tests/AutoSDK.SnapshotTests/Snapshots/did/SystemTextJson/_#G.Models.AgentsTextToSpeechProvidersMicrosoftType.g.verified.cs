//HintName: G.Models.AgentsTextToSpeechProvidersMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsTextToSpeechProvidersMicrosoftType
    {
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsTextToSpeechProvidersMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsTextToSpeechProvidersMicrosoftType value)
        {
            return value switch
            {
                AgentsTextToSpeechProvidersMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsTextToSpeechProvidersMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => AgentsTextToSpeechProvidersMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}