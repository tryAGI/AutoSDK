//HintName: G.Models.FallbackTalkscriberTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used.
    /// </summary>
    public enum FallbackTalkscriberTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Talkscriber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackTalkscriberTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackTalkscriberTranscriberProvider value)
        {
            return value switch
            {
                FallbackTalkscriberTranscriberProvider.Talkscriber => "talkscriber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackTalkscriberTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "talkscriber" => FallbackTalkscriberTranscriberProvider.Talkscriber,
                _ => null,
            };
        }
    }
}