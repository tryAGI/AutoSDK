﻿//HintName: G.Models.CodeScanningListAlertsForRepoSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum CodeScanningListAlertsForRepoSort
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
    public static class CodeScanningListAlertsForRepoSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningListAlertsForRepoSort value)
        {
            return value switch
            {
                CodeScanningListAlertsForRepoSort.Created => "created",
                CodeScanningListAlertsForRepoSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningListAlertsForRepoSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => CodeScanningListAlertsForRepoSort.Created,
                "updated" => CodeScanningListAlertsForRepoSort.Updated,
                _ => null,
            };
        }
    }
}