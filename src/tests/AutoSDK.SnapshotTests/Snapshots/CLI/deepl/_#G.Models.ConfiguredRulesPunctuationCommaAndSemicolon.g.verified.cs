//HintName: G.Models.ConfiguredRulesPunctuationCommaAndSemicolon.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Comma And Semicolon
    /// </summary>
    public enum ConfiguredRulesPunctuationCommaAndSemicolon
    {
        /// <summary>
        /// 
        /// </summary>
        UseCommaBetweenClauses,
        /// <summary>
        /// 
        /// </summary>
        UseSemicolonBetweenClauses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationCommaAndSemicolonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationCommaAndSemicolon value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationCommaAndSemicolon.UseCommaBetweenClauses => "use_comma_between_clauses",
                ConfiguredRulesPunctuationCommaAndSemicolon.UseSemicolonBetweenClauses => "use_semicolon_between_clauses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationCommaAndSemicolon? ToEnum(string value)
        {
            return value switch
            {
                "use_comma_between_clauses" => ConfiguredRulesPunctuationCommaAndSemicolon.UseCommaBetweenClauses,
                "use_semicolon_between_clauses" => ConfiguredRulesPunctuationCommaAndSemicolon.UseSemicolonBetweenClauses,
                _ => null,
            };
        }
    }
}