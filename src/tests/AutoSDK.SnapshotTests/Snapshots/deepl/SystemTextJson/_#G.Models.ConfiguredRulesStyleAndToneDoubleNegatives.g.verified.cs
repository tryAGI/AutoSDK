//HintName: G.Models.ConfiguredRulesStyleAndToneDoubleNegatives.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Double Negatives
    /// </summary>
    public enum ConfiguredRulesStyleAndToneDoubleNegatives
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUseDoubleNegatives,
        /// <summary>
        /// 
        /// </summary>
        UseDoubleNegatives,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneDoubleNegativesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneDoubleNegatives value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneDoubleNegatives.DoNotUseDoubleNegatives => "do_not_use_double_negatives",
                ConfiguredRulesStyleAndToneDoubleNegatives.UseDoubleNegatives => "use_double_negatives",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneDoubleNegatives? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_double_negatives" => ConfiguredRulesStyleAndToneDoubleNegatives.DoNotUseDoubleNegatives,
                "use_double_negatives" => ConfiguredRulesStyleAndToneDoubleNegatives.UseDoubleNegatives,
                _ => null,
            };
        }
    }
}