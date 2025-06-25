﻿//HintName: G.Models.CodeScanningDefaultSetupQuerySuite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CodeQL query suite to be used.
    /// </summary>
    public enum CodeScanningDefaultSetupQuerySuite
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
    public static class CodeScanningDefaultSetupQuerySuiteExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupQuerySuite value)
        {
            return value switch
            {
                CodeScanningDefaultSetupQuerySuite.Default => "default",
                CodeScanningDefaultSetupQuerySuite.Extended => "extended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupQuerySuite? ToEnum(string value)
        {
            return value switch
            {
                "default" => CodeScanningDefaultSetupQuerySuite.Default,
                "extended" => CodeScanningDefaultSetupQuerySuite.Extended,
                _ => null,
            };
        }
    }
}