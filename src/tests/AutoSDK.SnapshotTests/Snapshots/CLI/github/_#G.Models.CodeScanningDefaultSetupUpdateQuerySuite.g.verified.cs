﻿//HintName: G.Models.CodeScanningDefaultSetupUpdateQuerySuite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CodeQL query suite to be used.
    /// </summary>
    public enum CodeScanningDefaultSetupUpdateQuerySuite
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Extended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningDefaultSetupUpdateQuerySuiteExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupUpdateQuerySuite value)
        {
            return value switch
            {
                CodeScanningDefaultSetupUpdateQuerySuite.Default => "default",
                CodeScanningDefaultSetupUpdateQuerySuite.Extended => "extended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupUpdateQuerySuite? ToEnum(string value)
        {
            return value switch
            {
                "default" => CodeScanningDefaultSetupUpdateQuerySuite.Default,
                "extended" => CodeScanningDefaultSetupUpdateQuerySuite.Extended,
                _ => null,
            };
        }
    }
}