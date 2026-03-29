//HintName: G.Models.HistoryControllerGetListV1KindItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum HistoryControllerGetListV1KindItem
    {
        /// <summary>
        /// 
        /// </summary>
        Live,
        /// <summary>
        /// 
        /// </summary>
        PreRecorded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HistoryControllerGetListV1KindItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HistoryControllerGetListV1KindItem value)
        {
            return value switch
            {
                HistoryControllerGetListV1KindItem.Live => "live",
                HistoryControllerGetListV1KindItem.PreRecorded => "pre-recorded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HistoryControllerGetListV1KindItem? ToEnum(string value)
        {
            return value switch
            {
                "live" => HistoryControllerGetListV1KindItem.Live,
                "pre-recorded" => HistoryControllerGetListV1KindItem.PreRecorded,
                _ => null,
            };
        }
    }
}