//HintName: G.Models.ExperimentFilterBranchOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExperimentFilterBranchOperator
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
    public static class ExperimentFilterBranchOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentFilterBranchOperator value)
        {
            return value switch
            {
                ExperimentFilterBranchOperator.And => "and",
                ExperimentFilterBranchOperator.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentFilterBranchOperator? ToEnum(string value)
        {
            return value switch
            {
                "and" => ExperimentFilterBranchOperator.And,
                "or" => ExperimentFilterBranchOperator.Or,
                _ => null,
            };
        }
    }
}