//HintName: G.Models.ListGeneratedItemsV1HistoryGetSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Source of the generated history item<br/>
    /// Example: TTS
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListGeneratedItemsV1HistoryGetSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TTS")]
        TTS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STS")]
        STS,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListGeneratedItemsV1HistoryGetSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListGeneratedItemsV1HistoryGetSource value)
        {
            return value switch
            {
                ListGeneratedItemsV1HistoryGetSource.TTS => "TTS",
                ListGeneratedItemsV1HistoryGetSource.STS => "STS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListGeneratedItemsV1HistoryGetSource? ToEnum(string value)
        {
            return value switch
            {
                "TTS" => ListGeneratedItemsV1HistoryGetSource.TTS,
                "STS" => ListGeneratedItemsV1HistoryGetSource.STS,
                _ => null,
            };
        }
    }
}