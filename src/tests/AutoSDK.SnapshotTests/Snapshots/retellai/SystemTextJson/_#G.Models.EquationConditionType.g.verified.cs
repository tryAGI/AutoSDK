//HintName: G.Models.EquationConditionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EquationConditionType
    {
        /// <summary>
        /// 
        /// </summary>
        Equation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EquationConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EquationConditionType value)
        {
            return value switch
            {
                EquationConditionType.Equation => "equation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EquationConditionType? ToEnum(string value)
        {
            return value switch
            {
                "equation" => EquationConditionType.Equation,
                _ => null,
            };
        }
    }
}