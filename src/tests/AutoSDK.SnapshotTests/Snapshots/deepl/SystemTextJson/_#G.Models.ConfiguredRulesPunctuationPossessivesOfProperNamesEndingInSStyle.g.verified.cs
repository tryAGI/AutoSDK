//HintName: G.Models.ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Possessives Of Proper Names Ending In S Style
    /// </summary>
    public enum ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyle
    {
        /// <summary>
        /// 
        /// </summary>
        AddApostropheOnly,
        /// <summary>
        /// 
        /// </summary>
        AddApostropheS,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyle value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyle.AddApostropheOnly => "add_apostrophe_only",
                ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyle.AddApostropheS => "add_apostrophe_s",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyle? ToEnum(string value)
        {
            return value switch
            {
                "add_apostrophe_only" => ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyle.AddApostropheOnly,
                "add_apostrophe_s" => ConfiguredRulesPunctuationPossessivesOfProperNamesEndingInSStyle.AddApostropheS,
                _ => null,
            };
        }
    }
}