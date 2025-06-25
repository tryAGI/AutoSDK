//HintName: G.Models.BetaToolChoiceAutoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaToolChoiceAutoType
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolChoiceAutoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolChoiceAutoType value)
        {
            return value switch
            {
                BetaToolChoiceAutoType.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolChoiceAutoType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaToolChoiceAutoType.Auto,
                _ => null,
            };
        }
    }
}