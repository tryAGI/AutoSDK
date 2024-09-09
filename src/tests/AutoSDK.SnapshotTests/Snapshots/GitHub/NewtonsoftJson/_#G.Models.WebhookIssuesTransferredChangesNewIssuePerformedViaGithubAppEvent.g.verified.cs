//HintName: G.Models.WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent
    {
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
        [global::System.Runtime.Serialization.EnumMember(Value="content_reference")]
        ContentReference,
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
        [global::System.Runtime.Serialization.EnumMember(Value="deployment_review")]
        DeploymentReview,
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
        [global::System.Runtime.Serialization.EnumMember(Value="repository_dispatch")]
        RepositoryDispatch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret_scanning_alert")]
        SecretScanningAlert,
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
        [global::System.Runtime.Serialization.EnumMember(Value="workflow_dispatch")]
        WorkflowDispatch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow_run")]
        WorkflowRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Create => "create",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Project => "project",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Public => "public",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Push => "push",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Release => "release",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}