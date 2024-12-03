//HintName: G.Models.RepositoryRuleDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepositoryRuleDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Creation,
        /// <summary>
        /// 
        /// </summary>
        Update,
        /// <summary>
        /// 
        /// </summary>
        Deletion,
        /// <summary>
        /// 
        /// </summary>
        RequiredLinearHistory,
        /// <summary>
        /// 
        /// </summary>
        MergeQueue,
        /// <summary>
        /// 
        /// </summary>
        RequiredDeployments,
        /// <summary>
        /// 
        /// </summary>
        RequiredSignatures,
        /// <summary>
        /// 
        /// </summary>
        PullRequest,
        /// <summary>
        /// 
        /// </summary>
        RequiredStatusChecks,
        /// <summary>
        /// 
        /// </summary>
        NonFastForward,
        /// <summary>
        /// 
        /// </summary>
        CommitMessagePattern,
        /// <summary>
        /// 
        /// </summary>
        CommitAuthorEmailPattern,
        /// <summary>
        /// 
        /// </summary>
        CommitterEmailPattern,
        /// <summary>
        /// 
        /// </summary>
        BranchNamePattern,
        /// <summary>
        /// 
        /// </summary>
        TagNamePattern,
        /// <summary>
        /// 
        /// </summary>
        FilePathRestriction,
        /// <summary>
        /// 
        /// </summary>
        MaxFilePathLength,
        /// <summary>
        /// 
        /// </summary>
        FileExtensionRestriction,
        /// <summary>
        /// 
        /// </summary>
        MaxFileSize,
        /// <summary>
        /// 
        /// </summary>
        Workflows,
        /// <summary>
        /// 
        /// </summary>
        CodeScanning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleDiscriminatorType value)
        {
            return value switch
            {
                RepositoryRuleDiscriminatorType.Creation => "creation",
                RepositoryRuleDiscriminatorType.Update => "update",
                RepositoryRuleDiscriminatorType.Deletion => "deletion",
                RepositoryRuleDiscriminatorType.RequiredLinearHistory => "required_linear_history",
                RepositoryRuleDiscriminatorType.MergeQueue => "merge_queue",
                RepositoryRuleDiscriminatorType.RequiredDeployments => "required_deployments",
                RepositoryRuleDiscriminatorType.RequiredSignatures => "required_signatures",
                RepositoryRuleDiscriminatorType.PullRequest => "pull_request",
                RepositoryRuleDiscriminatorType.RequiredStatusChecks => "required_status_checks",
                RepositoryRuleDiscriminatorType.NonFastForward => "non_fast_forward",
                RepositoryRuleDiscriminatorType.CommitMessagePattern => "commit_message_pattern",
                RepositoryRuleDiscriminatorType.CommitAuthorEmailPattern => "commit_author_email_pattern",
                RepositoryRuleDiscriminatorType.CommitterEmailPattern => "committer_email_pattern",
                RepositoryRuleDiscriminatorType.BranchNamePattern => "branch_name_pattern",
                RepositoryRuleDiscriminatorType.TagNamePattern => "tag_name_pattern",
                RepositoryRuleDiscriminatorType.FilePathRestriction => "file_path_restriction",
                RepositoryRuleDiscriminatorType.MaxFilePathLength => "max_file_path_length",
                RepositoryRuleDiscriminatorType.FileExtensionRestriction => "file_extension_restriction",
                RepositoryRuleDiscriminatorType.MaxFileSize => "max_file_size",
                RepositoryRuleDiscriminatorType.Workflows => "workflows",
                RepositoryRuleDiscriminatorType.CodeScanning => "code_scanning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "creation" => RepositoryRuleDiscriminatorType.Creation,
                "update" => RepositoryRuleDiscriminatorType.Update,
                "deletion" => RepositoryRuleDiscriminatorType.Deletion,
                "required_linear_history" => RepositoryRuleDiscriminatorType.RequiredLinearHistory,
                "merge_queue" => RepositoryRuleDiscriminatorType.MergeQueue,
                "required_deployments" => RepositoryRuleDiscriminatorType.RequiredDeployments,
                "required_signatures" => RepositoryRuleDiscriminatorType.RequiredSignatures,
                "pull_request" => RepositoryRuleDiscriminatorType.PullRequest,
                "required_status_checks" => RepositoryRuleDiscriminatorType.RequiredStatusChecks,
                "non_fast_forward" => RepositoryRuleDiscriminatorType.NonFastForward,
                "commit_message_pattern" => RepositoryRuleDiscriminatorType.CommitMessagePattern,
                "commit_author_email_pattern" => RepositoryRuleDiscriminatorType.CommitAuthorEmailPattern,
                "committer_email_pattern" => RepositoryRuleDiscriminatorType.CommitterEmailPattern,
                "branch_name_pattern" => RepositoryRuleDiscriminatorType.BranchNamePattern,
                "tag_name_pattern" => RepositoryRuleDiscriminatorType.TagNamePattern,
                "file_path_restriction" => RepositoryRuleDiscriminatorType.FilePathRestriction,
                "max_file_path_length" => RepositoryRuleDiscriminatorType.MaxFilePathLength,
                "file_extension_restriction" => RepositoryRuleDiscriminatorType.FileExtensionRestriction,
                "max_file_size" => RepositoryRuleDiscriminatorType.MaxFileSize,
                "workflows" => RepositoryRuleDiscriminatorType.Workflows,
                "code_scanning" => RepositoryRuleDiscriminatorType.CodeScanning,
                _ => null,
            };
        }
    }
}