//HintName: G.Models.ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Passage Of Time And Movement Between Locations
    /// </summary>
    public enum ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocations
    {
        /// <summary>
        /// 
        /// </summary>
        UseDoubleEmDash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocationsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocations value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocations.UseDoubleEmDash => "use_double_em_dash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocations? ToEnum(string value)
        {
            return value switch
            {
                "use_double_em_dash" => ConfiguredRulesPunctuationPassageOfTimeAndMovementBetweenLocations.UseDoubleEmDash,
                _ => null,
            };
        }
    }
}