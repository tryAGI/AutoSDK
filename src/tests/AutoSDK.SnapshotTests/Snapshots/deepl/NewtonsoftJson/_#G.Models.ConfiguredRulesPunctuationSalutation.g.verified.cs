//HintName: G.Models.ConfiguredRulesPunctuationSalutation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Salutation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationSalutation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_use_comma_after_salutation_capitalize_following_word")]
        DoNotUseCommaAfterSalutationCapitalizeFollowingWord,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_colon_after_salutation")]
        UseColonAfterSalutation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_comma_after_salutation")]
        UseCommaAfterSalutation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_exclamation_mark_after_salutation")]
        UseExclamationMarkAfterSalutation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationSalutationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationSalutation value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationSalutation.DoNotUseCommaAfterSalutationCapitalizeFollowingWord => "do_not_use_comma_after_salutation_capitalize_following_word",
                ConfiguredRulesPunctuationSalutation.UseColonAfterSalutation => "use_colon_after_salutation",
                ConfiguredRulesPunctuationSalutation.UseCommaAfterSalutation => "use_comma_after_salutation",
                ConfiguredRulesPunctuationSalutation.UseExclamationMarkAfterSalutation => "use_exclamation_mark_after_salutation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationSalutation? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_comma_after_salutation_capitalize_following_word" => ConfiguredRulesPunctuationSalutation.DoNotUseCommaAfterSalutationCapitalizeFollowingWord,
                "use_colon_after_salutation" => ConfiguredRulesPunctuationSalutation.UseColonAfterSalutation,
                "use_comma_after_salutation" => ConfiguredRulesPunctuationSalutation.UseCommaAfterSalutation,
                "use_exclamation_mark_after_salutation" => ConfiguredRulesPunctuationSalutation.UseExclamationMarkAfterSalutation,
                _ => null,
            };
        }
    }
}