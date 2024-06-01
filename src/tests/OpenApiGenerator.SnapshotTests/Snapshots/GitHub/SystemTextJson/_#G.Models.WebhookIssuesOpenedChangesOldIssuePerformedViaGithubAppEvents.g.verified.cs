//HintName: G.Models.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.BranchProtectionRule => "branch_protection_rule",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.CheckRun => "check_run",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.CheckSuite => "check_suite",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.CodeScanningAlert => "code_scanning_alert",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.CommitComment => "commit_comment",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.ContentReference => "content_reference",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Create => "create",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Delete => "delete",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Deployment => "deployment",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.DeploymentReview => "deployment_review",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.DeploymentStatus => "deployment_status",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.DeployKey => "deploy_key",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Discussion => "discussion",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.DiscussionComment => "discussion_comment",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Fork => "fork",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Gollum => "gollum",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Issues => "issues",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.IssueComment => "issue_comment",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Label => "label",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Member => "member",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Membership => "membership",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Milestone => "milestone",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Organization => "organization",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.OrgBlock => "org_block",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.PageBuild => "page_build",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Project => "project",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.ProjectCard => "project_card",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.ProjectColumn => "project_column",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Public => "public",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.PullRequest => "pull_request",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.PullRequestReview => "pull_request_review",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Push => "push",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.RegistryPackage => "registry_package",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Release => "release",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Repository => "repository",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.RepositoryDispatch => "repository_dispatch",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Star => "star",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Status => "status",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Team => "team",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.TeamAdd => "team_add",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Watch => "watch",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.WorkflowDispatch => "workflow_dispatch",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.BranchProtectionRule,
                "check_run" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.CheckRun,
                "check_suite" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.CheckSuite,
                "code_scanning_alert" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.CodeScanningAlert,
                "commit_comment" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.CommitComment,
                "content_reference" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.ContentReference,
                "create" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Create,
                "delete" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Delete,
                "deployment" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Deployment,
                "deployment_review" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.DeploymentReview,
                "deployment_status" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.DeploymentStatus,
                "deploy_key" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.DeployKey,
                "discussion" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Discussion,
                "discussion_comment" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.DiscussionComment,
                "fork" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Fork,
                "gollum" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Gollum,
                "issues" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Issues,
                "issue_comment" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.IssueComment,
                "label" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Label,
                "member" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Member,
                "membership" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Membership,
                "milestone" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Milestone,
                "organization" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Organization,
                "org_block" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.OrgBlock,
                "page_build" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.PageBuild,
                "project" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Project,
                "project_card" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.ProjectCard,
                "project_column" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.ProjectColumn,
                "public" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Public,
                "pull_request" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.PullRequest,
                "pull_request_review" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.PullRequestReview,
                "pull_request_review_comment" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.PullRequestReviewComment,
                "push" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Push,
                "registry_package" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.RegistryPackage,
                "release" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Release,
                "repository" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Repository,
                "repository_dispatch" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.SecretScanningAlert,
                "star" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Star,
                "status" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Status,
                "team" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Team,
                "team_add" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.TeamAdd,
                "watch" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.Watch,
                "workflow_dispatch" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.WorkflowDispatch,
                "workflow_run" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppEvents.WorkflowRun,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}