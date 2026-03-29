//HintName: G.Models.EquationConditionOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EquationConditionOperator
    {
        /// <summary>
        /// 
        /// </summary>
        And,
        /// <summary>
        /// 
        /// </summary>
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EquationConditionOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EquationConditionOperator value)
        {
            return value switch
            {
                EquationConditionOperator.And => "and",
                EquationConditionOperator.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EquationConditionOperator? ToEnum(string value)
        {
            return value switch
            {
                "and" => EquationConditionOperator.And,
                "or" => EquationConditionOperator.Or,
                _ => null,
            };
        }
    }
}