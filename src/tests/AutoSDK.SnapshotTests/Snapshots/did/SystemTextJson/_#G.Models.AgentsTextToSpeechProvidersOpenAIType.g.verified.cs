//HintName: G.Models.AgentsTextToSpeechProvidersOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsTextToSpeechProvidersOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsTextToSpeechProvidersOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsTextToSpeechProvidersOpenAIType value)
        {
            return value switch
            {
                AgentsTextToSpeechProvidersOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsTextToSpeechProvidersOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => AgentsTextToSpeechProvidersOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}