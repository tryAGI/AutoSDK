//HintName: G.Models.UserFilterBranchOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserFilterBranchOperator
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
    public static class UserFilterBranchOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserFilterBranchOperator value)
        {
            return value switch
            {
                UserFilterBranchOperator.And => "and",
                UserFilterBranchOperator.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserFilterBranchOperator? ToEnum(string value)
        {
            return value switch
            {
                "and" => UserFilterBranchOperator.And,
                "or" => UserFilterBranchOperator.Or,
                _ => null,
            };
        }
    }
}