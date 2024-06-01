//HintName: G.Models.CodeScanningVariantAnalysisFailureReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for a failure of the variant analysis. This is only available if the variant analysis has failed.
    /// </summary>
    public enum CodeScanningVariantAnalysisFailureReason
    {
        /// <summary>
        /// 
        /// </summary>
        NoReposQueried,
        /// <summary>
        /// 
        /// </summary>
        ActionsWorkflowRunFailed,
        /// <summary>
        /// 
        /// </summary>
        InternalError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningVariantAnalysisFailureReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningVariantAnalysisFailureReason value)
        {
            return value switch
            {
                CodeScanningVariantAnalysisFailureReason.NoReposQueried => "no_repos_queried",
                CodeScanningVariantAnalysisFailureReason.ActionsWorkflowRunFailed => "actions_workflow_run_failed",
                CodeScanningVariantAnalysisFailureReason.InternalError => "internal_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningVariantAnalysisFailureReason ToEnum(string value)
        {
            return value switch
            {
                "no_repos_queried" => CodeScanningVariantAnalysisFailureReason.NoReposQueried,
                "actions_workflow_run_failed" => CodeScanningVariantAnalysisFailureReason.ActionsWorkflowRunFailed,
                "internal_error" => CodeScanningVariantAnalysisFailureReason.InternalError,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}