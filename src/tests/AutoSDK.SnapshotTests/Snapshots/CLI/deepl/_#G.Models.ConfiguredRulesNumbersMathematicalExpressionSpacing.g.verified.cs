//HintName: G.Models.ConfiguredRulesNumbersMathematicalExpressionSpacing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Mathematical Expression Spacing
    /// </summary>
    public enum ConfiguredRulesNumbersMathematicalExpressionSpacing
    {
        /// <summary>
        /// 
        /// </summary>
        UseSpaceBetweenElementsOfMathematicalExpressionOrEquation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersMathematicalExpressionSpacingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersMathematicalExpressionSpacing value)
        {
            return value switch
            {
                ConfiguredRulesNumbersMathematicalExpressionSpacing.UseSpaceBetweenElementsOfMathematicalExpressionOrEquation => "use_space_between_elements_of_mathematical_expression_or_equation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersMathematicalExpressionSpacing? ToEnum(string value)
        {
            return value switch
            {
                "use_space_between_elements_of_mathematical_expression_or_equation" => ConfiguredRulesNumbersMathematicalExpressionSpacing.UseSpaceBetweenElementsOfMathematicalExpressionOrEquation,
                _ => null,
            };
        }
    }
}