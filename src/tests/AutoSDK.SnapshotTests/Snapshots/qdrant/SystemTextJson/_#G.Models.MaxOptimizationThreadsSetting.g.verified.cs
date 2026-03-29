//HintName: G.Models.MaxOptimizationThreadsSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MaxOptimizationThreadsSetting
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MaxOptimizationThreadsSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MaxOptimizationThreadsSetting value)
        {
            return value switch
            {
                MaxOptimizationThreadsSetting.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MaxOptimizationThreadsSetting? ToEnum(string value)
        {
            return value switch
            {
                "auto" => MaxOptimizationThreadsSetting.Auto,
                _ => null,
            };
        }
    }
}