//HintName: G.Models.PromptsFilterBranchOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptsFilterBranchOperator
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
    public static class PromptsFilterBranchOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptsFilterBranchOperator value)
        {
            return value switch
            {
                PromptsFilterBranchOperator.And => "and",
                PromptsFilterBranchOperator.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptsFilterBranchOperator? ToEnum(string value)
        {
            return value switch
            {
                "and" => PromptsFilterBranchOperator.And,
                "or" => PromptsFilterBranchOperator.Or,
                _ => null,
            };
        }
    }
}