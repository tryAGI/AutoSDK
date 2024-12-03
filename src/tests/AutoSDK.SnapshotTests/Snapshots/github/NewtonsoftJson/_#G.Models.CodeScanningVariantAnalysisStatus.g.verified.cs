//HintName: G.Models.CodeScanningVariantAnalysisStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The new status of the CodeQL variant analysis repository task.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningVariantAnalysisStatus
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
    public static class CodeScanningVariantAnalysisStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningVariantAnalysisStatus value)
        {
            return value switch
            {
                CodeScanningVariantAnalysisStatus.Pending => "pending",
                CodeScanningVariantAnalysisStatus.InProgress => "in_progress",
                CodeScanningVariantAnalysisStatus.Succeeded => "succeeded",
                CodeScanningVariantAnalysisStatus.Failed => "failed",
                CodeScanningVariantAnalysisStatus.Canceled => "canceled",
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
                "pending" => CodeScanningVariantAnalysisStatus.Pending,
                "in_progress" => CodeScanningVariantAnalysisStatus.InProgress,
                "succeeded" => CodeScanningVariantAnalysisStatus.Succeeded,
                "failed" => CodeScanningVariantAnalysisStatus.Failed,
                "canceled" => CodeScanningVariantAnalysisStatus.Canceled,
                "timed_out" => CodeScanningVariantAnalysisStatus.TimedOut,
                _ => null,
            };
        }
    }
}