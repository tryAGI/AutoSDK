//HintName: G.Models.ConfiguredRulesStyleAndToneProximityAgreement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Proximity Agreement
    /// </summary>
    public enum ConfiguredRulesStyleAndToneProximityAgreement
    {
        /// <summary>
        /// 
        /// </summary>
        Use,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneProximityAgreementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneProximityAgreement value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneProximityAgreement.Use => "use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneProximityAgreement? ToEnum(string value)
        {
            return value switch
            {
                "use" => ConfiguredRulesStyleAndToneProximityAgreement.Use,
                _ => null,
            };
        }
    }
}