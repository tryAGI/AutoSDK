//HintName: G.Models.EvalFilterBranchOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EvalFilterBranchOperator
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
    public static class EvalFilterBranchOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalFilterBranchOperator value)
        {
            return value switch
            {
                EvalFilterBranchOperator.And => "and",
                EvalFilterBranchOperator.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalFilterBranchOperator? ToEnum(string value)
        {
            return value switch
            {
                "and" => EvalFilterBranchOperator.And,
                "or" => EvalFilterBranchOperator.Or,
                _ => null,
            };
        }
    }
}