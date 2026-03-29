//HintName: G.Models.ContainsParametersOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Operator to use for word checking<br/>
    /// Default Value: any
    /// </summary>
    public enum ContainsParametersOperator
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Any,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainsParametersOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainsParametersOperator value)
        {
            return value switch
            {
                ContainsParametersOperator.All => "all",
                ContainsParametersOperator.Any => "any",
                ContainsParametersOperator.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainsParametersOperator? ToEnum(string value)
        {
            return value switch
            {
                "all" => ContainsParametersOperator.All,
                "any" => ContainsParametersOperator.Any,
                "none" => ContainsParametersOperator.None,
                _ => null,
            };
        }
    }
}