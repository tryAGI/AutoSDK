//HintName: G.Models.CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The new status of the CodeQL variant analysis repository task.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="succeeded")]
        Succeeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="canceled")]
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timed_out")]
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus value)
        {
            return value switch
            {
                CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus.Pending => "pending",
                CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus.InProgress => "in_progress",
                CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus.Succeeded => "succeeded",
                CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus.Failed => "failed",
                CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus.Canceled => "canceled",
                CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus ToEnum(string value)
        {
            return value switch
            {
                "pending" => CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus.Pending,
                "in_progress" => CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus.InProgress,
                "succeeded" => CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus.Succeeded,
                "failed" => CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus.Failed,
                "canceled" => CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus.Canceled,
                "timed_out" => CodeScanningVariantAnalysisScannedRepositoriesAnalysisStatus.TimedOut,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}