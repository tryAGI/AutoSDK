//HintName: G.Models.RepositoryRuleDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="branch_name_pattern")]
        BranchNamePattern,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_scanning")]
        CodeScanning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="commit_author_email_pattern")]
        CommitAuthorEmailPattern,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="commit_message_pattern")]
        CommitMessagePattern,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="committer_email_pattern")]
        CommitterEmailPattern,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="creation")]
        Creation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deletion")]
        Deletion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_extension_restriction")]
        FileExtensionRestriction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_path_restriction")]
        FilePathRestriction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max_file_path_length")]
        MaxFilePathLength,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max_file_size")]
        MaxFileSize,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="merge_queue")]
        MergeQueue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="non_fast_forward")]
        NonFastForward,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request")]
        PullRequest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="required_deployments")]
        RequiredDeployments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="required_linear_history")]
        RequiredLinearHistory,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="required_signatures")]
        RequiredSignatures,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="required_status_checks")]
        RequiredStatusChecks,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tag_name_pattern")]
        TagNamePattern,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="update")]
        Update,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflows")]
        Workflows,
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
                RepositoryRuleDiscriminatorType.BranchNamePattern => "branch_name_pattern",
                RepositoryRuleDiscriminatorType.CodeScanning => "code_scanning",
                RepositoryRuleDiscriminatorType.CommitAuthorEmailPattern => "commit_author_email_pattern",
                RepositoryRuleDiscriminatorType.CommitMessagePattern => "commit_message_pattern",
                RepositoryRuleDiscriminatorType.CommitterEmailPattern => "committer_email_pattern",
                RepositoryRuleDiscriminatorType.Creation => "creation",
                RepositoryRuleDiscriminatorType.Deletion => "deletion",
                RepositoryRuleDiscriminatorType.FileExtensionRestriction => "file_extension_restriction",
                RepositoryRuleDiscriminatorType.FilePathRestriction => "file_path_restriction",
                RepositoryRuleDiscriminatorType.MaxFilePathLength => "max_file_path_length",
                RepositoryRuleDiscriminatorType.MaxFileSize => "max_file_size",
                RepositoryRuleDiscriminatorType.MergeQueue => "merge_queue",
                RepositoryRuleDiscriminatorType.NonFastForward => "non_fast_forward",
                RepositoryRuleDiscriminatorType.PullRequest => "pull_request",
                RepositoryRuleDiscriminatorType.RequiredDeployments => "required_deployments",
                RepositoryRuleDiscriminatorType.RequiredLinearHistory => "required_linear_history",
                RepositoryRuleDiscriminatorType.RequiredSignatures => "required_signatures",
                RepositoryRuleDiscriminatorType.RequiredStatusChecks => "required_status_checks",
                RepositoryRuleDiscriminatorType.TagNamePattern => "tag_name_pattern",
                RepositoryRuleDiscriminatorType.Update => "update",
                RepositoryRuleDiscriminatorType.Workflows => "workflows",
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
                "branch_name_pattern" => RepositoryRuleDiscriminatorType.BranchNamePattern,
                "code_scanning" => RepositoryRuleDiscriminatorType.CodeScanning,
                "commit_author_email_pattern" => RepositoryRuleDiscriminatorType.CommitAuthorEmailPattern,
                "commit_message_pattern" => RepositoryRuleDiscriminatorType.CommitMessagePattern,
                "committer_email_pattern" => RepositoryRuleDiscriminatorType.CommitterEmailPattern,
                "creation" => RepositoryRuleDiscriminatorType.Creation,
                "deletion" => RepositoryRuleDiscriminatorType.Deletion,
                "file_extension_restriction" => RepositoryRuleDiscriminatorType.FileExtensionRestriction,
                "file_path_restriction" => RepositoryRuleDiscriminatorType.FilePathRestriction,
                "max_file_path_length" => RepositoryRuleDiscriminatorType.MaxFilePathLength,
                "max_file_size" => RepositoryRuleDiscriminatorType.MaxFileSize,
                "merge_queue" => RepositoryRuleDiscriminatorType.MergeQueue,
                "non_fast_forward" => RepositoryRuleDiscriminatorType.NonFastForward,
                "pull_request" => RepositoryRuleDiscriminatorType.PullRequest,
                "required_deployments" => RepositoryRuleDiscriminatorType.RequiredDeployments,
                "required_linear_history" => RepositoryRuleDiscriminatorType.RequiredLinearHistory,
                "required_signatures" => RepositoryRuleDiscriminatorType.RequiredSignatures,
                "required_status_checks" => RepositoryRuleDiscriminatorType.RequiredStatusChecks,
                "tag_name_pattern" => RepositoryRuleDiscriminatorType.TagNamePattern,
                "update" => RepositoryRuleDiscriminatorType.Update,
                "workflows" => RepositoryRuleDiscriminatorType.Workflows,
                _ => null,
            };
        }
    }
}