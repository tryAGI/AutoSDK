//HintName: G.Models.WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesReopenedIssuePerformedViaGithubAppEvent
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
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_review_thread")]
        PullRequestReviewThread,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reminder")]
        Reminder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesReopenedIssuePerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssuePerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Create => "create",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Project => "project",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Public => "public",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Push => "push",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Release => "release",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Reminder => "reminder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssuePerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.WorkflowRun,
                "pull_request_review_thread" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.PullRequestReviewThread,
                "reminder" => WebhookIssuesReopenedIssuePerformedViaGithubAppEvent.Reminder,
                _ => null,
            };
        }
    }
}