//HintName: G.Models.GetSpeechHistorySource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpeechHistorySource
    {
        /// <summary>
        /// 
        /// </summary>
        Sts,
        /// <summary>
        /// 
        /// </summary>
        Tts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpeechHistorySourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpeechHistorySource value)
        {
            return value switch
            {
                GetSpeechHistorySource.Sts => "STS",
                GetSpeechHistorySource.Tts => "TTS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpeechHistorySource? ToEnum(string value)
        {
            return value switch
            {
                "STS" => GetSpeechHistorySource.Sts,
                "TTS" => GetSpeechHistorySource.Tts,
                _ => null,
            };
        }
    }
}