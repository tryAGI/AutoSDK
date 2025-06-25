﻿//HintName: G.Models.PullsMergeRequestMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum PullsMergeRequestMergeMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Merge,
        /// <summary>
        /// 
        /// </summary>
        Squash,
        /// <summary>
        /// 
        /// </summary>
        Rebase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullsMergeRequestMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullsMergeRequestMergeMethod value)
        {
            return value switch
            {
                PullsMergeRequestMergeMethod.Merge => "merge",
                PullsMergeRequestMergeMethod.Squash => "squash",
                PullsMergeRequestMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsMergeRequestMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => PullsMergeRequestMergeMethod.Merge,
                "squash" => PullsMergeRequestMergeMethod.Squash,
                "rebase" => PullsMergeRequestMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}