//HintName: G.Models.CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The new status of the CodeQL variant analysis repository task.
    /// </summary>
    public abstract class CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Pending = "pending";
        /// <summary>
        /// 
        /// </summary>
        public const string InProgress = "in_progress";
        /// <summary>
        /// 
        /// </summary>
        public const string Succeeded = "succeeded";
        /// <summary>
        /// 
        /// </summary>
        public const string Failed = "failed";
        /// <summary>
        /// 
        /// </summary>
        public const string Canceled = "canceled";
        /// <summary>
        /// 
        /// </summary>
        public const string TimedOut = "timed_out";
    }
}