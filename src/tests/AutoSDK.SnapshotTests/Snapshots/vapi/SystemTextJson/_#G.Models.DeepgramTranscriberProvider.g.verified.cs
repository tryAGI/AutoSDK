//HintName: G.Models.DeepgramTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used.
    /// </summary>
    public enum DeepgramTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Deepgram,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepgramTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepgramTranscriberProvider value)
        {
            return value switch
            {
                DeepgramTranscriberProvider.Deepgram => "deepgram",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepgramTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "deepgram" => DeepgramTranscriberProvider.Deepgram,
                _ => null,
            };
        }
    }
}