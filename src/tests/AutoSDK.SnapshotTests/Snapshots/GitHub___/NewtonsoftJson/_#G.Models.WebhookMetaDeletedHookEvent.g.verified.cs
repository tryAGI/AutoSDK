//HintName: G.Models.WebhookMetaDeletedHookEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookMetaDeletedHookEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="*")]
        Any,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="branch_protection_rule")]
        BranchProtectionRule,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="check_run")]
        CheckRun,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="check_suite")]
        CheckSuite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_scanning_alert")]
        CodeScanningAlert,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="commit_comment")]
        CommitComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create")]
        Create,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete")]
        Delete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment")]
        Deployment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployment_status")]
        DeploymentStatus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deploy_key")]
        DeployKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="discussion")]
        Discussion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="discussion_comment")]
        DiscussionComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fork")]
        Fork,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gollum")]
        Gollum,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="issues")]
        Issues,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="issue_comment")]
        IssueComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="label")]
        Label,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="membership")]
        Membership,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="meta")]
        Meta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="milestone")]
        Milestone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="org_block")]
        OrgBlock,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="package")]
        Package,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="page_build")]
        PageBuild,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project")]
        Project,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project_card")]
        ProjectCard,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project_column")]
        ProjectColumn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request")]
        PullRequest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_review")]
        PullRequestReview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_review_comment")]
        PullRequestReviewComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_review_thread")]
        PullRequestReviewThread,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="push")]
        Push,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="registry_package")]
        RegistryPackage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="release")]
        Release,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repository")]
        Repository,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repository_import")]
        RepositoryImport,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repository_vulnerability_alert")]
        RepositoryVulnerabilityAlert,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret_scanning_alert")]
        SecretScanningAlert,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret_scanning_alert_location")]
        SecretScanningAlertLocation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="security_and_analysis")]
        SecurityAndAnalysis,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="star")]
        Star,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="status")]
        Status,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="team")]
        Team,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="team_add")]
        TeamAdd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="watch")]
        Watch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow_job")]
        WorkflowJob,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow_run")]
        WorkflowRun,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repository_dispatch")]
        RepositoryDispatch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="projects_v2_item")]
        ProjectsV2Item,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMetaDeletedHookEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMetaDeletedHookEvent value)
        {
            return value switch
            {
                WebhookMetaDeletedHookEvent.Any => "*",
                WebhookMetaDeletedHookEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookMetaDeletedHookEvent.CheckRun => "check_run",
                WebhookMetaDeletedHookEvent.CheckSuite => "check_suite",
                WebhookMetaDeletedHookEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookMetaDeletedHookEvent.CommitComment => "commit_comment",
                WebhookMetaDeletedHookEvent.Create => "create",
                WebhookMetaDeletedHookEvent.Delete => "delete",
                WebhookMetaDeletedHookEvent.Deployment => "deployment",
                WebhookMetaDeletedHookEvent.DeploymentStatus => "deployment_status",
                WebhookMetaDeletedHookEvent.DeployKey => "deploy_key",
                WebhookMetaDeletedHookEvent.Discussion => "discussion",
                WebhookMetaDeletedHookEvent.DiscussionComment => "discussion_comment",
                WebhookMetaDeletedHookEvent.Fork => "fork",
                WebhookMetaDeletedHookEvent.Gollum => "gollum",
                WebhookMetaDeletedHookEvent.Issues => "issues",
                WebhookMetaDeletedHookEvent.IssueComment => "issue_comment",
                WebhookMetaDeletedHookEvent.Label => "label",
                WebhookMetaDeletedHookEvent.Member => "member",
                WebhookMetaDeletedHookEvent.Membership => "membership",
                WebhookMetaDeletedHookEvent.Meta => "meta",
                WebhookMetaDeletedHookEvent.Milestone => "milestone",
                WebhookMetaDeletedHookEvent.Organization => "organization",
                WebhookMetaDeletedHookEvent.OrgBlock => "org_block",
                WebhookMetaDeletedHookEvent.Package => "package",
                WebhookMetaDeletedHookEvent.PageBuild => "page_build",
                WebhookMetaDeletedHookEvent.Project => "project",
                WebhookMetaDeletedHookEvent.ProjectCard => "project_card",
                WebhookMetaDeletedHookEvent.ProjectColumn => "project_column",
                WebhookMetaDeletedHookEvent.Public => "public",
                WebhookMetaDeletedHookEvent.PullRequest => "pull_request",
                WebhookMetaDeletedHookEvent.PullRequestReview => "pull_request_review",
                WebhookMetaDeletedHookEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookMetaDeletedHookEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookMetaDeletedHookEvent.Push => "push",
                WebhookMetaDeletedHookEvent.RegistryPackage => "registry_package",
                WebhookMetaDeletedHookEvent.Release => "release",
                WebhookMetaDeletedHookEvent.Repository => "repository",
                WebhookMetaDeletedHookEvent.RepositoryImport => "repository_import",
                WebhookMetaDeletedHookEvent.RepositoryVulnerabilityAlert => "repository_vulnerability_alert",
                WebhookMetaDeletedHookEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookMetaDeletedHookEvent.SecretScanningAlertLocation => "secret_scanning_alert_location",
                WebhookMetaDeletedHookEvent.SecurityAndAnalysis => "security_and_analysis",
                WebhookMetaDeletedHookEvent.Star => "star",
                WebhookMetaDeletedHookEvent.Status => "status",
                WebhookMetaDeletedHookEvent.Team => "team",
                WebhookMetaDeletedHookEvent.TeamAdd => "team_add",
                WebhookMetaDeletedHookEvent.Watch => "watch",
                WebhookMetaDeletedHookEvent.WorkflowJob => "workflow_job",
                WebhookMetaDeletedHookEvent.WorkflowRun => "workflow_run",
                WebhookMetaDeletedHookEvent.RepositoryDispatch => "repository_dispatch",
                WebhookMetaDeletedHookEvent.ProjectsV2Item => "projects_v2_item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMetaDeletedHookEvent? ToEnum(string value)
        {
            return value switch
            {
                "*" => WebhookMetaDeletedHookEvent.Any,
                "branch_protection_rule" => WebhookMetaDeletedHookEvent.BranchProtectionRule,
                "check_run" => WebhookMetaDeletedHookEvent.CheckRun,
                "check_suite" => WebhookMetaDeletedHookEvent.CheckSuite,
                "code_scanning_alert" => WebhookMetaDeletedHookEvent.CodeScanningAlert,
                "commit_comment" => WebhookMetaDeletedHookEvent.CommitComment,
                "create" => WebhookMetaDeletedHookEvent.Create,
                "delete" => WebhookMetaDeletedHookEvent.Delete,
                "deployment" => WebhookMetaDeletedHookEvent.Deployment,
                "deployment_status" => WebhookMetaDeletedHookEvent.DeploymentStatus,
                "deploy_key" => WebhookMetaDeletedHookEvent.DeployKey,
                "discussion" => WebhookMetaDeletedHookEvent.Discussion,
                "discussion_comment" => WebhookMetaDeletedHookEvent.DiscussionComment,
                "fork" => WebhookMetaDeletedHookEvent.Fork,
                "gollum" => WebhookMetaDeletedHookEvent.Gollum,
                "issues" => WebhookMetaDeletedHookEvent.Issues,
                "issue_comment" => WebhookMetaDeletedHookEvent.IssueComment,
                "label" => WebhookMetaDeletedHookEvent.Label,
                "member" => WebhookMetaDeletedHookEvent.Member,
                "membership" => WebhookMetaDeletedHookEvent.Membership,
                "meta" => WebhookMetaDeletedHookEvent.Meta,
                "milestone" => WebhookMetaDeletedHookEvent.Milestone,
                "organization" => WebhookMetaDeletedHookEvent.Organization,
                "org_block" => WebhookMetaDeletedHookEvent.OrgBlock,
                "package" => WebhookMetaDeletedHookEvent.Package,
                "page_build" => WebhookMetaDeletedHookEvent.PageBuild,
                "project" => WebhookMetaDeletedHookEvent.Project,
                "project_card" => WebhookMetaDeletedHookEvent.ProjectCard,
                "project_column" => WebhookMetaDeletedHookEvent.ProjectColumn,
                "public" => WebhookMetaDeletedHookEvent.Public,
                "pull_request" => WebhookMetaDeletedHookEvent.PullRequest,
                "pull_request_review" => WebhookMetaDeletedHookEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookMetaDeletedHookEvent.PullRequestReviewComment,
                "pull_request_review_thread" => WebhookMetaDeletedHookEvent.PullRequestReviewThread,
                "push" => WebhookMetaDeletedHookEvent.Push,
                "registry_package" => WebhookMetaDeletedHookEvent.RegistryPackage,
                "release" => WebhookMetaDeletedHookEvent.Release,
                "repository" => WebhookMetaDeletedHookEvent.Repository,
                "repository_import" => WebhookMetaDeletedHookEvent.RepositoryImport,
                "repository_vulnerability_alert" => WebhookMetaDeletedHookEvent.RepositoryVulnerabilityAlert,
                "secret_scanning_alert" => WebhookMetaDeletedHookEvent.SecretScanningAlert,
                "secret_scanning_alert_location" => WebhookMetaDeletedHookEvent.SecretScanningAlertLocation,
                "security_and_analysis" => WebhookMetaDeletedHookEvent.SecurityAndAnalysis,
                "star" => WebhookMetaDeletedHookEvent.Star,
                "status" => WebhookMetaDeletedHookEvent.Status,
                "team" => WebhookMetaDeletedHookEvent.Team,
                "team_add" => WebhookMetaDeletedHookEvent.TeamAdd,
                "watch" => WebhookMetaDeletedHookEvent.Watch,
                "workflow_job" => WebhookMetaDeletedHookEvent.WorkflowJob,
                "workflow_run" => WebhookMetaDeletedHookEvent.WorkflowRun,
                "repository_dispatch" => WebhookMetaDeletedHookEvent.RepositoryDispatch,
                "projects_v2_item" => WebhookMetaDeletedHookEvent.ProjectsV2Item,
                _ => null,
            };
        }
    }
}