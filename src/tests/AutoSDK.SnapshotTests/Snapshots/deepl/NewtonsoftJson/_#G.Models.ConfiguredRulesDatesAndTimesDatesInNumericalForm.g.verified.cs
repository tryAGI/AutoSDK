//HintName: G.Models.ConfiguredRulesDatesAndTimesDatesInNumericalForm.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Dates In Numerical Form
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesDatesAndTimesDatesInNumericalForm
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_dd_hyphen_mm_hyphen_yyyy")]
        UseDdHyphenMmHyphenYyyy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_dd_period_mm_period_yyyy")]
        UseDdPeriodMmPeriodYyyy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_dd_slash_mm_slash_yyyy")]
        UseDdSlashMmSlashYyyy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesDatesAndTimesDatesInNumericalFormExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesDatesAndTimesDatesInNumericalForm value)
        {
            return value switch
            {
                ConfiguredRulesDatesAndTimesDatesInNumericalForm.UseDdHyphenMmHyphenYyyy => "use_dd_hyphen_mm_hyphen_yyyy",
                ConfiguredRulesDatesAndTimesDatesInNumericalForm.UseDdPeriodMmPeriodYyyy => "use_dd_period_mm_period_yyyy",
                ConfiguredRulesDatesAndTimesDatesInNumericalForm.UseDdSlashMmSlashYyyy => "use_dd_slash_mm_slash_yyyy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesDatesAndTimesDatesInNumericalForm? ToEnum(string value)
        {
            return value switch
            {
                "use_dd_hyphen_mm_hyphen_yyyy" => ConfiguredRulesDatesAndTimesDatesInNumericalForm.UseDdHyphenMmHyphenYyyy,
                "use_dd_period_mm_period_yyyy" => ConfiguredRulesDatesAndTimesDatesInNumericalForm.UseDdPeriodMmPeriodYyyy,
                "use_dd_slash_mm_slash_yyyy" => ConfiguredRulesDatesAndTimesDatesInNumericalForm.UseDdSlashMmSlashYyyy,
                _ => null,
            };
        }
    }
}