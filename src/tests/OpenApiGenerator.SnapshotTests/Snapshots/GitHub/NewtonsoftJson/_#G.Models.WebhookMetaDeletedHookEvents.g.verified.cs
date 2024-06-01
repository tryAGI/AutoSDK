//HintName: G.Models.WebhookMetaDeletedHookEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookMetaDeletedHookEvents
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
    public static class WebhookMetaDeletedHookEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMetaDeletedHookEvents value)
        {
            return value switch
            {
                WebhookMetaDeletedHookEvents.Any => "*",
                WebhookMetaDeletedHookEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookMetaDeletedHookEvents.CheckRun => "check_run",
                WebhookMetaDeletedHookEvents.CheckSuite => "check_suite",
                WebhookMetaDeletedHookEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookMetaDeletedHookEvents.CommitComment => "commit_comment",
                WebhookMetaDeletedHookEvents.Create => "create",
                WebhookMetaDeletedHookEvents.Delete => "delete",
                WebhookMetaDeletedHookEvents.Deployment => "deployment",
                WebhookMetaDeletedHookEvents.DeploymentStatus => "deployment_status",
                WebhookMetaDeletedHookEvents.DeployKey => "deploy_key",
                WebhookMetaDeletedHookEvents.Discussion => "discussion",
                WebhookMetaDeletedHookEvents.DiscussionComment => "discussion_comment",
                WebhookMetaDeletedHookEvents.Fork => "fork",
                WebhookMetaDeletedHookEvents.Gollum => "gollum",
                WebhookMetaDeletedHookEvents.Issues => "issues",
                WebhookMetaDeletedHookEvents.IssueComment => "issue_comment",
                WebhookMetaDeletedHookEvents.Label => "label",
                WebhookMetaDeletedHookEvents.Member => "member",
                WebhookMetaDeletedHookEvents.Membership => "membership",
                WebhookMetaDeletedHookEvents.Meta => "meta",
                WebhookMetaDeletedHookEvents.Milestone => "milestone",
                WebhookMetaDeletedHookEvents.Organization => "organization",
                WebhookMetaDeletedHookEvents.OrgBlock => "org_block",
                WebhookMetaDeletedHookEvents.Package => "package",
                WebhookMetaDeletedHookEvents.PageBuild => "page_build",
                WebhookMetaDeletedHookEvents.Project => "project",
                WebhookMetaDeletedHookEvents.ProjectCard => "project_card",
                WebhookMetaDeletedHookEvents.ProjectColumn => "project_column",
                WebhookMetaDeletedHookEvents.Public => "public",
                WebhookMetaDeletedHookEvents.PullRequest => "pull_request",
                WebhookMetaDeletedHookEvents.PullRequestReview => "pull_request_review",
                WebhookMetaDeletedHookEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookMetaDeletedHookEvents.PullRequestReviewThread => "pull_request_review_thread",
                WebhookMetaDeletedHookEvents.Push => "push",
                WebhookMetaDeletedHookEvents.RegistryPackage => "registry_package",
                WebhookMetaDeletedHookEvents.Release => "release",
                WebhookMetaDeletedHookEvents.Repository => "repository",
                WebhookMetaDeletedHookEvents.RepositoryImport => "repository_import",
                WebhookMetaDeletedHookEvents.RepositoryVulnerabilityAlert => "repository_vulnerability_alert",
                WebhookMetaDeletedHookEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookMetaDeletedHookEvents.SecretScanningAlertLocation => "secret_scanning_alert_location",
                WebhookMetaDeletedHookEvents.SecurityAndAnalysis => "security_and_analysis",
                WebhookMetaDeletedHookEvents.Star => "star",
                WebhookMetaDeletedHookEvents.Status => "status",
                WebhookMetaDeletedHookEvents.Team => "team",
                WebhookMetaDeletedHookEvents.TeamAdd => "team_add",
                WebhookMetaDeletedHookEvents.Watch => "watch",
                WebhookMetaDeletedHookEvents.WorkflowJob => "workflow_job",
                WebhookMetaDeletedHookEvents.WorkflowRun => "workflow_run",
                WebhookMetaDeletedHookEvents.RepositoryDispatch => "repository_dispatch",
                WebhookMetaDeletedHookEvents.ProjectsV2Item => "projects_v2_item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMetaDeletedHookEvents ToEnum(string value)
        {
            return value switch
            {
                "*" => WebhookMetaDeletedHookEvents.Any,
                "branch_protection_rule" => WebhookMetaDeletedHookEvents.BranchProtectionRule,
                "check_run" => WebhookMetaDeletedHookEvents.CheckRun,
                "check_suite" => WebhookMetaDeletedHookEvents.CheckSuite,
                "code_scanning_alert" => WebhookMetaDeletedHookEvents.CodeScanningAlert,
                "commit_comment" => WebhookMetaDeletedHookEvents.CommitComment,
                "create" => WebhookMetaDeletedHookEvents.Create,
                "delete" => WebhookMetaDeletedHookEvents.Delete,
                "deployment" => WebhookMetaDeletedHookEvents.Deployment,
                "deployment_status" => WebhookMetaDeletedHookEvents.DeploymentStatus,
                "deploy_key" => WebhookMetaDeletedHookEvents.DeployKey,
                "discussion" => WebhookMetaDeletedHookEvents.Discussion,
                "discussion_comment" => WebhookMetaDeletedHookEvents.DiscussionComment,
                "fork" => WebhookMetaDeletedHookEvents.Fork,
                "gollum" => WebhookMetaDeletedHookEvents.Gollum,
                "issues" => WebhookMetaDeletedHookEvents.Issues,
                "issue_comment" => WebhookMetaDeletedHookEvents.IssueComment,
                "label" => WebhookMetaDeletedHookEvents.Label,
                "member" => WebhookMetaDeletedHookEvents.Member,
                "membership" => WebhookMetaDeletedHookEvents.Membership,
                "meta" => WebhookMetaDeletedHookEvents.Meta,
                "milestone" => WebhookMetaDeletedHookEvents.Milestone,
                "organization" => WebhookMetaDeletedHookEvents.Organization,
                "org_block" => WebhookMetaDeletedHookEvents.OrgBlock,
                "package" => WebhookMetaDeletedHookEvents.Package,
                "page_build" => WebhookMetaDeletedHookEvents.PageBuild,
                "project" => WebhookMetaDeletedHookEvents.Project,
                "project_card" => WebhookMetaDeletedHookEvents.ProjectCard,
                "project_column" => WebhookMetaDeletedHookEvents.ProjectColumn,
                "public" => WebhookMetaDeletedHookEvents.Public,
                "pull_request" => WebhookMetaDeletedHookEvents.PullRequest,
                "pull_request_review" => WebhookMetaDeletedHookEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookMetaDeletedHookEvents.PullRequestReviewComment,
                "pull_request_review_thread" => WebhookMetaDeletedHookEvents.PullRequestReviewThread,
                "push" => WebhookMetaDeletedHookEvents.Push,
                "registry_package" => WebhookMetaDeletedHookEvents.RegistryPackage,
                "release" => WebhookMetaDeletedHookEvents.Release,
                "repository" => WebhookMetaDeletedHookEvents.Repository,
                "repository_import" => WebhookMetaDeletedHookEvents.RepositoryImport,
                "repository_vulnerability_alert" => WebhookMetaDeletedHookEvents.RepositoryVulnerabilityAlert,
                "secret_scanning_alert" => WebhookMetaDeletedHookEvents.SecretScanningAlert,
                "secret_scanning_alert_location" => WebhookMetaDeletedHookEvents.SecretScanningAlertLocation,
                "security_and_analysis" => WebhookMetaDeletedHookEvents.SecurityAndAnalysis,
                "star" => WebhookMetaDeletedHookEvents.Star,
                "status" => WebhookMetaDeletedHookEvents.Status,
                "team" => WebhookMetaDeletedHookEvents.Team,
                "team_add" => WebhookMetaDeletedHookEvents.TeamAdd,
                "watch" => WebhookMetaDeletedHookEvents.Watch,
                "workflow_job" => WebhookMetaDeletedHookEvents.WorkflowJob,
                "workflow_run" => WebhookMetaDeletedHookEvents.WorkflowRun,
                "repository_dispatch" => WebhookMetaDeletedHookEvents.RepositoryDispatch,
                "projects_v2_item" => WebhookMetaDeletedHookEvents.ProjectsV2Item,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}