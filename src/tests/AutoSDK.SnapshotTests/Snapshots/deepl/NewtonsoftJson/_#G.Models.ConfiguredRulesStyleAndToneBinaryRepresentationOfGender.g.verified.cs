//HintName: G.Models.ConfiguredRulesStyleAndToneBinaryRepresentationOfGender.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Binary Representation Of Gender
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndToneBinaryRepresentationOfGender
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="avoid_binary_representation_of_gender_when_gender_neutral_language_can_be_used")]
        AvoidBinaryRepresentationOfGenderWhenGenderNeutralLanguageCanBeUsed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="replace_binary_representations_of_gender_with_gender_neutral_language")]
        ReplaceBinaryRepresentationsOfGenderWithGenderNeutralLanguage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_neutral_pronouns")]
        UseNeutralPronouns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneBinaryRepresentationOfGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneBinaryRepresentationOfGender value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneBinaryRepresentationOfGender.AvoidBinaryRepresentationOfGenderWhenGenderNeutralLanguageCanBeUsed => "avoid_binary_representation_of_gender_when_gender_neutral_language_can_be_used",
                ConfiguredRulesStyleAndToneBinaryRepresentationOfGender.ReplaceBinaryRepresentationsOfGenderWithGenderNeutralLanguage => "replace_binary_representations_of_gender_with_gender_neutral_language",
                ConfiguredRulesStyleAndToneBinaryRepresentationOfGender.UseNeutralPronouns => "use_neutral_pronouns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneBinaryRepresentationOfGender? ToEnum(string value)
        {
            return value switch
            {
                "avoid_binary_representation_of_gender_when_gender_neutral_language_can_be_used" => ConfiguredRulesStyleAndToneBinaryRepresentationOfGender.AvoidBinaryRepresentationOfGenderWhenGenderNeutralLanguageCanBeUsed,
                "replace_binary_representations_of_gender_with_gender_neutral_language" => ConfiguredRulesStyleAndToneBinaryRepresentationOfGender.ReplaceBinaryRepresentationsOfGenderWithGenderNeutralLanguage,
                "use_neutral_pronouns" => ConfiguredRulesStyleAndToneBinaryRepresentationOfGender.UseNeutralPronouns,
                _ => null,
            };
        }
    }
}