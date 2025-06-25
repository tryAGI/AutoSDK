//HintName: G.Models.BetaThinkingConfigDisabledType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaThinkingConfigDisabledType
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaThinkingConfigDisabledTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaThinkingConfigDisabledType value)
        {
            return value switch
            {
                BetaThinkingConfigDisabledType.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaThinkingConfigDisabledType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaThinkingConfigDisabledType.Disabled,
                _ => null,
            };
        }
    }
}