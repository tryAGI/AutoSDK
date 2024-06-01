//HintName: G.Models.PullsListReviewCommentsForRepoDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PullsListReviewCommentsForRepoDirection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullsListReviewCommentsForRepoDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullsListReviewCommentsForRepoDirection value)
        {
            return value switch
            {
                PullsListReviewCommentsForRepoDirection.Asc => "asc",
                PullsListReviewCommentsForRepoDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsListReviewCommentsForRepoDirection ToEnum(string value)
        {
            return value switch
            {
                "asc" => PullsListReviewCommentsForRepoDirection.Asc,
                "desc" => PullsListReviewCommentsForRepoDirection.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}