//HintName: G.Models.WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLabeledIssuePerformedViaGithubAppEvents
    {
        /// <summary>
        /// 
        /// </summary>
        BranchProtectionRule,
        /// <summary>
        /// 
        /// </summary>
        CheckRun,
        /// <summary>
        /// 
        /// </summary>
        CheckSuite,
        /// <summary>
        /// 
        /// </summary>
        CodeScanningAlert,
        /// <summary>
        /// 
        /// </summary>
        CommitComment,
        /// <summary>
        /// 
        /// </summary>
        ContentReference,
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Deployment,
        /// <summary>
        /// 
        /// </summary>
        DeploymentReview,
        /// <summary>
        /// 
        /// </summary>
        DeploymentStatus,
        /// <summary>
        /// 
        /// </summary>
        DeployKey,
        /// <summary>
        /// 
        /// </summary>
        Discussion,
        /// <summary>
        /// 
        /// </summary>
        DiscussionComment,
        /// <summary>
        /// 
        /// </summary>
        Fork,
        /// <summary>
        /// 
        /// </summary>
        Gollum,
        /// <summary>
        /// 
        /// </summary>
        Issues,
        /// <summary>
        /// 
        /// </summary>
        IssueComment,
        /// <summary>
        /// 
        /// </summary>
        Label,
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        Membership,
        /// <summary>
        /// 
        /// </summary>
        Milestone,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        OrgBlock,
        /// <summary>
        /// 
        /// </summary>
        PageBuild,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        ProjectCard,
        /// <summary>
        /// 
        /// </summary>
        ProjectColumn,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        PullRequest,
        /// <summary>
        /// 
        /// </summary>
        PullRequestReview,
        /// <summary>
        /// 
        /// </summary>
        PullRequestReviewComment,
        /// <summary>
        /// 
        /// </summary>
        Push,
        /// <summary>
        /// 
        /// </summary>
        RegistryPackage,
        /// <summary>
        /// 
        /// </summary>
        Release,
        /// <summary>
        /// 
        /// </summary>
        Repository,
        /// <summary>
        /// 
        /// </summary>
        RepositoryDispatch,
        /// <summary>
        /// 
        /// </summary>
        SecretScanningAlert,
        /// <summary>
        /// 
        /// </summary>
        Star,
        /// <summary>
        /// 
        /// </summary>
        Status,
        /// <summary>
        /// 
        /// </summary>
        Team,
        /// <summary>
        /// 
        /// </summary>
        TeamAdd,
        /// <summary>
        /// 
        /// </summary>
        Watch,
        /// <summary>
        /// 
        /// </summary>
        WorkflowDispatch,
        /// <summary>
        /// 
        /// </summary>
        WorkflowRun,
        /// <summary>
        /// 
        /// </summary>
        PullRequestReviewThread,
        /// <summary>
        /// 
        /// </summary>
        Reminder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesLabeledIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Create => "create",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Label => "label",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Member => "member",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Project => "project",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Public => "public",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Push => "push",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Release => "release",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Star => "star",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Status => "status",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Team => "team",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.PullRequestReviewThread => "pull_request_review_thread",
                WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Reminder => "reminder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssuePerformedViaGithubAppEvents? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.WorkflowRun,
                "pull_request_review_thread" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.PullRequestReviewThread,
                "reminder" => WebhookIssuesLabeledIssuePerformedViaGithubAppEvents.Reminder,
                _ => null,
            };
        }
    }
}