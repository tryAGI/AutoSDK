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
}