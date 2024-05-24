//HintName: G.Models.CodeScanningVariantAnalysisFailureReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for a failure of the variant analysis. This is only available if the variant analysis has failed.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningVariantAnalysisFailureReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="no_repos_queried")]
        NoReposQueried,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="actions_workflow_run_failed")]
        ActionsWorkflowRunFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal_error")]
        InternalError,
    }
}