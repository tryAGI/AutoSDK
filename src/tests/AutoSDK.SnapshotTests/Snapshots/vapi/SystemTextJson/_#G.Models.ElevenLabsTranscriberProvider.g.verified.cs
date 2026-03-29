//HintName: G.Models.ElevenLabsTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used.
    /// </summary>
    public enum ElevenLabsTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        x11labs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenLabsTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsTranscriberProvider value)
        {
            return value switch
            {
                ElevenLabsTranscriberProvider.x11labs => "11labs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "11labs" => ElevenLabsTranscriberProvider.x11labs,
                _ => null,
            };
        }
    }
}