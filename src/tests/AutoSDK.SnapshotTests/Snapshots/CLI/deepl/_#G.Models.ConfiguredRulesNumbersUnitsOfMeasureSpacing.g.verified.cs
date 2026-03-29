//HintName: G.Models.ConfiguredRulesNumbersUnitsOfMeasureSpacing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Units Of Measure Spacing
    /// </summary>
    public enum ConfiguredRulesNumbersUnitsOfMeasureSpacing
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUseSpaceBetweenNumeralAndUnitOfMeasure,
        /// <summary>
        /// 
        /// </summary>
        UseSpaceBetweenNumeralAndUnitOfMeasure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersUnitsOfMeasureSpacingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersUnitsOfMeasureSpacing value)
        {
            return value switch
            {
                ConfiguredRulesNumbersUnitsOfMeasureSpacing.DoNotUseSpaceBetweenNumeralAndUnitOfMeasure => "do_not_use_space_between_numeral_and_unit_of_measure",
                ConfiguredRulesNumbersUnitsOfMeasureSpacing.UseSpaceBetweenNumeralAndUnitOfMeasure => "use_space_between_numeral_and_unit_of_measure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersUnitsOfMeasureSpacing? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_space_between_numeral_and_unit_of_measure" => ConfiguredRulesNumbersUnitsOfMeasureSpacing.DoNotUseSpaceBetweenNumeralAndUnitOfMeasure,
                "use_space_between_numeral_and_unit_of_measure" => ConfiguredRulesNumbersUnitsOfMeasureSpacing.UseSpaceBetweenNumeralAndUnitOfMeasure,
                _ => null,
            };
        }
    }
}