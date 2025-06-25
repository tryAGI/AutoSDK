﻿//HintName: G.Models.CodeScanningVariantAnalysisStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeScanningVariantAnalysisStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningVariantAnalysisStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningVariantAnalysisStatus2 value)
        {
            return value switch
            {
                CodeScanningVariantAnalysisStatus2.InProgress => "in_progress",
                CodeScanningVariantAnalysisStatus2.Succeeded => "succeeded",
                CodeScanningVariantAnalysisStatus2.Failed => "failed",
                CodeScanningVariantAnalysisStatus2.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningVariantAnalysisStatus2? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => CodeScanningVariantAnalysisStatus2.InProgress,
                "succeeded" => CodeScanningVariantAnalysisStatus2.Succeeded,
                "failed" => CodeScanningVariantAnalysisStatus2.Failed,
                "cancelled" => CodeScanningVariantAnalysisStatus2.Cancelled,
                _ => null,
            };
        }
    }
}