//HintName: G.Models.ThinkingConfigEnabledType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ThinkingConfigEnabledType
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThinkingConfigEnabledTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThinkingConfigEnabledType value)
        {
            return value switch
            {
                ThinkingConfigEnabledType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThinkingConfigEnabledType? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => ThinkingConfigEnabledType.Enabled,
                _ => null,
            };
        }
    }
}