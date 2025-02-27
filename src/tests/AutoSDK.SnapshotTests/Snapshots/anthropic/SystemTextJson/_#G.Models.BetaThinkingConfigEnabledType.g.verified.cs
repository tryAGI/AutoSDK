//HintName: G.Models.BetaThinkingConfigEnabledType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaThinkingConfigEnabledType
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaThinkingConfigEnabledTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaThinkingConfigEnabledType value)
        {
            return value switch
            {
                BetaThinkingConfigEnabledType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaThinkingConfigEnabledType? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => BetaThinkingConfigEnabledType.Enabled,
                _ => null,
            };
        }
    }
}