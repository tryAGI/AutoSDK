//HintName: G.Models.ConfiguredRulesStyleAndToneModalVerbs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Modal Verbs
    /// </summary>
    public enum ConfiguredRulesStyleAndToneModalVerbs
    {
        /// <summary>
        /// 
        /// </summary>
        AvoidModalVerbs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneModalVerbsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneModalVerbs value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneModalVerbs.AvoidModalVerbs => "avoid_modal_verbs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneModalVerbs? ToEnum(string value)
        {
            return value switch
            {
                "avoid_modal_verbs" => ConfiguredRulesStyleAndToneModalVerbs.AvoidModalVerbs,
                _ => null,
            };
        }
    }
}