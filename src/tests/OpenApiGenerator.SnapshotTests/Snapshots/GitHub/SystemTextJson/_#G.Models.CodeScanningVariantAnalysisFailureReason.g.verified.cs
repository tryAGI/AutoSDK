//HintName: G.Models.CodeScanningVariantAnalysisFailureReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for a failure of the variant analysis. This is only available if the variant analysis has failed.
    /// </summary>
    public abstract class CodeScanningVariantAnalysisFailureReason
    {
        /// <summary>
        /// 
        /// </summary>
        public const string NoReposQueried = "no_repos_queried";
        /// <summary>
        /// 
        /// </summary>
        public const string ActionsWorkflowRunFailed = "actions_workflow_run_failed";
        /// <summary>
        /// 
        /// </summary>
        public const string InternalError = "internal_error";
    }
}