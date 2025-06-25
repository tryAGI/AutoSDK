//HintName: G.Models.WebhookIssuesLabeledIssuePerformedViaGithubAppEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLabeledIssuePerformedViaGithubAppEvent
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