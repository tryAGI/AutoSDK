//HintName: G.Models.ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Inflected Words Masculine Noun Agreement
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="place_masculine_nouns_closest_to_inflected_words")]
        PlaceMasculineNounsClosestToInflectedWords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement.PlaceMasculineNounsClosestToInflectedWords => "place_masculine_nouns_closest_to_inflected_words",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement? ToEnum(string value)
        {
            return value switch
            {
                "place_masculine_nouns_closest_to_inflected_words" => ConfiguredRulesStyleAndToneInflectedWordsMasculineNounAgreement.PlaceMasculineNounsClosestToInflectedWords,
                _ => null,
            };
        }
    }
}