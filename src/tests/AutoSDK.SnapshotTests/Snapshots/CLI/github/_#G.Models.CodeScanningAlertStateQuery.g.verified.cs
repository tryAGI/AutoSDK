﻿//HintName: G.Models.CodeScanningAlertStateQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    public enum CodeScanningAlertStateQuery
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningAlertStateQueryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAlertStateQuery value)
        {
            return value switch
            {
                CodeScanningAlertStateQuery.Open => "open",
                CodeScanningAlertStateQuery.Closed => "closed",
                CodeScanningAlertStateQuery.Dismissed => "dismissed",
                CodeScanningAlertStateQuery.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAlertStateQuery? ToEnum(string value)
        {
            return value switch
            {
                "open" => CodeScanningAlertStateQuery.Open,
                "closed" => CodeScanningAlertStateQuery.Closed,
                "dismissed" => CodeScanningAlertStateQuery.Dismissed,
                "fixed" => CodeScanningAlertStateQuery.Fixed,
                _ => null,
            };
        }
    }
}