//HintName: G.Models.ConfiguredRulesPunctuationPeriodsInAcademicDegrees.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Periods In Academic Degrees
    /// </summary>
    public enum ConfiguredRulesPunctuationPeriodsInAcademicDegrees
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUse,
        /// <summary>
        /// 
        /// </summary>
        Use,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationPeriodsInAcademicDegreesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationPeriodsInAcademicDegrees value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationPeriodsInAcademicDegrees.DoNotUse => "do_not_use",
                ConfiguredRulesPunctuationPeriodsInAcademicDegrees.Use => "use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationPeriodsInAcademicDegrees? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use" => ConfiguredRulesPunctuationPeriodsInAcademicDegrees.DoNotUse,
                "use" => ConfiguredRulesPunctuationPeriodsInAcademicDegrees.Use,
                _ => null,
            };
        }
    }
}