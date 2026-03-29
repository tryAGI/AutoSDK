//HintName: G.Models.CompactionSettingsOutputMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of summarization technique use.<br/>
    /// Default Value: sliding_window
    /// </summary>
    public enum CompactionSettingsOutputMode
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        SelfCompactAll,
        /// <summary>
        /// 
        /// </summary>
        SelfCompactSlidingWindow,
        /// <summary>
        /// 
        /// </summary>
        SlidingWindow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompactionSettingsOutputModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompactionSettingsOutputMode value)
        {
            return value switch
            {
                CompactionSettingsOutputMode.All => "all",
                CompactionSettingsOutputMode.SelfCompactAll => "self_compact_all",
                CompactionSettingsOutputMode.SelfCompactSlidingWindow => "self_compact_sliding_window",
                CompactionSettingsOutputMode.SlidingWindow => "sliding_window",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompactionSettingsOutputMode? ToEnum(string value)
        {
            return value switch
            {
                "all" => CompactionSettingsOutputMode.All,
                "self_compact_all" => CompactionSettingsOutputMode.SelfCompactAll,
                "self_compact_sliding_window" => CompactionSettingsOutputMode.SelfCompactSlidingWindow,
                "sliding_window" => CompactionSettingsOutputMode.SlidingWindow,
                _ => null,
            };
        }
    }
}