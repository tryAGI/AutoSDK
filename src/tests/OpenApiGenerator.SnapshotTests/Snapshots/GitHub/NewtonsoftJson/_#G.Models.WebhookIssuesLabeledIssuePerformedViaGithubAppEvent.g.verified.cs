//HintName: G.Models.WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesLabeledIssuePerformedViaGithubAppEvent
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
    public static class WebhookIssuesLabeledIssuePerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssuePerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Create => "create",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Label => "label",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Member => "member",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Project => "project",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Public => "public",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Push => "push",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Release => "release",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Star => "star",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Status => "status",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Team => "team",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.PullRequestReviewThread => "pull_request_review_thread",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Reminder => "reminder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssuePerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Delete,
                "deployment" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.DeploymentStatus,
                "deploy_key" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.DeployKey,
                "discussion" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Gollum,
                "issues" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Issues,
                "issue_comment" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.IssueComment,
                "label" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Label,
                "member" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Milestone,
                "organization" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Organization,
                "org_block" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.OrgBlock,
                "page_build" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Star,
                "status" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Status,
                "team" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.WorkflowRun,
                "pull_request_review_thread" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.PullRequestReviewThread,
                "reminder" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.Reminder,
                _ => null,
            };
        }
    }
}