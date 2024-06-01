//HintName: G.Models.CodeScanningVariantAnalysisRepoTaskAnalysisStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The new status of the CodeQL variant analysis repository task.
    /// </summary>
    public enum CodeScanningVariantAnalysisRepoTaskAnalysisStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
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
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningVariantAnalysisRepoTaskAnalysisStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningVariantAnalysisRepoTaskAnalysisStatus value)
        {
            return value switch
            {
                CodeScanningVariantAnalysisRepoTaskAnalysisStatus.Pending => "pending",
                CodeScanningVariantAnalysisRepoTaskAnalysisStatus.InProgress => "in_progress",
                CodeScanningVariantAnalysisRepoTaskAnalysisStatus.Succeeded => "succeeded",
                CodeScanningVariantAnalysisRepoTaskAnalysisStatus.Failed => "failed",
                CodeScanningVariantAnalysisRepoTaskAnalysisStatus.Canceled => "canceled",
                CodeScanningVariantAnalysisRepoTaskAnalysisStatus.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningVariantAnalysisRepoTaskAnalysisStatus ToEnum(string value)
        {
            return value switch
            {
                "pending" => CodeScanningVariantAnalysisRepoTaskAnalysisStatus.Pending,
                "in_progress" => CodeScanningVariantAnalysisRepoTaskAnalysisStatus.InProgress,
                "succeeded" => CodeScanningVariantAnalysisRepoTaskAnalysisStatus.Succeeded,
                "failed" => CodeScanningVariantAnalysisRepoTaskAnalysisStatus.Failed,
                "canceled" => CodeScanningVariantAnalysisRepoTaskAnalysisStatus.Canceled,
                "timed_out" => CodeScanningVariantAnalysisRepoTaskAnalysisStatus.TimedOut,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}