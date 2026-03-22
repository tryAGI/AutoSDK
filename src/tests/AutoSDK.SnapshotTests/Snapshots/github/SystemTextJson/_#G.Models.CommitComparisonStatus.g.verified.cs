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
        Ahead,
        /// <summary>
        /// 
        /// </summary>
        Behind,
        /// <summary>
        /// 
        /// </summary>
        Diverged,
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
                CommitComparisonStatus.Ahead => "ahead",
                CommitComparisonStatus.Behind => "behind",
                CommitComparisonStatus.Diverged => "diverged",
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
                "ahead" => CommitComparisonStatus.Ahead,
                "behind" => CommitComparisonStatus.Behind,
                "diverged" => CommitComparisonStatus.Diverged,
                "identical" => CommitComparisonStatus.Identical,
                _ => null,
            };
        }
    }
}