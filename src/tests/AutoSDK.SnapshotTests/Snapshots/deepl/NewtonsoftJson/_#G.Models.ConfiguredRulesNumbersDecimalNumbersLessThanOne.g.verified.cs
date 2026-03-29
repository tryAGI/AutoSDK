//HintName: G.Models.ConfiguredRulesNumbersDecimalNumbersLessThanOne.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Decimal Numbers Less Than One
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersDecimalNumbersLessThanOne
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="always_use_0_before_decimal_separator")]
        AlwaysUse0BeforeDecimalSeparator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersDecimalNumbersLessThanOneExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersDecimalNumbersLessThanOne value)
        {
            return value switch
            {
                ConfiguredRulesNumbersDecimalNumbersLessThanOne.AlwaysUse0BeforeDecimalSeparator => "always_use_0_before_decimal_separator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersDecimalNumbersLessThanOne? ToEnum(string value)
        {
            return value switch
            {
                "always_use_0_before_decimal_separator" => ConfiguredRulesNumbersDecimalNumbersLessThanOne.AlwaysUse0BeforeDecimalSeparator,
                _ => null,
            };
        }
    }
}