//HintName: G.Models.ConfiguredRulesSpellingAndGrammarInformalAddressPronouns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Informal Address Pronouns
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesSpellingAndGrammarInformalAddressPronouns
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="capitalize_informal_address_pronouns")]
        CapitalizeInformalAddressPronouns,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_capitalize_informal_address_pronouns")]
        DoNotCapitalizeInformalAddressPronouns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarInformalAddressPronounsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarInformalAddressPronouns value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarInformalAddressPronouns.CapitalizeInformalAddressPronouns => "capitalize_informal_address_pronouns",
                ConfiguredRulesSpellingAndGrammarInformalAddressPronouns.DoNotCapitalizeInformalAddressPronouns => "do_not_capitalize_informal_address_pronouns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarInformalAddressPronouns? ToEnum(string value)
        {
            return value switch
            {
                "capitalize_informal_address_pronouns" => ConfiguredRulesSpellingAndGrammarInformalAddressPronouns.CapitalizeInformalAddressPronouns,
                "do_not_capitalize_informal_address_pronouns" => ConfiguredRulesSpellingAndGrammarInformalAddressPronouns.DoNotCapitalizeInformalAddressPronouns,
                _ => null,
            };
        }
    }
}