//HintName: G.Models.ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferences.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Idioms Colloquialisms And Culture Specific References
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferences
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_use")]
        DoNotUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferencesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferences value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferences.DoNotUse => "do_not_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferences? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use" => ConfiguredRulesStyleAndToneIdiomsColloquialismsAndCultureSpecificReferences.DoNotUse,
                _ => null,
            };
        }
    }
}