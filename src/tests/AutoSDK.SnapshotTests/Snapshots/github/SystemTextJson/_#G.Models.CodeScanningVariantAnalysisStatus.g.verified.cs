//HintName: G.Models.CodeScanningVariantAnalysisStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The new status of the CodeQL variant analysis repository task.
    /// </summary>
    public enum CodeScanningVariantAnalysisStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningVariantAnalysisStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningVariantAnalysisStatus value)
        {
            return value switch
            {
                CodeScanningVariantAnalysisStatus.Canceled => "canceled",
                CodeScanningVariantAnalysisStatus.Failed => "failed",
                CodeScanningVariantAnalysisStatus.InProgress => "in_progress",
                CodeScanningVariantAnalysisStatus.Pending => "pending",
                CodeScanningVariantAnalysisStatus.Succeeded => "succeeded",
                CodeScanningVariantAnalysisStatus.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningVariantAnalysisStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => CodeScanningVariantAnalysisStatus.Canceled,
                "failed" => CodeScanningVariantAnalysisStatus.Failed,
                "in_progress" => CodeScanningVariantAnalysisStatus.InProgress,
                "pending" => CodeScanningVariantAnalysisStatus.Pending,
                "succeeded" => CodeScanningVariantAnalysisStatus.Succeeded,
                "timed_out" => CodeScanningVariantAnalysisStatus.TimedOut,
                _ => null,
            };
        }
    }
}