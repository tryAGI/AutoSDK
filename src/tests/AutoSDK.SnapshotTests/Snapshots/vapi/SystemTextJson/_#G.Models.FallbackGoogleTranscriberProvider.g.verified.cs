//HintName: G.Models.FallbackGoogleTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used.
    /// </summary>
    public enum FallbackGoogleTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackGoogleTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackGoogleTranscriberProvider value)
        {
            return value switch
            {
                FallbackGoogleTranscriberProvider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackGoogleTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => FallbackGoogleTranscriberProvider.Google,
                _ => null,
            };
        }
    }
}