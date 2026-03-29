//HintName: G.Models.SessionFilterBranchOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SessionFilterBranchOperator
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
    public static class SessionFilterBranchOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionFilterBranchOperator value)
        {
            return value switch
            {
                SessionFilterBranchOperator.And => "and",
                SessionFilterBranchOperator.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionFilterBranchOperator? ToEnum(string value)
        {
            return value switch
            {
                "and" => SessionFilterBranchOperator.And,
                "or" => SessionFilterBranchOperator.Or,
                _ => null,
            };
        }
    }
}