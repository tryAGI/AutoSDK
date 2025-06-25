//HintName: G.Models.SpeechHistoryItemResponseModelSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The source of the history item. Either TTS (text to speech), STS (speech to text), AN (audio native), Projects, Dubbing, PlayAPI, PD (pronunciation dictionary) or ConvAI (conversational AI).
    /// </summary>
    public enum SpeechHistoryItemResponseModelSource
    {
        /// <summary>
        /// 
        /// </summary>
        TTS,
        /// <summary>
        /// 
        /// </summary>
        STS,
        /// <summary>
        /// 
        /// </summary>
        Projects,
        /// <summary>
        /// 
        /// </summary>
        PD,
        /// <summary>
        /// 
        /// </summary>
        AN,
        /// <summary>
        /// 
        /// </summary>
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        PlayAPI,
        /// <summary>
        /// 
        /// </summary>
        ConvAI,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechHistoryItemResponseModelSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechHistoryItemResponseModelSource value)
        {
            return value switch
            {
                SpeechHistoryItemResponseModelSource.TTS => "TTS",
                SpeechHistoryItemResponseModelSource.STS => "STS",
                SpeechHistoryItemResponseModelSource.Projects => "Projects",
                SpeechHistoryItemResponseModelSource.PD => "PD",
                SpeechHistoryItemResponseModelSource.AN => "AN",
                SpeechHistoryItemResponseModelSource.Dubbing => "Dubbing",
                SpeechHistoryItemResponseModelSource.PlayAPI => "PlayAPI",
                SpeechHistoryItemResponseModelSource.ConvAI => "ConvAI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechHistoryItemResponseModelSource? ToEnum(string value)
        {
            return value switch
            {
                "TTS" => SpeechHistoryItemResponseModelSource.TTS,
                "STS" => SpeechHistoryItemResponseModelSource.STS,
                "Projects" => SpeechHistoryItemResponseModelSource.Projects,
                "PD" => SpeechHistoryItemResponseModelSource.PD,
                "AN" => SpeechHistoryItemResponseModelSource.AN,
                "Dubbing" => SpeechHistoryItemResponseModelSource.Dubbing,
                "PlayAPI" => SpeechHistoryItemResponseModelSource.PlayAPI,
                "ConvAI" => SpeechHistoryItemResponseModelSource.ConvAI,
                _ => null,
            };
        }
    }
}