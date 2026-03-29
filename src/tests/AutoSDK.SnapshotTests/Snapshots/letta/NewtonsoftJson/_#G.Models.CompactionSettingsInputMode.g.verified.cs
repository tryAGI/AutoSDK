//HintName: G.Models.CompactionSettingsInputMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of summarization technique use.<br/>
    /// Default Value: sliding_window
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompactionSettingsInputMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="self_compact_all")]
        SelfCompactAll,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="self_compact_sliding_window")]
        SelfCompactSlidingWindow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sliding_window")]
        SlidingWindow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompactionSettingsInputModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompactionSettingsInputMode value)
        {
            return value switch
            {
                CompactionSettingsInputMode.All => "all",
                CompactionSettingsInputMode.SelfCompactAll => "self_compact_all",
                CompactionSettingsInputMode.SelfCompactSlidingWindow => "self_compact_sliding_window",
                CompactionSettingsInputMode.SlidingWindow => "sliding_window",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompactionSettingsInputMode? ToEnum(string value)
        {
            return value switch
            {
                "all" => CompactionSettingsInputMode.All,
                "self_compact_all" => CompactionSettingsInputMode.SelfCompactAll,
                "self_compact_sliding_window" => CompactionSettingsInputMode.SelfCompactSlidingWindow,
                "sliding_window" => CompactionSettingsInputMode.SlidingWindow,
                _ => null,
            };
        }
    }
}