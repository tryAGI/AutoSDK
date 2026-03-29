//HintName: G.Models.ConfiguredRulesNumbersListOfMeasurementsWithUnits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for List Of Measurements With Units
    /// </summary>
    public enum ConfiguredRulesNumbersListOfMeasurementsWithUnits
    {
        /// <summary>
        /// 
        /// </summary>
        RepeatUnitForEachMeasurementInList,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersListOfMeasurementsWithUnitsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersListOfMeasurementsWithUnits value)
        {
            return value switch
            {
                ConfiguredRulesNumbersListOfMeasurementsWithUnits.RepeatUnitForEachMeasurementInList => "repeat_unit_for_each_measurement_in_list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersListOfMeasurementsWithUnits? ToEnum(string value)
        {
            return value switch
            {
                "repeat_unit_for_each_measurement_in_list" => ConfiguredRulesNumbersListOfMeasurementsWithUnits.RepeatUnitForEachMeasurementInList,
                _ => null,
            };
        }
    }
}