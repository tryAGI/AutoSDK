//HintName: G.Models.WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents
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
    public static class WebhookIssueCommentCreatedIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Create => "create",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Label => "label",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Member => "member",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Project => "project",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Public => "public",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Push => "push",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Release => "release",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Star => "star",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Status => "status",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Team => "team",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Reminder => "reminder",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PullRequestReviewThread => "pull_request_review_thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.WorkflowRun,
                "reminder" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.Reminder,
                "pull_request_review_thread" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppEvents.PullRequestReviewThread,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}