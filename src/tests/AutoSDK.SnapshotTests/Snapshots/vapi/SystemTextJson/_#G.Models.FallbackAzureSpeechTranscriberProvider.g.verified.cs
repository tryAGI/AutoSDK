//HintName: G.Models.FallbackAzureSpeechTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used.
    /// </summary>
    public enum FallbackAzureSpeechTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Azure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackAzureSpeechTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackAzureSpeechTranscriberProvider value)
        {
            return value switch
            {
                FallbackAzureSpeechTranscriberProvider.Azure => "azure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackAzureSpeechTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "azure" => FallbackAzureSpeechTranscriberProvider.Azure,
                _ => null,
            };
        }
    }
}