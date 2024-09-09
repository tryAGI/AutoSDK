//HintName: G.Models.CommitComparisonStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: ahead
    /// </summary>
    public enum CommitComparisonStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Diverged,
        /// <summary>
        /// 
        /// </summary>
        Ahead,
        /// <summary>
        /// 
        /// </summary>
        Behind,
        /// <summary>
        /// 
        /// </summary>
        Identical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CommitComparisonStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommitComparisonStatus value)
        {
            return value switch
            {
                CommitComparisonStatus.Diverged => "diverged",
                CommitComparisonStatus.Ahead => "ahead",
                CommitComparisonStatus.Behind => "behind",
                CommitComparisonStatus.Identical => "identical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommitComparisonStatus? ToEnum(string value)
        {
            return value switch
            {
                "diverged" => CommitComparisonStatus.Diverged,
                "ahead" => CommitComparisonStatus.Ahead,
                "behind" => CommitComparisonStatus.Behind,
                "identical" => CommitComparisonStatus.Identical,
                _ => null,
            };
        }
    }
}