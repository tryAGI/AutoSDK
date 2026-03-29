//HintName: G.Models.ConfiguredRulesStyleAndToneTextPositionReferences.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Text Position References
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndToneTextPositionReferences
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="avoid_directional_terms_as_only_reference_to_position_in_text_specify_exact_position_instead")]
        AvoidDirectionalTermsAsOnlyReferenceToPositionInTextSpecifyExactPositionInstead,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneTextPositionReferencesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneTextPositionReferences value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneTextPositionReferences.AvoidDirectionalTermsAsOnlyReferenceToPositionInTextSpecifyExactPositionInstead => "avoid_directional_terms_as_only_reference_to_position_in_text_specify_exact_position_instead",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneTextPositionReferences? ToEnum(string value)
        {
            return value switch
            {
                "avoid_directional_terms_as_only_reference_to_position_in_text_specify_exact_position_instead" => ConfiguredRulesStyleAndToneTextPositionReferences.AvoidDirectionalTermsAsOnlyReferenceToPositionInTextSpecifyExactPositionInstead,
                _ => null,
            };
        }
    }
}