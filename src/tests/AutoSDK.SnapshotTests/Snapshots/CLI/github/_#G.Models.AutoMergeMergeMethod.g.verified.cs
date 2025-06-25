﻿//HintName: G.Models.AutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum AutoMergeMergeMethod
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
    public static class AutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoMergeMergeMethod value)
        {
            return value switch
            {
                AutoMergeMergeMethod.Merge => "merge",
                AutoMergeMergeMethod.Squash => "squash",
                AutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => AutoMergeMergeMethod.Merge,
                "squash" => AutoMergeMergeMethod.Squash,
                "rebase" => AutoMergeMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}