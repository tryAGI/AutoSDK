//HintName: G.Models.ConfiguredRulesPunctuationColonToReplaceVersusOrTo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Colon To Replace Versus Or To
    /// </summary>
    public enum ConfiguredRulesPunctuationColonToReplaceVersusOrTo
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUseSpaceBeforeOrAfterColon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationColonToReplaceVersusOrToExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationColonToReplaceVersusOrTo value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationColonToReplaceVersusOrTo.DoNotUseSpaceBeforeOrAfterColon => "do_not_use_space_before_or_after_colon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationColonToReplaceVersusOrTo? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_space_before_or_after_colon" => ConfiguredRulesPunctuationColonToReplaceVersusOrTo.DoNotUseSpaceBeforeOrAfterColon,
                _ => null,
            };
        }
    }
}