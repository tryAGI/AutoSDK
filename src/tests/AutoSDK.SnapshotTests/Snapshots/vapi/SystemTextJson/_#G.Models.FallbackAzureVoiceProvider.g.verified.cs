//HintName: G.Models.FallbackAzureVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum FallbackAzureVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Azure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackAzureVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackAzureVoiceProvider value)
        {
            return value switch
            {
                FallbackAzureVoiceProvider.Azure => "azure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackAzureVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "azure" => FallbackAzureVoiceProvider.Azure,
                _ => null,
            };
        }
    }
}