//HintName: G.Models.TalkscriberTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used.
    /// </summary>
    public enum TalkscriberTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Talkscriber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TalkscriberTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TalkscriberTranscriberProvider value)
        {
            return value switch
            {
                TalkscriberTranscriberProvider.Talkscriber => "talkscriber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TalkscriberTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "talkscriber" => TalkscriberTranscriberProvider.Talkscriber,
                _ => null,
            };
        }
    }
}