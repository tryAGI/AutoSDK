﻿//HintName: G.Models.PullsListReviewCommentsForRepoSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PullsListReviewCommentsForRepoSort
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Updated,
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullsListReviewCommentsForRepoSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullsListReviewCommentsForRepoSort value)
        {
            return value switch
            {
                PullsListReviewCommentsForRepoSort.Created => "created",
                PullsListReviewCommentsForRepoSort.Updated => "updated",
                PullsListReviewCommentsForRepoSort.CreatedAt => "created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsListReviewCommentsForRepoSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => PullsListReviewCommentsForRepoSort.Created,
                "updated" => PullsListReviewCommentsForRepoSort.Updated,
                "created_at" => PullsListReviewCommentsForRepoSort.CreatedAt,
                _ => null,
            };
        }
    }
}