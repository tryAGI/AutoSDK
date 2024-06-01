//HintName: G.Models.CommitComparisonStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: ahead
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CommitComparisonStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="diverged")]
        Diverged,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ahead")]
        Ahead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="behind")]
        Behind,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="identical")]
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
        public static CommitComparisonStatus ToEnum(string value)
        {
            return value switch
            {
                "diverged" => CommitComparisonStatus.Diverged,
                "ahead" => CommitComparisonStatus.Ahead,
                "behind" => CommitComparisonStatus.Behind,
                "identical" => CommitComparisonStatus.Identical,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}