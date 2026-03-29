//HintName: G.Models.DatasetFilterBranchOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetFilterBranchOperator
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
    public static class DatasetFilterBranchOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetFilterBranchOperator value)
        {
            return value switch
            {
                DatasetFilterBranchOperator.And => "and",
                DatasetFilterBranchOperator.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetFilterBranchOperator? ToEnum(string value)
        {
            return value switch
            {
                "and" => DatasetFilterBranchOperator.And,
                "or" => DatasetFilterBranchOperator.Or,
                _ => null,
            };
        }
    }
}