//HintName: G.Models.ConfiguredRulesStyleAndToneAnglicisms.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Anglicisms
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndToneAnglicisms
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="avoid_anglicisms_when_there_is_a_french_equivalent")]
        AvoidAnglicismsWhenThereIsAFrenchEquivalent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneAnglicismsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneAnglicisms value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneAnglicisms.AvoidAnglicismsWhenThereIsAFrenchEquivalent => "avoid_anglicisms_when_there_is_a_french_equivalent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneAnglicisms? ToEnum(string value)
        {
            return value switch
            {
                "avoid_anglicisms_when_there_is_a_french_equivalent" => ConfiguredRulesStyleAndToneAnglicisms.AvoidAnglicismsWhenThereIsAFrenchEquivalent,
                _ => null,
            };
        }
    }
}