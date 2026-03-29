//HintName: G.Models.FallbackElevenLabsTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used.
    /// </summary>
    public enum FallbackElevenLabsTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        x11labs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackElevenLabsTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackElevenLabsTranscriberProvider value)
        {
            return value switch
            {
                FallbackElevenLabsTranscriberProvider.x11labs => "11labs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackElevenLabsTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "11labs" => FallbackElevenLabsTranscriberProvider.x11labs,
                _ => null,
            };
        }
    }
}