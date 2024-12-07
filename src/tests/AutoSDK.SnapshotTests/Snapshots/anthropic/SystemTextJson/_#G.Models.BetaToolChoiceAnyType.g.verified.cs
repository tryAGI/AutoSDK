//HintName: G.Models.BetaToolChoiceAnyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaToolChoiceAnyType
    {
        /// <summary>
        /// 
        /// </summary>
        Any,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolChoiceAnyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolChoiceAnyType value)
        {
            return value switch
            {
                BetaToolChoiceAnyType.Any => "any",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolChoiceAnyType? ToEnum(string value)
        {
            return value switch
            {
                "any" => BetaToolChoiceAnyType.Any,
                _ => null,
            };
        }
    }
}