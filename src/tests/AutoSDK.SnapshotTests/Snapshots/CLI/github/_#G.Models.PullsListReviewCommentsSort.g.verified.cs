﻿//HintName: G.Models.PullsListReviewCommentsSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum PullsListReviewCommentsSort
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullsListReviewCommentsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullsListReviewCommentsSort value)
        {
            return value switch
            {
                PullsListReviewCommentsSort.Created => "created",
                PullsListReviewCommentsSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsListReviewCommentsSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => PullsListReviewCommentsSort.Created,
                "updated" => PullsListReviewCommentsSort.Updated,
                _ => null,
            };
        }
    }
}