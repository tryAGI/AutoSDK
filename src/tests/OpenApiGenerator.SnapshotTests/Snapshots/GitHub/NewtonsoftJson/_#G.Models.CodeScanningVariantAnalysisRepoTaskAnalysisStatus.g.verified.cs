//HintName: G.Models.CodeScanningVariantAnalysisRepoTaskAnalysisStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The new status of the CodeQL variant analysis repository task.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningVariantAnalysisRepoTaskAnalysisStatus
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