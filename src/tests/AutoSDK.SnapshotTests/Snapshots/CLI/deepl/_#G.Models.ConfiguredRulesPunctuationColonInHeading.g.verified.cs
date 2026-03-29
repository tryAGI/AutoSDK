//HintName: G.Models.ConfiguredRulesPunctuationColonInHeading.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Colon In Heading
    /// </summary>
    public enum ConfiguredRulesPunctuationColonInHeading
    {
        /// <summary>
        /// 
        /// </summary>
        UseSpaceAfterColonNotBefore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationColonInHeadingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationColonInHeading value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationColonInHeading.UseSpaceAfterColonNotBefore => "use_space_after_colon_not_before",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationColonInHeading? ToEnum(string value)
        {
            return value switch
            {
                "use_space_after_colon_not_before" => ConfiguredRulesPunctuationColonInHeading.UseSpaceAfterColonNotBefore,
                _ => null,
            };
        }
    }
}