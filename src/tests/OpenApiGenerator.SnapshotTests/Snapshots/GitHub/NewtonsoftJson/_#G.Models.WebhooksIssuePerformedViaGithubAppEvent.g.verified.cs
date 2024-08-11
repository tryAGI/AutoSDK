//HintName: G.Models.WebhooksIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksIssuePerformedViaGithubAppEvent
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reminder")]
        Reminder,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_review_thread")]
        PullRequestReviewThread,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksIssuePerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssuePerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhooksIssuePerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhooksIssuePerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhooksIssuePerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhooksIssuePerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhooksIssuePerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhooksIssuePerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhooksIssuePerformedViaGithubAppEvent.Create => "create",
                WebhooksIssuePerformedViaGithubAppEvent.Delete => "delete",
                WebhooksIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhooksIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhooksIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhooksIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhooksIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhooksIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhooksIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhooksIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhooksIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhooksIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhooksIssuePerformedViaGithubAppEvent.Label => "label",
                WebhooksIssuePerformedViaGithubAppEvent.Member => "member",
                WebhooksIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhooksIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhooksIssuePerformedViaGithubAppEvent.Organization => "organization",
                WebhooksIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhooksIssuePerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhooksIssuePerformedViaGithubAppEvent.Project => "project",
                WebhooksIssuePerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhooksIssuePerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhooksIssuePerformedViaGithubAppEvent.Public => "public",
                WebhooksIssuePerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhooksIssuePerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhooksIssuePerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhooksIssuePerformedViaGithubAppEvent.Push => "push",
                WebhooksIssuePerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhooksIssuePerformedViaGithubAppEvent.Release => "release",
                WebhooksIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhooksIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhooksIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhooksIssuePerformedViaGithubAppEvent.Star => "star",
                WebhooksIssuePerformedViaGithubAppEvent.Status => "status",
                WebhooksIssuePerformedViaGithubAppEvent.Team => "team",
                WebhooksIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhooksIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhooksIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhooksIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                WebhooksIssuePerformedViaGithubAppEvent.Reminder => "reminder",
                WebhooksIssuePerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssuePerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhooksIssuePerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhooksIssuePerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhooksIssuePerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhooksIssuePerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhooksIssuePerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhooksIssuePerformedViaGithubAppEvent.ContentReference,
                "create" => WebhooksIssuePerformedViaGithubAppEvent.Create,
                "delete" => WebhooksIssuePerformedViaGithubAppEvent.Delete,
                "deployment" => WebhooksIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhooksIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhooksIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhooksIssuePerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhooksIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhooksIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhooksIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhooksIssuePerformedViaGithubAppEvent.Gollum,
                "issues" => WebhooksIssuePerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhooksIssuePerformedViaGithubAppEvent.IssueComment,
                "label" => WebhooksIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhooksIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhooksIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhooksIssuePerformedViaGithubAppEvent.Milestone,
                "organization" => WebhooksIssuePerformedViaGithubAppEvent.Organization,
                "org_block" => WebhooksIssuePerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhooksIssuePerformedViaGithubAppEvent.PageBuild,
                "project" => WebhooksIssuePerformedViaGithubAppEvent.Project,
                "project_card" => WebhooksIssuePerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhooksIssuePerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhooksIssuePerformedViaGithubAppEvent.Public,
                "pull_request" => WebhooksIssuePerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhooksIssuePerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhooksIssuePerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhooksIssuePerformedViaGithubAppEvent.Push,
                "registry_package" => WebhooksIssuePerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhooksIssuePerformedViaGithubAppEvent.Release,
                "repository" => WebhooksIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhooksIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhooksIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhooksIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhooksIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhooksIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhooksIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhooksIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhooksIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhooksIssuePerformedViaGithubAppEvent.WorkflowRun,
                "reminder" => WebhooksIssuePerformedViaGithubAppEvent.Reminder,
                "pull_request_review_thread" => WebhooksIssuePerformedViaGithubAppEvent.PullRequestReviewThread,
                _ => null,
            };
        }
    }
}