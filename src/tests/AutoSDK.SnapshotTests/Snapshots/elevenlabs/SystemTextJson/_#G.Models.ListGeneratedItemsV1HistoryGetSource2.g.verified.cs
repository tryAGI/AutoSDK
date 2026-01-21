//HintName: G.Models.ListGeneratedItemsV1HistoryGetSource2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListGeneratedItemsV1HistoryGetSource2
    {
        /// <summary>
        /// 
        /// </summary>
        TTS,
        /// <summary>
        /// 
        /// </summary>
        STS,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListGeneratedItemsV1HistoryGetSource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListGeneratedItemsV1HistoryGetSource2 value)
        {
            return value switch
            {
                ListGeneratedItemsV1HistoryGetSource2.TTS => "TTS",
                ListGeneratedItemsV1HistoryGetSource2.STS => "STS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListGeneratedItemsV1HistoryGetSource2? ToEnum(string value)
        {
            return value switch
            {
                "TTS" => ListGeneratedItemsV1HistoryGetSource2.TTS,
                "STS" => ListGeneratedItemsV1HistoryGetSource2.STS,
                _ => null,
            };
        }
    }
}