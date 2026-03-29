//HintName: G.Models.ClipGuidancePreset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: NONE<br/>
    /// Example: FAST_BLUE
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClipGuidancePreset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAST_BLUE")]
        FastBlue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAST_GREEN")]
        FastGreen,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SIMPLE")]
        Simple,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SLOW")]
        Slow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SLOWER")]
        Slower,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SLOWEST")]
        Slowest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipGuidancePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipGuidancePreset value)
        {
            return value switch
            {
                ClipGuidancePreset.FastBlue => "FAST_BLUE",
                ClipGuidancePreset.FastGreen => "FAST_GREEN",
                ClipGuidancePreset.None => "NONE",
                ClipGuidancePreset.Simple => "SIMPLE",
                ClipGuidancePreset.Slow => "SLOW",
                ClipGuidancePreset.Slower => "SLOWER",
                ClipGuidancePreset.Slowest => "SLOWEST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipGuidancePreset? ToEnum(string value)
        {
            return value switch
            {
                "FAST_BLUE" => ClipGuidancePreset.FastBlue,
                "FAST_GREEN" => ClipGuidancePreset.FastGreen,
                "NONE" => ClipGuidancePreset.None,
                "SIMPLE" => ClipGuidancePreset.Simple,
                "SLOW" => ClipGuidancePreset.Slow,
                "SLOWER" => ClipGuidancePreset.Slower,
                "SLOWEST" => ClipGuidancePreset.Slowest,
                _ => null,
            };
        }
    }
}