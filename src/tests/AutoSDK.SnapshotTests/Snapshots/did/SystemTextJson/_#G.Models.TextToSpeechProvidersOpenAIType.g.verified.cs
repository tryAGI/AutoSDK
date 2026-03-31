//HintName: G.Models.TextToSpeechProvidersOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextToSpeechProvidersOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechProvidersOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechProvidersOpenAIType value)
        {
            return value switch
            {
                TextToSpeechProvidersOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechProvidersOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => TextToSpeechProvidersOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}